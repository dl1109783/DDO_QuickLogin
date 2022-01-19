using QuickLogin.Connect;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using System.Xml.Linq;

namespace QuickLogin
{
    public partial class frmMain : Form
    {

        /// <summary>
        /// 登录信息
        /// </summary>
        /// <param name="p_Type"></param>
        /// <param name="p_Value"></param>
        private void DelegateCallBack(ConnectType p_Type, object p_Value)
        {
            try
            {
                switch (p_Type)
                {
                    //新闻
                    case ConnectType.GetNewsSuccess:
                        #region
                        Font fTitle = new Font("Verdana", 9, FontStyle.Bold);
                        Font fDes = new Font("Verdana", 8);
                        foreach (var news in (List<News>)p_Value)
                        {
                            #region Title
                            txtInfo.SelectionColor = news.Color;
                            txtInfo.SelectionFont = fTitle;
                            txtInfo.AppendText(news.Title + "\n");
                            #endregion 
                            //描述
                            txtInfo.AppendText("  " + news.Description + "\n");
                            #region Link
                            txtInfo.AppendText("  ");
                            txtInfo.InsertLink("More", news.Link);
                            txtInfo.SelectionColor = Color.Green;
                            txtInfo.AppendText(news.Pubdate + "\n\n");
                            #endregion
                        }
                        #endregion
                        break;
                    //获得数据中心
                    case ConnectType.GetDataCenterSuccess:
                        #region
                        var _worlds = (List<World>)p_Value;
                        if (_worlds != null)
                        {
                            cblServerList.DisplayMember = "Name";
                            cblServerList.Items.Clear();
                            foreach (World world in _worlds)
                            {
                                cblServerList.Items.Add(world);
                                if (userLists.DefaultUser != null && world.Name == userLists.DefaultUser.WorldName)
                                {
                                    cblServerList.SelectedItem = world;

                                }
                                else if (userLists.DefaultUser == null && world.Name == "Sarlona")
                                {
                                    cblServerList.SelectedItem = world;
                                }
                            }
                            connThread._worldSelect = (World)cblServerList.SelectedItem;
                        }
                        tcServicePanel.SelectedTab = tpLogin;
                        #endregion
                        break;
                    case ConnectType.Message:
                        #region
                        rtxtInfo.Text = p_Value.ToString() + "\n" + rtxtInfo.Text;
                        #endregion
                        break;
                    //登陆用户
                    case ConnectType.LoginSuccess:
                        #region
                        txtServerInfo.Visible = true;
                        txtServerInfo.Text = p_Value.ToString();
                        btnLogin.Enabled = true;
                        #endregion
                        break;
                    case ConnectType.LoginFaild:
                        #region
                        MessageBox.Show(p_Value.ToString());
                        btnLogin.Enabled = true;
                        #endregion
                        break;
                    //报错
                    case ConnectType.Error:
                        #region
                        Exception ex = (Exception)p_Value;
                        if (ex.Message == "No Subscriber Formal Entity was found.")
                        {
                            //
                            MessageBox.Show("用户名或密码错误!");
                        }
                        //else if (ex.Message.IndexOf("content.turbine.com") > 0)
                        //{
                        //    //连接数据中心时报错.
                        //}
                        else
                        {
                            MessageBox.Show(ex.Message);
                        }
                        btnLogin.Enabled = true;
                        #endregion
                        break;
                    //case ConnectType.GetNewsFaild:
                    //    #region
                    //    #endregion
                    //    break;

                    default:
                        break;
                }
            }
            catch (Exception exx)
            {
                MessageBox.Show(exx.Message);
            }
        }


        ConnectThread connThread;
        UserList userLists;
        public frmMain()
        {
            InitializeComponent();
            tcServicePanel.Location = new Point(-6, -25);
            tcServicePanel.Appearance = TabAppearance.FlatButtons;
            connThread = new ConnectThread(new CallBackHandler(ConnectThread_OnCallBack));
        }

        private void Main_Load(object sender, EventArgs e)
        {
            try
            {
                if (CheckXmlFile())
                {
                    //BindLableText(lbUrl1, Program.Url1);
                    //BindLableText(lbUrl2, Program.Url2);
                    //BindLableText(lbUrl3, Program.Url3);
                    //BindLableText(lbUrl4, Program.Url4);
                    //BindLableText(lbUrl5, Program.Url5);
                    //BindLableText(lbUrl6, Program.Url6);
                    //BindLableText(lbUrl7, Program.Url7);
                    //获得服务器状态
                    Thread td = new Thread(connThread.GetDataCenter);
                    td.IsBackground = true;//后台线程,程序关闭自动退出
                    td.Start();
                    //获得新闻
                    Thread td2 = new Thread(connThread.GetNews);
                    td2.IsBackground = true;//后台线程,程序关闭自动退出
                    td2.Start();
                    userLists = new UserList();
                    if (userLists.AllUser != null && userLists.AllUser.Count > 0)
                    {
                        cblUsername.Items.Clear();
                        foreach (User user in userLists.AllUser)
                        {
                            cblUsername.Items.Add(user);
                        }
                        if (userLists.DefaultUser != null)
                        {
                            cblUsername.SelectedItem = userLists.DefaultUser;
                            txtPassword.Text = userLists.DefaultUser.PassWord;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        /// <summary>
        /// 下拉框选项改变
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cblUsername_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtPassword.Text = string.Empty;
                foreach (User user in cblUsername.Items)
                {
                    if (user.UserName == cblUsername.Text)
                    {
                        txtPassword.Text = user.PassWord;
                        foreach (World world in cblServerList.Items)
                        {
                            if (world.Name == user.WorldName)
                            {
                                cblServerList.SelectedItem = world;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        #region 基本方法
        /// <summary>
        /// 调用官方客户端更新游戏
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists("DNDLauncher.exe"))
                {
                    Process.Start(new ProcessStartInfo("DNDLauncher.exe", " -invoker -nosplash -skiprawdownload "));
                }
                else MessageBox.Show("找不到DNDLauncher.exe文件!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        /// <summary>
        /// 显示密码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbxShowPassWord_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !cbxShowPassWord.Checked;
        }
        protected void ConnectThread_OnCallBack(ConnectType p_Type, object p_str)
        {
            try
            {
                if (!connThread.isClosed)
                {
                    this.Invoke(new CallBackInvokeDelegate(DelegateCallBack), new Object[] { p_Type, p_str });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            connThread.isClosed = true;
        }
        //private void lbUrl_Click(object sender, EventArgs e)
        //{
        //    OpenUrl(((Label)sender).Tag.ToString());
        //}
        //private void btnClose_Click(object sender, EventArgs e)
        //{
        //    Application.Exit();
        //}
        //private void btnMin_Click(object sender, EventArgs e)
        //{
        //    this.WindowState = FormWindowState.Minimized;
        //}
        //界面拖动
        private Point mousePoint;
        private Point formPoint;
        public void MouseDownEvent(object sender, MouseEventArgs e)
        {
            mousePoint = Control.MousePosition;
            formPoint = this.Location;
        }
        public void MouseMoveEvent(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePos = Control.MousePosition;
                this.Location = new Point(mousePos.X - mousePoint.X + formPoint.X, mousePos.Y - mousePoint.Y + formPoint.Y);
            }
        }
        /// <summary>
        /// 新闻中的链接点击
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtInfo_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            if (e.LinkText.IndexOf('#') > 0 && e.LinkText.Split('#').Length > 1)
            {
                OpenUrl(e.LinkText.Split('#')[1]);
            }
        }
        /// <summary>
        /// 调用默认浏览器打开链接
        /// </summary>
        /// <param name="p_strUrl"></param>
        private void OpenUrl(string p_strUrl)
        {
            try
            {
                if (string.IsNullOrEmpty(p_strUrl)) return;
                Process.Start(p_strUrl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        ///// <summary>
        ///// 绑定标签链接和名字
        ///// </summary>
        ///// <param name="label"></param>
        ///// <param name="str"></param>
        //private void BindLableText(Label label, string str)
        //{
        //    if (!string.IsNullOrEmpty(str) && str.Contains("|"))
        //    {
        //        var aryInfo = str.Split('|');
        //        if (aryInfo.Length > 1)
        //        {
        //            label.Text = aryInfo[0];
        //            label.Tag = aryInfo[1];
        //            return;
        //        }
        //    }
        //    label.Text = string.Empty;
        //    label.Tag = string.Empty;
        //}

        bool CheckXmlFile()
        {
            if (!File.Exists(Program.XML_FILE_PATH))
            {
                CreateNewXml();
                return true;
            }
            else
            {
                try
                {
                    XDocument xd = XDocument.Load(Program.XML_FILE_PATH);
                }
                catch
                {
                    try
                    {
                        MessageBoxButtons messButton = MessageBoxButtons.OKCancel;
                        DialogResult dr = MessageBox.Show("打开配置文件出错，无法导入保存的账户数据，是否重建配置文件。", "出错了！", messButton);
                        if (dr == DialogResult.Cancel)
                        {
                            this.Close();
                            return false;
                        }
                        else
                        {
                            File.Delete(Program.XML_FILE_PATH);
                            CreateNewXml();
                            return true;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                return true;
            }

        }
        void CreateNewXml()
        {
            XDocument xd = new XDocument(
                  new XElement("Users", new XAttribute("DefaultUser", "Default"),
                  new XElement("User", new XAttribute("Username", "Administrator"), new XAttribute("World", "Sarlona"), new XAttribute("Password", ""))));
            xd.Save(Program.XML_FILE_PATH);
        }

        #endregion

        /// <summary>
        /// 登录按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (cb64Bit.Checked)
            {
                connThread.clientType = ClientType.X64;
            }
            else
            {
                connThread.clientType = ClientType.X86;
            }
            Login();
        }
        private void Login()
        {
            try
            {
                if (!File.Exists("dndclient.exe"))
                {
                    MessageBox.Show("请将本程序放在DDO游戏目录!");
                    return;
                }
                connThread._strUserName = cblUsername.Text.Trim();
                connThread._strPassWord = txtPassword.Text.Trim();
                connThread._worldSelect = (World)cblServerList.SelectedItem;
                if (connThread._strPassWord.Trim() != string.Empty && connThread._strUserName.Trim() != string.Empty && connThread._worldSelect != null)
                {
                    btnLogin.Enabled = false;
                    new Thread(new ThreadStart(this.connThread.LoginUser)) { IsBackground = true }.Start();
                }
                else { MessageBox.Show("请检查用户名,密码,以及服务器是否选择正确!"); }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cblServerList_SelectedIndexChanged(object sender, EventArgs e)
        {
            userLists.DefaultUser.WorldName = ((World)cblServerList.SelectedItem).Name;
        }

        private void lbPublicGroup_Click(object sender, EventArgs e)
        {
            if (cblServerList.SelectedItem != null)
            {
                OpenUrl("https://www.playeraudit.com/grouping?s=" + ((World)cblServerList.SelectedItem).Name.ToLower());
            }
            else
            {
                OpenUrl("https://www.playeraudit.com/");
            }
        }

        private void 首页ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenUrl("http://www.ddo.com/");
        }

        private void 账号ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenUrl("http://myaccount.turbine.com/");
        }

        private void 首页ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenUrl("http://ddowiki.com/");
        }

        private void 职业介绍ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenUrl("https://ddowiki.com/page/Classes");
        }

        private void 种族ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenUrl("https://ddowiki.com/page/Races");
        }

        private void 天赋ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenUrl("https://ddowiki.com/page/Enhancements");
        }

        private void 专长ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenUrl("https://ddowiki.com/page/Feats");
        }

        private void 法术ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenUrl("https://ddowiki.com/page/Spells");
        }

        private void 天命ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenUrl("https://ddowiki.com/page/Epic_Destinies");
        }

        private void 声望ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenUrl("https://ddowiki.com/page/Favor");
        }

        private void 任务ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenUrl("https://ddowiki.com/page/Quests");
        }

        private void 转生ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenUrl("https://ddowiki.com/page/Reincarnation");
        }

        private void 贴吧ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenUrl("https://tieba.baidu.com/f?kw=%E9%BE%99%E4%B8%8E%E5%9C%B0%E4%B8%8B%E5%9F%8E&ie=utf-8");
        }

        private void qQ群ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenUrl("https://shang.qq.com/wpa/qunwpa?idkey=1ac28296d2b07056b37b6ccea5b567e5f3ab64a5efd5b842d0df5e718a7e4590");
        }

        private void 源码下载ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void 在线解谜ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenUrl("http://solver.cubicleninja.com/");
        }

        private void dLCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenUrl("https://store-new.standingstonegames.com/ddo/expansions");
        }

        private void 注册账号ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenUrl("https://signup.ddo.com/ddo.php");
        }

        private void 副本图片攻略ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStrategy fs = new frmStrategy();
            fs.ShowDialog(this);
        }

        private void 原版ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenUrl("https://gitee.com/dlanny/DDO_QuickLogin");
        }

        private void 修改版ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenUrl("https://gitee.com/vivx97/DDO_QuickLogin");
        }
    }
}