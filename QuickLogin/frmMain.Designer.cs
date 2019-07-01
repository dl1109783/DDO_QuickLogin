using System.Drawing;
using System.Windows.Forms;

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
            this.lbUrl1 = new System.Windows.Forms.Label();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.tcServicePanel = new System.Windows.Forms.TabControl();
            this.tpConn = new System.Windows.Forms.TabPage();
            this.rtxtInfo = new System.Windows.Forms.RichTextBox();
            this.tpLogin = new System.Windows.Forms.TabPage();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cbxShowPassWord = new System.Windows.Forms.CheckBox();
            this.cbxRemember = new System.Windows.Forms.CheckBox();
            this.lbSev = new System.Windows.Forms.Label();
            this.lbPWD = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.cblUsername = new System.Windows.Forms.ComboBox();
            this.cblServerList = new System.Windows.Forms.ComboBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lbUrl2 = new System.Windows.Forms.Label();
            this.lbUrl3 = new System.Windows.Forms.Label();
            this.lbUrl4 = new System.Windows.Forms.Label();
            this.lbUrl5 = new System.Windows.Forms.Label();
            this.txtInfo = new QuickLogin.RichTextBoxEx();
            this.txtServerInfo = new QuickLogin.RichTextBoxEx();
            this.pnlLogin.SuspendLayout();
            this.tcServicePanel.SuspendLayout();
            this.tpConn.SuspendLayout();
            this.tpLogin.SuspendLayout();
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
            this.lbVersion.Size = new System.Drawing.Size(0, 19);
            this.lbVersion.TabIndex = 1;
            // 
            // lbUrl1
            // 
            this.lbUrl1.AutoSize = true;
            this.lbUrl1.BackColor = System.Drawing.Color.Transparent;
            this.lbUrl1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbUrl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbUrl1.ForeColor = System.Drawing.Color.White;
            this.lbUrl1.Location = new System.Drawing.Point(238, 22);
            this.lbUrl1.Name = "lbUrl1";
            this.lbUrl1.Size = new System.Drawing.Size(43, 20);
            this.lbUrl1.TabIndex = 2;
            this.lbUrl1.Text = "地址";
            this.lbUrl1.Click += new System.EventHandler(this.lbUrl_Click);
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
            // tcServicePanel
            // 
            this.tcServicePanel.Controls.Add(this.tpConn);
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
            // tpLogin
            // 
            this.tpLogin.BackColor = System.Drawing.Color.Black;
            this.tpLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tpLogin.Controls.Add(this.btnUpdate);
            this.tpLogin.Controls.Add(this.cbxShowPassWord);
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
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btnUpdate.Location = new System.Drawing.Point(31, 142);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(64, 37);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "更新";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // cbxShowPassWord
            // 
            this.cbxShowPassWord.AutoSize = true;
            this.cbxShowPassWord.BackColor = System.Drawing.Color.Transparent;
            this.cbxShowPassWord.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbxShowPassWord.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.cbxShowPassWord.ForeColor = System.Drawing.Color.White;
            this.cbxShowPassWord.Location = new System.Drawing.Point(181, 128);
            this.cbxShowPassWord.Name = "cbxShowPassWord";
            this.cbxShowPassWord.Size = new System.Drawing.Size(78, 16);
            this.cbxShowPassWord.TabIndex = 15;
            this.cbxShowPassWord.TabStop = false;
            this.cbxShowPassWord.Text = "显示密码?";
            this.cbxShowPassWord.UseVisualStyleBackColor = false;
            this.cbxShowPassWord.CheckedChanged += new System.EventHandler(this.CbxShowPassWord_CheckedChanged);
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
            this.btnLogin.Location = new System.Drawing.Point(107, 142);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(152, 37);
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
            // lbUrl2
            // 
            this.lbUrl2.AutoSize = true;
            this.lbUrl2.BackColor = System.Drawing.Color.Transparent;
            this.lbUrl2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbUrl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbUrl2.ForeColor = System.Drawing.Color.White;
            this.lbUrl2.Location = new System.Drawing.Point(327, 22);
            this.lbUrl2.Name = "lbUrl2";
            this.lbUrl2.Size = new System.Drawing.Size(43, 20);
            this.lbUrl2.TabIndex = 11;
            this.lbUrl2.Tag = "";
            this.lbUrl2.Text = "地址";
            this.lbUrl2.Click += new System.EventHandler(this.lbUrl_Click);
            // 
            // lbUrl3
            // 
            this.lbUrl3.AutoSize = true;
            this.lbUrl3.BackColor = System.Drawing.Color.Transparent;
            this.lbUrl3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbUrl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbUrl3.ForeColor = System.Drawing.Color.White;
            this.lbUrl3.Location = new System.Drawing.Point(416, 22);
            this.lbUrl3.Name = "lbUrl3";
            this.lbUrl3.Size = new System.Drawing.Size(43, 20);
            this.lbUrl3.TabIndex = 12;
            this.lbUrl3.Text = "地址";
            this.lbUrl3.Click += new System.EventHandler(this.lbUrl_Click);
            // 
            // lbUrl4
            // 
            this.lbUrl4.AutoSize = true;
            this.lbUrl4.BackColor = System.Drawing.Color.Transparent;
            this.lbUrl4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbUrl4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbUrl4.ForeColor = System.Drawing.Color.White;
            this.lbUrl4.Location = new System.Drawing.Point(505, 22);
            this.lbUrl4.Name = "lbUrl4";
            this.lbUrl4.Size = new System.Drawing.Size(43, 20);
            this.lbUrl4.TabIndex = 13;
            this.lbUrl4.Text = "地址";
            this.lbUrl4.Click += new System.EventHandler(this.lbUrl_Click);
            // 
            // lbUrl5
            // 
            this.lbUrl5.AutoSize = true;
            this.lbUrl5.BackColor = System.Drawing.Color.Transparent;
            this.lbUrl5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbUrl5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbUrl5.ForeColor = System.Drawing.Color.White;
            this.lbUrl5.Location = new System.Drawing.Point(594, 22);
            this.lbUrl5.Name = "lbUrl5";
            this.lbUrl5.Size = new System.Drawing.Size(43, 20);
            this.lbUrl5.TabIndex = 14;
            this.lbUrl5.Text = "地址";
            this.lbUrl5.Click += new System.EventHandler(this.lbUrl_Click);
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
            this.Controls.Add(this.lbUrl5);
            this.Controls.Add(this.lbUrl4);
            this.Controls.Add(this.lbUrl3);
            this.Controls.Add(this.lbUrl2);
            this.Controls.Add(this.pnlLogin);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.lbUrl1);
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
            this.pnlLogin.ResumeLayout(false);
            this.tcServicePanel.ResumeLayout(false);
            this.tpConn.ResumeLayout(false);
            this.tpLogin.ResumeLayout(false);
            this.tpLogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbVersion;
        private System.Windows.Forms.Label lbUrl1;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnClose;
        private RichTextBoxEx txtInfo;
        private System.Windows.Forms.Panel pnlLogin;
        private RichTextBoxEx txtServerInfo;
        private System.Windows.Forms.TabControl tcServicePanel;
        private System.Windows.Forms.TabPage tpConn;
        private System.Windows.Forms.RichTextBox rtxtInfo;
        private System.Windows.Forms.TabPage tpLogin;
        private System.Windows.Forms.CheckBox cbxRemember;
        private System.Windows.Forms.Label lbSev;
        private System.Windows.Forms.Label lbPWD;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.ComboBox cblUsername;
        private System.Windows.Forms.ComboBox cblServerList;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lbUrl2;
        private System.Windows.Forms.Label lbUrl3;
        private System.Windows.Forms.Label lbUrl4;
        private System.Windows.Forms.Label lbUrl5;
        private System.Windows.Forms.CheckBox cbxShowPassWord;
        private System.Windows.Forms.Button btnUpdate;
    }
}