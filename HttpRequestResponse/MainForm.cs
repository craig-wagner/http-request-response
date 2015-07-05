#region using
using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
#endregion using

namespace HttpRequestResponse
{
	public partial class MainForm : Form
	{
		#region Constructors
		public MainForm()
		{
			InitializeComponent();

			txtUrl.Select(txtUrl.TextLength, 0);

			try
			{
				var hkcu = Registry.CurrentUser;

				var httpChecker = hkcu.CreateSubKey("Software\\HttpChecker");

				int left = (int)httpChecker.GetValue("Left", 10);
				int top = (int)httpChecker.GetValue("Top", 10);
				int width = (int)httpChecker.GetValue("Width", this.Width);
				int height = (int)httpChecker.GetValue("Height", this.Height);

				this.Location = new Point(left, top);
				this.Size = new Size(width, height);
			}
			catch
			{
				MessageBox.Show("There was a problem getting your saved settings from the registry.", this.Text);
			}
		}
		#endregion Constructors

		protected void btnExit_Click(object sender, EventArgs e)
		{
			this.Close();
			this.Dispose();
		}

		protected void btnGo_Click(object sender, EventArgs e)
		{
			Cursor.Current = Cursors.WaitCursor;
			GetHeaders();
			Cursor.Current = Cursors.Default;
		}

		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			try
			{
				var hkcu = Registry.CurrentUser;
				var httpChecker = hkcu.CreateSubKey("Software\\HttpChecker");

				httpChecker.SetValue("Left", this.Left);
				httpChecker.SetValue("Top", this.Top);
				httpChecker.SetValue("Width", this.Width);
				httpChecker.SetValue("Height", this.Height);
			}
			catch
			{
				MessageBox.Show("There was a problem saving your settings to the registry.", this.Text);
			}
		}

		private bool ValidateUrl(ref string url)
		{
			var rv = true;
			var index = url.IndexOf("//");

			if (!url.StartsWith("http://") && !url.StartsWith("https://"))
			{
				if (url.StartsWith("//"))                           // user entered "//www.steptech.com"
					url = "http:" + url;
				else if (url.StartsWith("http:") && index == -1)        // user entered "http:www.steptech.com
					url = url.Insert(5, "//");
				else if (url.StartsWith("https:") && index == -1)    // user entered "https:www.steptech.com
					url = url.Insert(6, "//");
				else if (index == -1)                                   // user entered "www.steptech.com"
					url = "http://" + url;
				else                                                    // who knows what user entered, perhaps "ftp://ftp.steptech.com"
					rv = false;
			}

			return rv;
		}

		private async void GetHeaders()
		{
			try
			{
				var url = txtUrl.Text;

				if (this.ValidateUrl(ref url))
				{
					txtUrl.Text = url;

					txtBody.Text = String.Empty;
					txtRawHeaders.Text = String.Empty;

					var response = await SendRequest();

					var server = new StringBuilder();
					if (response.Headers.Server != null)
					{
						foreach (var item in response.Headers.Server)
						{
							if (!String.IsNullOrWhiteSpace(item.Product.Name))
							{
								if (server.Length > 0)
								{
									server.Append("; ");
								}

								server.Append(item.Product.Name);

								if (!String.IsNullOrWhiteSpace(item.Product.Version))
								{
									server.Append(" (");
									server.Append(item.Product.Version);
									server.Append(")");
								}
							}
						}
					}
					txtServer.Text = server.ToString();

					txtMethod.Text = response.RequestMessage.Method.Method + " HTTP/" + response.RequestMessage.Version.ToString();

					txtModified.Text = response.Content.Headers.LastModified?.ToString(); 

					txtLength.Text = response.Content.Headers.ContentLength?.ToString();
					txtEncoding.Text = String.Join(", ", response.Content.Headers.ContentEncoding);
					txtContentType.Text = response.Content.Headers.ContentType.MediaType;

					txtRequest.Text = response.RequestMessage.Method.Method + " " + response.RequestMessage.RequestUri;
					txtStatus.Text = (int)response.StatusCode + " " + response.ReasonPhrase;
					txtRawHeaders.Text = response.Headers.ToString();

					if (response.Content.Headers.ContentType.MediaType == "text/html")
					{
						txtBody.Text = await response.Content.ReadAsStringAsync();
						webBrowser.DocumentText = txtBody.Text;
					}
				}
				else
				{
					MessageBox.Show("URL appears to be invalid. Must be in the form \"http://<server>/<resource>\".", this.Text);
				}
			}
			catch (IOException ioe)
			{
				MessageBox.Show("An error occurred reading the results from the server.\r\n\r\nMessage:\t" + ioe.Message + "\r\n\r\nTrace\r\n" + ioe.StackTrace, this.Text);
			}
			catch (NotSupportedException nse)
			{
				MessageBox.Show("An error occurred creating the request.\r\n\r\nMessage:\t" + nse.Message + "\r\n\r\nTrace\r\n" + nse.StackTrace, this.Text);
			}
			catch (WebException we)
			{
				MessageBox.Show("An error occurred creating the request.\r\n\r\nMessage:\t" + we.Message + "\r\n\r\nTrace\r\n" + we.StackTrace, this.Text);
			}
			catch (Exception ex)
			{
				MessageBox.Show("An error occurred.\r\n\r\nMessage:\t" + ex.Message + "\r\n\r\nTrace\r\n" + ex.StackTrace, this.Text);
			}
			finally
			{
				txtUrl.Focus();
			}
		}

		private async Task<HttpResponseMessage> SendRequest()
		{
			var keepTrying = true;
			HttpResponseMessage response = null;

			while (keepTrying == true)
			{
				using (var client = new HttpClient())
				{
					response = await client.GetAsync(txtUrl.Text);
				}

				switch (response.StatusCode)
				{
					case HttpStatusCode.Unauthorized:
						using (var dialog = new Credentials())
						{
							if (dialog.ShowDialog() == DialogResult.OK)
							{
								using (var handler = new HttpClientHandler
								{
									Credentials = new NetworkCredential(dialog.UserName, dialog.Password)
								})
								using (var client = new HttpClient(handler))
								{
									response = await client.GetAsync(txtUrl.Text);
								}
							}
							else
							{
								keepTrying = false;
							}
						}
						break;

					default:
						keepTrying = false;
						break;
				}
			}

			return response;
		}
	}
}
