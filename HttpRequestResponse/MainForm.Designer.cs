namespace HttpRequestResponse
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.btnExit = new System.Windows.Forms.Button();
			this.btnGo = new System.Windows.Forms.Button();
			this.txtUrl = new System.Windows.Forms.TextBox();
			this.lblUrl = new System.Windows.Forms.Label();
			this.tabHttpResponse = new System.Windows.Forms.TabControl();
			this.tabPageHeaders = new System.Windows.Forms.TabPage();
			this.lblRawHeaders = new System.Windows.Forms.Label();
			this.txtRawHeaders = new System.Windows.Forms.TextBox();
			this.txtModified = new System.Windows.Forms.TextBox();
			this.lblModified = new System.Windows.Forms.Label();
			this.txtContentType = new System.Windows.Forms.TextBox();
			this.lblContentType = new System.Windows.Forms.Label();
			this.txtStatus = new System.Windows.Forms.TextBox();
			this.lblStatus = new System.Windows.Forms.Label();
			this.txtRequest = new System.Windows.Forms.TextBox();
			this.lblRequest = new System.Windows.Forms.Label();
			this.txtLength = new System.Windows.Forms.TextBox();
			this.lblLength = new System.Windows.Forms.Label();
			this.txtEncoding = new System.Windows.Forms.TextBox();
			this.lblEncoding = new System.Windows.Forms.Label();
			this.txtMethod = new System.Windows.Forms.TextBox();
			this.lblMethod = new System.Windows.Forms.Label();
			this.txtServer = new System.Windows.Forms.TextBox();
			this.lblServer = new System.Windows.Forms.Label();
			this.tabPageBody = new System.Windows.Forms.TabPage();
			this.txtBody = new System.Windows.Forms.TextBox();
			this.tabPageBrowser = new System.Windows.Forms.TabPage();
			this.webBrowser = new System.Windows.Forms.WebBrowser();
			this.tabHttpResponse.SuspendLayout();
			this.tabPageHeaders.SuspendLayout();
			this.tabPageBody.SuspendLayout();
			this.tabPageBrowser.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(497, 8);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(75, 23);
			this.btnExit.TabIndex = 13;
			this.btnExit.Text = "Exit";
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// btnGo
			// 
			this.btnGo.Location = new System.Drawing.Point(411, 8);
			this.btnGo.Name = "btnGo";
			this.btnGo.Size = new System.Drawing.Size(75, 23);
			this.btnGo.TabIndex = 12;
			this.btnGo.Text = "Go";
			this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
			// 
			// txtUrl
			// 
			this.txtUrl.Location = new System.Drawing.Point(48, 9);
			this.txtUrl.Name = "txtUrl";
			this.txtUrl.Size = new System.Drawing.Size(356, 20);
			this.txtUrl.TabIndex = 9;
			this.txtUrl.Text = "http://";
			// 
			// lblUrl
			// 
			this.lblUrl.Location = new System.Drawing.Point(12, 13);
			this.lblUrl.Name = "lblUrl";
			this.lblUrl.Size = new System.Drawing.Size(33, 11);
			this.lblUrl.TabIndex = 7;
			this.lblUrl.Text = "URL:";
			this.lblUrl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// tabHttpResponse
			// 
			this.tabHttpResponse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabHttpResponse.Controls.Add(this.tabPageHeaders);
			this.tabHttpResponse.Controls.Add(this.tabPageBody);
			this.tabHttpResponse.Controls.Add(this.tabPageBrowser);
			this.tabHttpResponse.Location = new System.Drawing.Point(11, 37);
			this.tabHttpResponse.Name = "tabHttpResponse";
			this.tabHttpResponse.SelectedIndex = 0;
			this.tabHttpResponse.Size = new System.Drawing.Size(563, 323);
			this.tabHttpResponse.TabIndex = 14;
			// 
			// tabPageHeaders
			// 
			this.tabPageHeaders.Controls.Add(this.lblRawHeaders);
			this.tabPageHeaders.Controls.Add(this.txtRawHeaders);
			this.tabPageHeaders.Controls.Add(this.txtModified);
			this.tabPageHeaders.Controls.Add(this.lblModified);
			this.tabPageHeaders.Controls.Add(this.txtContentType);
			this.tabPageHeaders.Controls.Add(this.lblContentType);
			this.tabPageHeaders.Controls.Add(this.txtStatus);
			this.tabPageHeaders.Controls.Add(this.lblStatus);
			this.tabPageHeaders.Controls.Add(this.txtRequest);
			this.tabPageHeaders.Controls.Add(this.lblRequest);
			this.tabPageHeaders.Controls.Add(this.txtLength);
			this.tabPageHeaders.Controls.Add(this.lblLength);
			this.tabPageHeaders.Controls.Add(this.txtEncoding);
			this.tabPageHeaders.Controls.Add(this.lblEncoding);
			this.tabPageHeaders.Controls.Add(this.txtMethod);
			this.tabPageHeaders.Controls.Add(this.lblMethod);
			this.tabPageHeaders.Controls.Add(this.txtServer);
			this.tabPageHeaders.Controls.Add(this.lblServer);
			this.tabPageHeaders.Location = new System.Drawing.Point(4, 22);
			this.tabPageHeaders.Name = "tabPageHeaders";
			this.tabPageHeaders.Size = new System.Drawing.Size(555, 297);
			this.tabPageHeaders.TabIndex = 0;
			this.tabPageHeaders.Text = "HTTP Headers";
			// 
			// lblRawHeaders
			// 
			this.lblRawHeaders.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
			this.lblRawHeaders.Location = new System.Drawing.Point(8, 136);
			this.lblRawHeaders.Name = "lblRawHeaders";
			this.lblRawHeaders.Size = new System.Drawing.Size(112, 12);
			this.lblRawHeaders.TabIndex = 16;
			this.lblRawHeaders.Text = "Raw Headers";
			// 
			// txtRawHeaders
			// 
			this.txtRawHeaders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtRawHeaders.Location = new System.Drawing.Point(8, 153);
			this.txtRawHeaders.Multiline = true;
			this.txtRawHeaders.Name = "txtRawHeaders";
			this.txtRawHeaders.ReadOnly = true;
			this.txtRawHeaders.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtRawHeaders.Size = new System.Drawing.Size(536, 141);
			this.txtRawHeaders.TabIndex = 5;
			this.txtRawHeaders.TabStop = false;
			// 
			// txtModified
			// 
			this.txtModified.Location = new System.Drawing.Point(62, 57);
			this.txtModified.Name = "txtModified";
			this.txtModified.ReadOnly = true;
			this.txtModified.Size = new System.Drawing.Size(197, 20);
			this.txtModified.TabIndex = 15;
			this.txtModified.TabStop = false;
			// 
			// lblModified
			// 
			this.lblModified.Location = new System.Drawing.Point(7, 60);
			this.lblModified.Name = "lblModified";
			this.lblModified.Size = new System.Drawing.Size(50, 14);
			this.lblModified.TabIndex = 14;
			this.lblModified.Text = "Modified:";
			this.lblModified.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtContentType
			// 
			this.txtContentType.Location = new System.Drawing.Point(370, 57);
			this.txtContentType.Name = "txtContentType";
			this.txtContentType.ReadOnly = true;
			this.txtContentType.Size = new System.Drawing.Size(173, 20);
			this.txtContentType.TabIndex = 13;
			this.txtContentType.TabStop = false;
			// 
			// lblContentType
			// 
			this.lblContentType.Location = new System.Drawing.Point(264, 60);
			this.lblContentType.Name = "lblContentType";
			this.lblContentType.Size = new System.Drawing.Size(104, 14);
			this.lblContentType.TabIndex = 12;
			this.lblContentType.Text = "Content Type:";
			this.lblContentType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtStatus
			// 
			this.txtStatus.Location = new System.Drawing.Point(62, 108);
			this.txtStatus.Name = "txtStatus";
			this.txtStatus.ReadOnly = true;
			this.txtStatus.Size = new System.Drawing.Size(482, 20);
			this.txtStatus.TabIndex = 11;
			this.txtStatus.TabStop = false;
			// 
			// lblStatus
			// 
			this.lblStatus.Location = new System.Drawing.Point(7, 111);
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(50, 14);
			this.lblStatus.TabIndex = 10;
			this.lblStatus.Text = "Status:";
			this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtRequest
			// 
			this.txtRequest.Location = new System.Drawing.Point(62, 83);
			this.txtRequest.Name = "txtRequest";
			this.txtRequest.ReadOnly = true;
			this.txtRequest.Size = new System.Drawing.Size(482, 20);
			this.txtRequest.TabIndex = 9;
			this.txtRequest.TabStop = false;
			// 
			// lblRequest
			// 
			this.lblRequest.Location = new System.Drawing.Point(7, 86);
			this.lblRequest.Name = "lblRequest";
			this.lblRequest.Size = new System.Drawing.Size(50, 14);
			this.lblRequest.TabIndex = 8;
			this.lblRequest.Text = "Request:";
			this.lblRequest.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtLength
			// 
			this.txtLength.Location = new System.Drawing.Point(370, 31);
			this.txtLength.Name = "txtLength";
			this.txtLength.ReadOnly = true;
			this.txtLength.Size = new System.Drawing.Size(173, 20);
			this.txtLength.TabIndex = 7;
			this.txtLength.TabStop = false;
			// 
			// lblLength
			// 
			this.lblLength.Location = new System.Drawing.Point(264, 34);
			this.lblLength.Name = "lblLength";
			this.lblLength.Size = new System.Drawing.Size(104, 14);
			this.lblLength.TabIndex = 6;
			this.lblLength.Text = "Content Length:";
			this.lblLength.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtEncoding
			// 
			this.txtEncoding.Location = new System.Drawing.Point(370, 5);
			this.txtEncoding.Name = "txtEncoding";
			this.txtEncoding.ReadOnly = true;
			this.txtEncoding.Size = new System.Drawing.Size(173, 20);
			this.txtEncoding.TabIndex = 5;
			this.txtEncoding.TabStop = false;
			// 
			// lblEncoding
			// 
			this.lblEncoding.Location = new System.Drawing.Point(264, 8);
			this.lblEncoding.Name = "lblEncoding";
			this.lblEncoding.Size = new System.Drawing.Size(104, 14);
			this.lblEncoding.TabIndex = 4;
			this.lblEncoding.Text = "Content Encoding:";
			this.lblEncoding.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtMethod
			// 
			this.txtMethod.Location = new System.Drawing.Point(62, 31);
			this.txtMethod.Name = "txtMethod";
			this.txtMethod.ReadOnly = true;
			this.txtMethod.Size = new System.Drawing.Size(197, 20);
			this.txtMethod.TabIndex = 3;
			this.txtMethod.TabStop = false;
			// 
			// lblMethod
			// 
			this.lblMethod.Location = new System.Drawing.Point(7, 34);
			this.lblMethod.Name = "lblMethod";
			this.lblMethod.Size = new System.Drawing.Size(50, 14);
			this.lblMethod.TabIndex = 2;
			this.lblMethod.Text = "Method:";
			this.lblMethod.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtServer
			// 
			this.txtServer.Location = new System.Drawing.Point(62, 5);
			this.txtServer.Name = "txtServer";
			this.txtServer.ReadOnly = true;
			this.txtServer.Size = new System.Drawing.Size(197, 20);
			this.txtServer.TabIndex = 1;
			this.txtServer.TabStop = false;
			// 
			// lblServer
			// 
			this.lblServer.Location = new System.Drawing.Point(7, 8);
			this.lblServer.Name = "lblServer";
			this.lblServer.Size = new System.Drawing.Size(50, 14);
			this.lblServer.TabIndex = 0;
			this.lblServer.Text = "Server:";
			this.lblServer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// tabPageBody
			// 
			this.tabPageBody.Controls.Add(this.txtBody);
			this.tabPageBody.Location = new System.Drawing.Point(4, 22);
			this.tabPageBody.Name = "tabPageBody";
			this.tabPageBody.Size = new System.Drawing.Size(555, 297);
			this.tabPageBody.TabIndex = 1;
			this.tabPageBody.Text = "Response Body";
			// 
			// txtBody
			// 
			this.txtBody.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtBody.Location = new System.Drawing.Point(0, 0);
			this.txtBody.Multiline = true;
			this.txtBody.Name = "txtBody";
			this.txtBody.ReadOnly = true;
			this.txtBody.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtBody.Size = new System.Drawing.Size(555, 262);
			this.txtBody.TabIndex = 0;
			this.txtBody.TabStop = false;
			// 
			// tabPageBrowser
			// 
			this.tabPageBrowser.Controls.Add(this.webBrowser);
			this.tabPageBrowser.Location = new System.Drawing.Point(4, 22);
			this.tabPageBrowser.Name = "tabPageBrowser";
			this.tabPageBrowser.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageBrowser.Size = new System.Drawing.Size(555, 297);
			this.tabPageBrowser.TabIndex = 2;
			this.tabPageBrowser.Text = "Browser";
			this.tabPageBrowser.UseVisualStyleBackColor = true;
			// 
			// webBrowser
			// 
			this.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
			this.webBrowser.Location = new System.Drawing.Point(3, 3);
			this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
			this.webBrowser.Name = "webBrowser";
			this.webBrowser.Size = new System.Drawing.Size(549, 291);
			this.webBrowser.TabIndex = 0;
			// 
			// MainForm
			// 
			this.AcceptButton = this.btnGo;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(584, 365);
			this.Controls.Add(this.tabHttpResponse);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnGo);
			this.Controls.Add(this.txtUrl);
			this.Controls.Add(this.lblUrl);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(592, 399);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "HTTP Sniffer";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.tabHttpResponse.ResumeLayout(false);
			this.tabPageHeaders.ResumeLayout(false);
			this.tabPageHeaders.PerformLayout();
			this.tabPageBody.ResumeLayout(false);
			this.tabPageBody.PerformLayout();
			this.tabPageBrowser.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.TabControl tabHttpResponse;
        private System.Windows.Forms.TabPage tabPageHeaders;
        private System.Windows.Forms.Label lblRawHeaders;
        private System.Windows.Forms.TextBox txtRawHeaders;
        private System.Windows.Forms.TextBox txtModified;
        private System.Windows.Forms.Label lblModified;
        private System.Windows.Forms.TextBox txtContentType;
        private System.Windows.Forms.Label lblContentType;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtRequest;
        private System.Windows.Forms.Label lblRequest;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.TextBox txtEncoding;
        private System.Windows.Forms.Label lblEncoding;
        private System.Windows.Forms.TextBox txtMethod;
        private System.Windows.Forms.Label lblMethod;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.Label lblServer;
        private System.Windows.Forms.TabPage tabPageBody;
        private System.Windows.Forms.TextBox txtBody;
		private System.Windows.Forms.TabPage tabPageBrowser;
		private System.Windows.Forms.WebBrowser webBrowser;
	}
}