namespace QuickLogin
{
    partial class frmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lbVersion = new System.Windows.Forms.Label();
            this.lbBBS = new System.Windows.Forms.Label();
            this.lbBaidu = new System.Windows.Forms.Label();
            this.lbDDO = new System.Windows.Forms.Label();
            this.lbWiki = new System.Windows.Forms.Label();
            this.lbAccount = new System.Windows.Forms.Label();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.tcServicePanel = new System.Windows.Forms.TabControl();
            this.tpConn = new System.Windows.Forms.TabPage();
            this.rtxtInfo = new System.Windows.Forms.RichTextBox();
            this.tpUpdate = new System.Windows.Forms.TabPage();
            this.tpLogin = new System.Windows.Forms.TabPage();
            this.cbxRemember = new System.Windows.Forms.CheckBox();
            this.lbSev = new System.Windows.Forms.Label();
            this.lbPWD = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.cblUsername = new System.Windows.Forms.ComboBox();
            this.cblServerList = new System.Windows.Forms.ComboBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.txtServerInfo = new QuickLogin.RichTextBoxEx();
            this.txtInfo = new QuickLogin.RichTextBoxEx();
            this.tcServicePanel.SuspendLayout();
            this.tpConn.SuspendLayout();
            this.tpLogin.SuspendLayout();
            this.pnlLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbVersion
            // 
            this.lbVersion.AutoSize = true;
            this.lbVersion.BackColor = System.Drawing.Color.Transparent;
            this.lbVersion.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbVersion.ForeColor = System.Drawing.Color.White;
            this.lbVersion.Location = new System.Drawing.Point(74, 456);
            this.lbVersion.Name = "lbVersion";
            this.lbVersion.Size = new System.Drawing.Size(31, 19);
            this.lbVersion.TabIndex = 1;
            this.lbVersion.Text = "2.3";
            // 
            // lbBBS
            // 
            this.lbBBS.AutoSize = true;
            this.lbBBS.BackColor = System.Drawing.Color.Transparent;
            this.lbBBS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbBBS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbBBS.ForeColor = System.Drawing.Color.White;
            this.lbBBS.Location = new System.Drawing.Point(238, 22);
            this.lbBBS.Name = "lbBBS";
            this.lbBBS.Size = new System.Drawing.Size(43, 20);
            this.lbBBS.TabIndex = 2;
            this.lbBBS.Text = "更新";
            this.lbBBS.Click += new System.EventHandler(this.lbBBS_Click);
            // 
            // lbBaidu
            // 
            this.lbBaidu.AutoSize = true;
            this.lbBaidu.BackColor = System.Drawing.Color.Transparent;
            this.lbBaidu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbBaidu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbBaidu.ForeColor = System.Drawing.Color.White;
            this.lbBaidu.Location = new System.Drawing.Point(323, 22);
            this.lbBaidu.Name = "lbBaidu";
            this.lbBaidu.Size = new System.Drawing.Size(77, 20);
            this.lbBaidu.TabIndex = 3;
            this.lbBaidu.Text = "百度贴吧";
            this.lbBaidu.Click += new System.EventHandler(this.lbBaidu_Click);
            // 
            // lbDDO
            // 
            this.lbDDO.AutoSize = true;
            this.lbDDO.BackColor = System.Drawing.Color.Transparent;
            this.lbDDO.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbDDO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbDDO.ForeColor = System.Drawing.Color.White;
            this.lbDDO.Location = new System.Drawing.Point(515, 22);
            this.lbDDO.Name = "lbDDO";
            this.lbDDO.Size = new System.Drawing.Size(82, 20);
            this.lbDDO.TabIndex = 4;
            this.lbDDO.Text = "DDO官网";
            this.lbDDO.Click += new System.EventHandler(this.lbDDO_Click);
            // 
            // lbWiki
            // 
            this.lbWiki.AutoSize = true;
            this.lbWiki.BackColor = System.Drawing.Color.Transparent;
            this.lbWiki.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbWiki.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbWiki.ForeColor = System.Drawing.Color.White;
            this.lbWiki.Location = new System.Drawing.Point(417, 22);
            this.lbWiki.Name = "lbWiki";
            this.lbWiki.Size = new System.Drawing.Size(86, 20);
            this.lbWiki.TabIndex = 5;
            this.lbWiki.Text = "DDO Wiki";
            this.lbWiki.Click += new System.EventHandler(this.lbWiki_Click);
            // 
            // lbAccount
            // 
            this.lbAccount.AutoSize = true;
            this.lbAccount.BackColor = System.Drawing.Color.Transparent;
            this.lbAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbAccount.ForeColor = System.Drawing.Color.White;
            this.lbAccount.Location = new System.Drawing.Point(602, 22);
            this.lbAccount.Name = "lbAccount";
            this.lbAccount.Size = new System.Drawing.Size(87, 20);
            this.lbAccount.TabIndex = 6;
            this.lbAccount.Text = "DDO 账户";
            this.lbAccount.Click += new System.EventHandler(this.lbAccount_Click);
            // 
            // btnMin
            // 
            this.btnMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMin.Image = global::QuickLogin.Properties.Resources.M;
            this.btnMin.Location = new System.Drawing.Point(690, 17);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(24, 24);
            this.btnMin.TabIndex = 7;
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Image = global::QuickLogin.Properties.Resources.X;
            this.btnClose.Location = new System.Drawing.Point(719, 17);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(24, 24);
            this.btnClose.TabIndex = 8;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tcServicePanel
            // 
            this.tcServicePanel.Controls.Add(this.tpConn);
            this.tcServicePanel.Controls.Add(this.tpUpdate);
            this.tcServicePanel.Controls.Add(this.tpLogin);
            this.tcServicePanel.Location = new System.Drawing.Point(0, -3);
            this.tcServicePanel.Margin = new System.Windows.Forms.Padding(0);
            this.tcServicePanel.Name = "tcServicePanel";
            this.tcServicePanel.SelectedIndex = 0;
            this.tcServicePanel.Size = new System.Drawing.Size(348, 236);
            this.tcServicePanel.TabIndex = 1;
            this.tcServicePanel.TabStop = false;
            // 
            // tpConn
            // 
            this.tpConn.BackColor = System.Drawing.Color.Black;
            this.tpConn.Controls.Add(this.rtxtInfo);
            this.tpConn.Location = new System.Drawing.Point(4, 22);
            this.tpConn.Margin = new System.Windows.Forms.Padding(0);
            this.tpConn.Name = "tpConn";
            this.tpConn.Size = new System.Drawing.Size(340, 210);
            this.tpConn.TabIndex = 0;
            this.tpConn.Text = "连接";
            // 
            // rtxtInfo
            // 
            this.rtxtInfo.BackColor = System.Drawing.Color.Black;
            this.rtxtInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxtInfo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtInfo.ForeColor = System.Drawing.Color.Lime;
            this.rtxtInfo.Location = new System.Drawing.Point(0, 0);
            this.rtxtInfo.Name = "rtxtInfo";
            this.rtxtInfo.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtxtInfo.Size = new System.Drawing.Size(340, 210);
            this.rtxtInfo.TabIndex = 10;
            this.rtxtInfo.TabStop = false;
            this.rtxtInfo.Text = "";
            // 
            // tpUpdate
            // 
            this.tpUpdate.BackColor = System.Drawing.Color.Black;
            this.tpUpdate.Location = new System.Drawing.Point(4, 22);
            this.tpUpdate.Margin = new System.Windows.Forms.Padding(0);
            this.tpUpdate.Name = "tpUpdate";
            this.tpUpdate.Size = new System.Drawing.Size(340, 210);
            this.tpUpdate.TabIndex = 1;
            this.tpUpdate.Text = "更新";
            // 
            // tpLogin
            // 
            this.tpLogin.BackColor = System.Drawing.Color.Black;
            this.tpLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tpLogin.Controls.Add(this.cbxRemember);
            this.tpLogin.Controls.Add(this.lbSev);
            this.tpLogin.Controls.Add(this.lbPWD);
            this.tpLogin.Controls.Add(this.lbID);
            this.tpLogin.Controls.Add(this.btnLogin);
            this.tpLogin.Controls.Add(this.cblUsername);
            this.tpLogin.Controls.Add(this.cblServerList);
            this.tpLogin.Controls.Add(this.txtPassword);
            this.tpLogin.Location = new System.Drawing.Point(4, 22);
            this.tpLogin.Margin = new System.Windows.Forms.Padding(0);
            this.tpLogin.Name = "tpLogin";
            this.tpLogin.Size = new System.Drawing.Size(340, 210);
            this.tpLogin.TabIndex = 2;
            this.tpLogin.Text = "登录";
            // 
            // cbxRemember
            // 
            this.cbxRemember.AutoSize = true;
            this.cbxRemember.BackColor = System.Drawing.Color.Transparent;
            this.cbxRemember.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbxRemember.Checked = true;
            this.cbxRemember.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxRemember.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.cbxRemember.ForeColor = System.Drawing.Color.White;
            this.cbxRemember.Location = new System.Drawing.Point(205, 83);
            this.cbxRemember.Name = "cbxRemember";
            this.cbxRemember.Size = new System.Drawing.Size(54, 16);
            this.cbxRemember.TabIndex = 3;
            this.cbxRemember.TabStop = false;
            this.cbxRemember.Text = "记住?";
            this.cbxRemember.UseVisualStyleBackColor = false;
            // 
            // lbSev
            // 
            this.lbSev.AutoSize = true;
            this.lbSev.BackColor = System.Drawing.Color.Transparent;
            this.lbSev.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbSev.ForeColor = System.Drawing.Color.White;
            this.lbSev.Location = new System.Drawing.Point(39, 16);
            this.lbSev.Name = "lbSev";
            this.lbSev.Size = new System.Drawing.Size(56, 18);
            this.lbSev.TabIndex = 14;
            this.lbSev.Text = "服务器";
            this.lbSev.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbPWD
            // 
            this.lbPWD.AutoSize = true;
            this.lbPWD.BackColor = System.Drawing.Color.Transparent;
            this.lbPWD.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbPWD.ForeColor = System.Drawing.Color.White;
            this.lbPWD.Location = new System.Drawing.Point(38, 103);
            this.lbPWD.Name = "lbPWD";
            this.lbPWD.Size = new System.Drawing.Size(50, 18);
            this.lbPWD.TabIndex = 13;
            this.lbPWD.Text = "密  码";
            this.lbPWD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.BackColor = System.Drawing.Color.Transparent;
            this.lbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbID.ForeColor = System.Drawing.Color.White;
            this.lbID.Location = new System.Drawing.Point(39, 60);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(56, 18);
            this.lbID.TabIndex = 12;
            this.lbID.Text = "用户名";
            this.lbID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btnLogin.Location = new System.Drawing.Point(60, 142);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(184, 37);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "登录";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // cblUsername
            // 
            this.cblUsername.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cblUsername.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.cblUsername.FormattingEnabled = true;
            this.cblUsername.Location = new System.Drawing.Point(107, 60);
            this.cblUsername.Name = "cblUsername";
            this.cblUsername.Size = new System.Drawing.Size(152, 20);
            this.cblUsername.TabIndex = 2;
            this.cblUsername.TextChanged += new System.EventHandler(this.cblUsername_TextChanged);
            // 
            // cblServerList
            // 
            this.cblServerList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cblServerList.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cblServerList.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.cblServerList.FormattingEnabled = true;
            this.cblServerList.Location = new System.Drawing.Point(107, 16);
            this.cblServerList.Name = "cblServerList";
            this.cblServerList.Size = new System.Drawing.Size(152, 20);
            this.cblServerList.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPassword.Location = new System.Drawing.Point(107, 101);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(152, 21);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.WordWrap = false;
            // 
            // pnlLogin
            // 
            this.pnlLogin.BackColor = System.Drawing.Color.Transparent;
            this.pnlLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLogin.Controls.Add(this.tcServicePanel);
            this.pnlLogin.Location = new System.Drawing.Point(395, 96);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(322, 193);
            this.pnlLogin.TabIndex = 10;
            // 
            // txtServerInfo
            // 
            this.txtServerInfo.BackColor = System.Drawing.Color.Black;
            this.txtServerInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtServerInfo.Font = new System.Drawing.Font("宋体", 12F);
            this.txtServerInfo.ForeColor = System.Drawing.Color.Lime;
            this.txtServerInfo.Location = new System.Drawing.Point(45, 96);
            this.txtServerInfo.Margin = new System.Windows.Forms.Padding(0);
            this.txtServerInfo.Name = "txtServerInfo";
            this.txtServerInfo.ReadOnly = true;
            this.txtServerInfo.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtServerInfo.Size = new System.Drawing.Size(235, 360);
            this.txtServerInfo.TabIndex = 12;
            this.txtServerInfo.TabStop = false;
            this.txtServerInfo.Text = "";
            this.txtServerInfo.Visible = false;
            // 
            // txtInfo
            // 
            this.txtInfo.BackColor = System.Drawing.Color.Black;
            this.txtInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInfo.Font = new System.Drawing.Font("Verdana", 8F);
            this.txtInfo.ForeColor = System.Drawing.Color.Lime;
            this.txtInfo.Location = new System.Drawing.Point(284, 311);
            this.txtInfo.Margin = new System.Windows.Forms.Padding(0);
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.ReadOnly = true;
            this.txtInfo.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtInfo.Size = new System.Drawing.Size(433, 215);
            this.txtInfo.TabIndex = 11;
            this.txtInfo.TabStop = false;
            this.txtInfo.Text = "";
            this.txtInfo.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.txtInfo_LinkClicked);
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::QuickLogin.Properties.Resources.MainBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(756, 542);
            this.ControlBox = false;
            this.Controls.Add(this.txtServerInfo);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.pnlLogin);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.lbAccount);
            this.Controls.Add(this.lbWiki);
            this.Controls.Add(this.lbDDO);
            this.Controls.Add(this.lbBaidu);
            this.Controls.Add(this.lbBBS);
            this.Controls.Add(this.lbVersion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "快速登陆器";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownEvent);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMoveEvent);
            this.tcServicePanel.ResumeLayout(false);
            this.tpConn.ResumeLayout(false);
            this.tpLogin.ResumeLayout(false);
            this.tpLogin.PerformLayout();
            this.pnlLogin.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbVersion;
        private System.Windows.Forms.Label lbBBS;
        private System.Windows.Forms.Label lbBaidu;
        private System.Windows.Forms.Label lbDDO;
        private System.Windows.Forms.Label lbWiki;
        private System.Windows.Forms.Label lbAccount;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TabControl tcServicePanel;
        private System.Windows.Forms.TabPage tpConn;
        private System.Windows.Forms.TabPage tpUpdate;
        private System.Windows.Forms.TabPage tpLogin;
        private System.Windows.Forms.RichTextBox rtxtInfo;
        private System.Windows.Forms.ComboBox cblUsername;
        private System.Windows.Forms.ComboBox cblServerList;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private RichTextBoxEx txtInfo;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label lbPWD;
        private System.Windows.Forms.Label lbSev;
        private System.Windows.Forms.CheckBox cbxRemember;
        private System.Windows.Forms.Panel pnlLogin;
        private RichTextBoxEx txtServerInfo;


    }
}