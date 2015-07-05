using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HttpRequestResponse
{
	public partial class Credentials : Form
	{
		internal string UserName
		{ get; private set; }

		internal string Password
		{ get; private set; }

		public Credentials()
		{
			InitializeComponent();
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			if (String.IsNullOrWhiteSpace(txtUserName.Text))
			{
				MessageBox.Show("A user name must be provided.", "Required Field Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else if (String.IsNullOrWhiteSpace(txtPassword.Text))
			{
				MessageBox.Show("A password must be provided.", "Required Field Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				UserName = txtUserName.Text;
				Password = txtPassword.Text;
				Close();
			}
		}
	}
}
