#region using
using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;
using Microsoft.Win32;
#endregion using

namespace HttpChecker
{
    public partial class MainForm : Form
    {
        #region Constructors
        public MainForm()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            txtUrl.Select( txtUrl.TextLength, 0 );

            try
            {
                RegistryKey hkcu = Registry.CurrentUser;

                RegistryKey httpChecker = hkcu.CreateSubKey( "Software\\HttpChecker" );

                int left = (int)httpChecker.GetValue( "Left", 10 );
                int top = (int)httpChecker.GetValue( "Top", 10 );
                int width = (int)httpChecker.GetValue( "Width", this.Width );
                int height = (int)httpChecker.GetValue( "Height", this.Height );

                this.Location = new Point( left, top );
                this.Size = new Size( width, height );
            }
            catch
            {
                MessageBox.Show( "There was a problem getting your saved settings from the registry.", this.Text );
            }
        }
        #endregion Constructors

        #region Event Handlers
        protected void btnExit_Click( object sender, EventArgs e )
        {
            this.Close();
            this.Dispose();
        }

        protected void btnGo_Click( object sender, EventArgs e )
        {
            Cursor.Current = Cursors.WaitCursor;
            GetHeaders();
            Cursor.Current = Cursors.Default;
        }

        private void MainForm2_FormClosing( object sender, FormClosingEventArgs e )
        {
            try
            {
                RegistryKey hkcu = Registry.CurrentUser;
                RegistryKey httpChecker = hkcu.CreateSubKey( "Software\\HttpChecker" );

                httpChecker.SetValue( "Left", this.Left );
                httpChecker.SetValue( "Top", this.Top );
                httpChecker.SetValue( "Width", this.Width );
                httpChecker.SetValue( "Height", this.Height );
            }
            catch
            {
                MessageBox.Show( "There was a problem saving your settings to the registry.", this.Text );
            }
        }
        #endregion Event Handlers

        #region Private Methods
        private bool ValidateUrl( ref string Url )
        {
            bool rv = true;
            int index = Url.IndexOf( "//" );

            if( !Url.StartsWith( "http://" ) && !Url.StartsWith( "https://" ) )
            {
                if( Url.StartsWith( "//" ) )						    // user entered "//www.steptech.com"
                    Url = "http:" + Url;
                else if( Url.StartsWith( "http:" ) && index == -1 )	    // user entered "http:www.steptech.com
                    Url = Url.Insert( 5, "//" );
                else if( Url.StartsWith( "https:" ) && index == -1 )    // user entered "https:www.steptech.com
                    Url = Url.Insert( 6, "//" );
                else if( index == -1 )								    // user entered "www.steptech.com"
                    Url = "http://" + Url;
                else												    // who knows what user entered, perhaps "ftp://ftp.steptech.com"
                    rv = false;
            }

            return rv;
        }

        private void GetHeaders()
        {
            try
            {
                string Url = txtUrl.Text;

                if( this.ValidateUrl( ref Url ) )
                {
                    txtUrl.Text = Url;

                    txtBody.Text = "";
                    txtRawHeaders.Text = "";

                    HttpWebRequest req = (HttpWebRequest)WebRequest.Create( txtUrl.Text );

                    if( txtUsername.Text.Length > 0 && txtPassword.Text.Length > 0 )
                    {
                        req.Credentials = new NetworkCredential( txtUsername.Text, txtPassword.Text, "portland" );
                    }

                    HttpWebResponse res = (HttpWebResponse)req.GetResponse();

                    txtServer.Text = res.Server;
                    txtMethod.Text = res.Method + " HTTP " + res.ProtocolVersion;

                    string[] formattedDates = res.LastModified.GetDateTimeFormats( 'F' );
                    txtModified.Text = formattedDates[4];

                    txtLength.Text = res.ContentLength.ToString();
                    txtEncoding.Text = res.ContentEncoding;
                    txtContentType.Text = res.ContentType;

                    txtRequest.Text = res.Method + " " + res.ResponseUri;
                    txtStatus.Text = ( (int)res.StatusCode ).ToString() + " " + res.StatusDescription;
                    txtRawHeaders.Text = res.Headers.ToString();

                    if( res.ContentType.ToLower().IndexOf( "text/html" ) != -1 )
                    {
                        StreamReader sr = new StreamReader( res.GetResponseStream(), true );

                        txtBody.Text = sr.ReadToEnd();

                        sr.Close();
                    }
                }
                else
                {
                    MessageBox.Show( "URL appears to be invalid. Must be in the form \"http://<server>/<resource>\".", this.Text );
                }
            }
            catch( IOException ioe )
            {
                MessageBox.Show( "An error occurred reading the results from the server.\r\n\r\nMessage:\t" + ioe.Message + "\r\n\r\nTrace\r\n" + ioe.StackTrace, this.Text );
            }
            catch( NotSupportedException nse )
            {
                MessageBox.Show( "An error occurred creating the request.\r\n\r\nMessage:\t" + nse.Message + "\r\n\r\nTrace\r\n" + nse.StackTrace, this.Text );
            }
            catch( WebException we )
            {
                MessageBox.Show( "An error occurred creating the request.\r\n\r\nMessage:\t" + we.Message + "\r\n\r\nTrace\r\n" + we.StackTrace, this.Text );
            }
            catch( Exception ex )
            {
                MessageBox.Show( "An error occurred.\r\n\r\nMessage:\t" + ex.Message + "\r\n\r\nTrace\r\n" + ex.StackTrace, this.Text );
            }
            finally
            {
                txtUrl.Focus();
            }
        }
        #endregion Private Methods
    }
}
