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
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.tcServicePanel = new System.Windows.Forms.TabControl();
            this.tpConn = new System.Windows.Forms.TabPage();
            this.rtxtInfo = new System.Windows.Forms.RichTextBox();
            this.tpLogin = new System.Windows.Forms.TabPage();
            this.cb64Bit = new System.Windows.Forms.CheckBox();
            this.lbPublicGroup = new System.Windows.Forms.Label();
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
            this.其它ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.贴吧ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qQ群ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wikiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.首页ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.职业介绍ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.种族ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.天赋ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.专长ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.法术ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.天命ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.声望ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.任务ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.转生ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.官网ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.首页ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.账号ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.源码下载ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.在线解谜ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtServerInfo = new QuickLogin.RichTextBoxEx();
            this.txtInfo = new QuickLogin.RichTextBoxEx();
            this.pnlLogin.SuspendLayout();
            this.tcServicePanel.SuspendLayout();
            this.tpConn.SuspendLayout();
            this.tpLogin.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLogin
            // 
            this.pnlLogin.BackColor = System.Drawing.Color.Transparent;
            this.pnlLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLogin.Controls.Add(this.tcServicePanel);
            this.pnlLogin.Location = new System.Drawing.Point(407, 84);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(328, 216);
            this.pnlLogin.TabIndex = 10;
            // 
            // tcServicePanel
            // 
            this.tcServicePanel.Controls.Add(this.tpConn);
            this.tcServicePanel.Controls.Add(this.tpLogin);
            this.tcServicePanel.Location = new System.Drawing.Point(-6, 6);
            this.tcServicePanel.Margin = new System.Windows.Forms.Padding(0);
            this.tcServicePanel.Name = "tcServicePanel";
            this.tcServicePanel.SelectedIndex = 0;
            this.tcServicePanel.Size = new System.Drawing.Size(375, 217);
            this.tcServicePanel.TabIndex = 2;
            this.tcServicePanel.TabStop = false;
            // 
            // tpConn
            // 
            this.tpConn.BackColor = System.Drawing.Color.Black;
            this.tpConn.Controls.Add(this.rtxtInfo);
            this.tpConn.Location = new System.Drawing.Point(4, 22);
            this.tpConn.Margin = new System.Windows.Forms.Padding(0);
            this.tpConn.Name = "tpConn";
            this.tpConn.Size = new System.Drawing.Size(367, 191);
            this.tpConn.TabIndex = 0;
            this.tpConn.Text = "连接";
            // 
            // rtxtInfo
            // 
            this.rtxtInfo.BackColor = System.Drawing.Color.Black;
            this.rtxtInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxtInfo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtInfo.ForeColor = System.Drawing.Color.Lime;
            this.rtxtInfo.Location = new System.Drawing.Point(0, 0);
            this.rtxtInfo.Name = "rtxtInfo";
            this.rtxtInfo.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtxtInfo.Size = new System.Drawing.Size(367, 191);
            this.rtxtInfo.TabIndex = 10;
            this.rtxtInfo.TabStop = false;
            this.rtxtInfo.Text = "";
            // 
            // tpLogin
            // 
            this.tpLogin.BackColor = System.Drawing.Color.Black;
            this.tpLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tpLogin.Controls.Add(this.cb64Bit);
            this.tpLogin.Controls.Add(this.lbPublicGroup);
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
            this.tpLogin.Size = new System.Drawing.Size(367, 191);
            this.tpLogin.TabIndex = 2;
            this.tpLogin.Text = "登录";
            // 
            // cb64Bit
            // 
            this.cb64Bit.AutoCheck = false;
            this.cb64Bit.AutoSize = true;
            this.cb64Bit.BackColor = System.Drawing.Color.Transparent;
            this.cb64Bit.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cb64Bit.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.cb64Bit.ForeColor = System.Drawing.Color.White;
            this.cb64Bit.Location = new System.Drawing.Point(113, 151);
            this.cb64Bit.Name = "cb64Bit";
            this.cb64Bit.Size = new System.Drawing.Size(84, 16);
            this.cb64Bit.TabIndex = 20;
            this.cb64Bit.TabStop = false;
            this.cb64Bit.Text = "64位客户端";
            this.cb64Bit.UseVisualStyleBackColor = false;
            // 
            // lbPublicGroup
            // 
            this.lbPublicGroup.AutoSize = true;
            this.lbPublicGroup.BackColor = System.Drawing.Color.Transparent;
            this.lbPublicGroup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbPublicGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPublicGroup.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbPublicGroup.Location = new System.Drawing.Point(242, 16);
            this.lbPublicGroup.Name = "lbPublicGroup";
            this.lbPublicGroup.Size = new System.Drawing.Size(36, 17);
            this.lbPublicGroup.TabIndex = 19;
            this.lbPublicGroup.Text = "招募";
            this.lbPublicGroup.Click += new System.EventHandler(this.lbPublicGroup_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(28, 140);
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
            this.cbxShowPassWord.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.cbxShowPassWord.ForeColor = System.Drawing.Color.White;
            this.cbxShowPassWord.Location = new System.Drawing.Point(242, 103);
            this.cbxShowPassWord.Name = "cbxShowPassWord";
            this.cbxShowPassWord.Size = new System.Drawing.Size(78, 16);
            this.cbxShowPassWord.TabIndex = 15;
            this.cbxShowPassWord.TabStop = false;
            this.cbxShowPassWord.Text = "显示密码?";
            this.cbxShowPassWord.UseVisualStyleBackColor = false;
            this.cbxShowPassWord.CheckedChanged += new System.EventHandler(CbxShowPassWord_CheckedChanged);
            // 
            // cbxRemember
            // 
            this.cbxRemember.AutoSize = true;
            this.cbxRemember.BackColor = System.Drawing.Color.Transparent;
            this.cbxRemember.Checked = true;
            this.cbxRemember.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxRemember.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.cbxRemember.ForeColor = System.Drawing.Color.White;
            this.cbxRemember.Location = new System.Drawing.Point(242, 60);
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
            this.lbSev.Location = new System.Drawing.Point(16, 14);
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
            this.lbPWD.Location = new System.Drawing.Point(15, 101);
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
            this.lbID.Location = new System.Drawing.Point(16, 58);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(56, 18);
            this.lbID.TabIndex = 12;
            this.lbID.Text = "用户名";
            this.lbID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.LightGreen;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnLogin.Location = new System.Drawing.Point(204, 140);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(68, 37);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "登录";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // cblUsername
            // 
            this.cblUsername.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cblUsername.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.cblUsername.FormattingEnabled = true;
            this.cblUsername.Location = new System.Drawing.Point(84, 58);
            this.cblUsername.Name = "cblUsername";
            this.cblUsername.Size = new System.Drawing.Size(152, 20);
            this.cblUsername.TabIndex = 2;
            // 
            // cblServerList
            // 
            this.cblServerList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cblServerList.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cblServerList.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.cblServerList.FormattingEnabled = true;
            this.cblServerList.Location = new System.Drawing.Point(84, 14);
            this.cblServerList.Name = "cblServerList";
            this.cblServerList.Size = new System.Drawing.Size(152, 20);
            this.cblServerList.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPassword.Location = new System.Drawing.Point(84, 99);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(152, 21);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.WordWrap = false;
            // 
            // 其它ToolStripMenuItem
            // 
            this.其它ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.贴吧ToolStripMenuItem,
            this.qQ群ToolStripMenuItem});
            this.其它ToolStripMenuItem.Name = "其它ToolStripMenuItem";
            this.其它ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.其它ToolStripMenuItem.Text = "其它";
            // 
            // 贴吧ToolStripMenuItem
            // 
            this.贴吧ToolStripMenuItem.Name = "贴吧ToolStripMenuItem";
            this.贴吧ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.贴吧ToolStripMenuItem.Text = "百度贴吧";
            this.贴吧ToolStripMenuItem.Click += new System.EventHandler(this.贴吧ToolStripMenuItem_Click);
            // 
            // qQ群ToolStripMenuItem
            // 
            this.qQ群ToolStripMenuItem.Name = "qQ群ToolStripMenuItem";
            this.qQ群ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.qQ群ToolStripMenuItem.Text = "QQ群";
            this.qQ群ToolStripMenuItem.Click += new System.EventHandler(this.qQ群ToolStripMenuItem_Click);
            // 
            // wikiToolStripMenuItem
            // 
            this.wikiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.首页ToolStripMenuItem1,
            this.职业介绍ToolStripMenuItem,
            this.种族ToolStripMenuItem,
            this.天赋ToolStripMenuItem,
            this.专长ToolStripMenuItem,
            this.法术ToolStripMenuItem,
            this.天命ToolStripMenuItem,
            this.声望ToolStripMenuItem,
            this.任务ToolStripMenuItem,
            this.转生ToolStripMenuItem});
            this.wikiToolStripMenuItem.Name = "wikiToolStripMenuItem";
            this.wikiToolStripMenuItem.Size = new System.Drawing.Size(45, 21);
            this.wikiToolStripMenuItem.Text = "Wiki";
            // 
            // 首页ToolStripMenuItem1
            // 
            this.首页ToolStripMenuItem1.Name = "首页ToolStripMenuItem1";
            this.首页ToolStripMenuItem1.Size = new System.Drawing.Size(100, 22);
            this.首页ToolStripMenuItem1.Text = "首页";
            this.首页ToolStripMenuItem1.Click += new System.EventHandler(this.首页ToolStripMenuItem1_Click);
            // 
            // 职业介绍ToolStripMenuItem
            // 
            this.职业介绍ToolStripMenuItem.Name = "职业介绍ToolStripMenuItem";
            this.职业介绍ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.职业介绍ToolStripMenuItem.Text = "职业";
            this.职业介绍ToolStripMenuItem.Click += new System.EventHandler(this.职业介绍ToolStripMenuItem_Click);
            // 
            // 种族ToolStripMenuItem
            // 
            this.种族ToolStripMenuItem.Name = "种族ToolStripMenuItem";
            this.种族ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.种族ToolStripMenuItem.Text = "种族";
            this.种族ToolStripMenuItem.Click += new System.EventHandler(this.种族ToolStripMenuItem_Click);
            // 
            // 天赋ToolStripMenuItem
            // 
            this.天赋ToolStripMenuItem.Name = "天赋ToolStripMenuItem";
            this.天赋ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.天赋ToolStripMenuItem.Text = "天赋";
            this.天赋ToolStripMenuItem.Click += new System.EventHandler(this.天赋ToolStripMenuItem_Click);
            // 
            // 专长ToolStripMenuItem
            // 
            this.专长ToolStripMenuItem.Name = "专长ToolStripMenuItem";
            this.专长ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.专长ToolStripMenuItem.Text = "专长";
            this.专长ToolStripMenuItem.Click += new System.EventHandler(this.专长ToolStripMenuItem_Click);
            // 
            // 法术ToolStripMenuItem
            // 
            this.法术ToolStripMenuItem.Name = "法术ToolStripMenuItem";
            this.法术ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.法术ToolStripMenuItem.Text = "法术";
            this.法术ToolStripMenuItem.Click += new System.EventHandler(this.法术ToolStripMenuItem_Click);
            // 
            // 天命ToolStripMenuItem
            // 
            this.天命ToolStripMenuItem.Name = "天命ToolStripMenuItem";
            this.天命ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.天命ToolStripMenuItem.Text = "天命";
            this.天命ToolStripMenuItem.Click += new System.EventHandler(this.天命ToolStripMenuItem_Click);
            // 
            // 声望ToolStripMenuItem
            // 
            this.声望ToolStripMenuItem.Name = "声望ToolStripMenuItem";
            this.声望ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.声望ToolStripMenuItem.Text = "声望";
            this.声望ToolStripMenuItem.Click += new System.EventHandler(this.声望ToolStripMenuItem_Click);
            // 
            // 任务ToolStripMenuItem
            // 
            this.任务ToolStripMenuItem.Name = "任务ToolStripMenuItem";
            this.任务ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.任务ToolStripMenuItem.Text = "任务";
            this.任务ToolStripMenuItem.Click += new System.EventHandler(this.任务ToolStripMenuItem_Click);
            // 
            // 转生ToolStripMenuItem
            // 
            this.转生ToolStripMenuItem.Name = "转生ToolStripMenuItem";
            this.转生ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.转生ToolStripMenuItem.Text = "转生";
            this.转生ToolStripMenuItem.Click += new System.EventHandler(this.转生ToolStripMenuItem_Click);
            // 
            // 官网ToolStripMenuItem
            // 
            this.官网ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.首页ToolStripMenuItem,
            this.账号ToolStripMenuItem});
            this.官网ToolStripMenuItem.Name = "官网ToolStripMenuItem";
            this.官网ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.官网ToolStripMenuItem.Text = "官网";
            // 
            // 首页ToolStripMenuItem
            // 
            this.首页ToolStripMenuItem.Name = "首页ToolStripMenuItem";
            this.首页ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.首页ToolStripMenuItem.Text = "首页";
            this.首页ToolStripMenuItem.Click += new System.EventHandler(this.首页ToolStripMenuItem_Click);
            // 
            // 账号ToolStripMenuItem
            // 
            this.账号ToolStripMenuItem.Name = "账号ToolStripMenuItem";
            this.账号ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.账号ToolStripMenuItem.Text = "账号";
            this.账号ToolStripMenuItem.Click += new System.EventHandler(this.账号ToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.其它ToolStripMenuItem,
            this.源码下载ToolStripMenuItem,
            this.在线解谜ToolStripMenuItem,
            this.wikiToolStripMenuItem,
            this.官网ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 2, 6, 2);
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(780, 25);
            this.menuStrip1.Stretch = false;
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 源码下载ToolStripMenuItem
            // 
            this.源码下载ToolStripMenuItem.Name = "源码下载ToolStripMenuItem";
            this.源码下载ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.源码下载ToolStripMenuItem.Text = "源码下载";
            this.源码下载ToolStripMenuItem.Click += new System.EventHandler(this.源码下载ToolStripMenuItem_Click);
            // 
            // 在线解谜ToolStripMenuItem
            // 
            this.在线解谜ToolStripMenuItem.Name = "在线解谜ToolStripMenuItem";
            this.在线解谜ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.在线解谜ToolStripMenuItem.Text = "在线解谜";
            this.在线解谜ToolStripMenuItem.Click += new System.EventHandler(this.在线解谜ToolStripMenuItem_Click);
            // 
            // txtServerInfo
            // 
            this.txtServerInfo.BackColor = System.Drawing.Color.Black;
            this.txtServerInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtServerInfo.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtServerInfo.ForeColor = System.Drawing.Color.Lime;
            this.txtServerInfo.Location = new System.Drawing.Point(93, 104);
            this.txtServerInfo.Margin = new System.Windows.Forms.Padding(0);
            this.txtServerInfo.Name = "txtServerInfo";
            this.txtServerInfo.ReadOnly = true;
            this.txtServerInfo.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtServerInfo.Size = new System.Drawing.Size(241, 429);
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
            this.txtInfo.Location = new System.Drawing.Point(407, 318);
            this.txtInfo.Margin = new System.Windows.Forms.Padding(0);
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.ReadOnly = true;
            this.txtInfo.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtInfo.Size = new System.Drawing.Size(328, 215);
            this.txtInfo.TabIndex = 11;
            this.txtInfo.TabStop = false;
            this.txtInfo.Text = "";
            this.txtInfo.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.txtInfo_LinkClicked);
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::QuickLogin.Properties.Resources.Mainform_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(780, 542);
            this.Controls.Add(this.txtServerInfo);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.pnlLogin);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DDO快速登陆器 v2.5.6 Copyright 2011 Design by 夜风 QQ: 35792181";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownEvent);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMoveEvent);
            this.pnlLogin.ResumeLayout(false);
            this.tcServicePanel.ResumeLayout(false);
            this.tpConn.ResumeLayout(false);
            this.tpLogin.ResumeLayout(false);
            this.tpLogin.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private RichTextBoxEx txtInfo;
        private System.Windows.Forms.Panel pnlLogin;
        private RichTextBoxEx txtServerInfo;
        private TabControl tcServicePanel;
        private TabPage tpConn;
        private RichTextBox rtxtInfo;
        private TabPage tpLogin;
        private Label lbPublicGroup;
        private Button btnUpdate;
        private CheckBox cbxShowPassWord;
        private CheckBox cbxRemember;
        private Label lbSev;
        private Label lbPWD;
        private Label lbID;
        private Button btnLogin;
        private ComboBox cblUsername;
        private ComboBox cblServerList;
        private TextBox txtPassword;
        private CheckBox cb64Bit;
        private ToolStripMenuItem 其它ToolStripMenuItem;
        private ToolStripMenuItem 贴吧ToolStripMenuItem;
        private ToolStripMenuItem qQ群ToolStripMenuItem;
        private ToolStripMenuItem wikiToolStripMenuItem;
        private ToolStripMenuItem 首页ToolStripMenuItem1;
        private ToolStripMenuItem 职业介绍ToolStripMenuItem;
        private ToolStripMenuItem 种族ToolStripMenuItem;
        private ToolStripMenuItem 天赋ToolStripMenuItem;
        private ToolStripMenuItem 专长ToolStripMenuItem;
        private ToolStripMenuItem 法术ToolStripMenuItem;
        private ToolStripMenuItem 天命ToolStripMenuItem;
        private ToolStripMenuItem 声望ToolStripMenuItem;
        private ToolStripMenuItem 任务ToolStripMenuItem;
        private ToolStripMenuItem 转生ToolStripMenuItem;
        private ToolStripMenuItem 官网ToolStripMenuItem;
        private ToolStripMenuItem 首页ToolStripMenuItem;
        private ToolStripMenuItem 账号ToolStripMenuItem;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem 源码下载ToolStripMenuItem;
        private ToolStripMenuItem 在线解谜ToolStripMenuItem;
    }
}