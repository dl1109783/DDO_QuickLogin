using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using QuickLogin.Connect;
using QuickLogin.DataCenterServer;

namespace QuickLogin
{
    public partial class frmMain : Form
    {
        #region 基本
        private void OpenUrl(string p_strUrl)
        {
            try
            {
                Process.Start(p_strUrl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void lbBBS_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(new ProcessStartInfo("DNDlauncher.exe", " -invoker -nosplash -skiprawdownload "));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        private void lbBaidu_Click(object sender, EventArgs e)
        {
            OpenUrl(global::QuickLogin.Properties.Resources.strUrl2);
        }
        private void lbWiki_Click(object sender, EventArgs e)
        {
            OpenUrl(global::QuickLogin.Properties.Resources.strUrl3);
        }
        private void lbDDO_Click(object sender, EventArgs e)
        {
            OpenUrl(global::QuickLogin.Properties.Resources.strUrl4);
        }
        private void lbAccount_Click(object sender, EventArgs e)
        {
            OpenUrl(global::QuickLogin.Properties.Resources.strUrl5);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        protected void ConnectThread_OnCallBack(ConnectType p_Type, object p_str)
        {
            if (!connThread.isClosed)
            {
                this.Invoke(new CallBackInvokeDelegate(DelegateCallBack), new Object[] { p_Type, p_str });
            }
        }
        private void txtInfo_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            if (e.LinkText.IndexOf('#') > 0)
            {
                OpenUrl(e.LinkText.Split('#')[1]);
            }
        }
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
        #endregion

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
            userLists = new UserList();
            Thread td = new Thread(connThread.GetDataCenter);
            td.IsBackground = true;//后台线程,程序关闭自动退出
            td.Start();
            Thread td2 = new Thread(connThread.GetNews);
            td2.IsBackground = true;//后台线程,程序关闭自动退出
            td2.Start();

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
                        Regex rgEx = new Regex("<[^>]*>", RegexOptions.IgnoreCase);
                        foreach (Items item in (List<Items>)p_Value)
                        {
                            #region Title
                            string strTitle = item.Title.Replace("&amp; ", "&");
                            if (strTitle.IndexOf('%') > 0 || strTitle.IndexOf("Bonus ") > 0 || strTitle.IndexOf("Down") > 0)
                            {
                                txtInfo.SelectionColor = Color.Red;
                            }
                            else
                            {
                                txtInfo.SelectionColor = Color.Yellow;
                            }
                            txtInfo.SelectionFont = fTitle;
                            txtInfo.AppendText(strTitle + "\n");
                            #endregion
                            #region Des
                            string strDes = rgEx.Replace(item.Description, "").Trim();
                            strDes = strDes.Replace("&amp; ", "&");
                            strDes = strDes.Replace("  ", " ");
                            strDes = strDes.Replace("\n", " ");
                            strDes = strDes.Replace("\t", " ");
                            txtInfo.AppendText("  " + strDes + "\n");
                            #endregion
                            #region Link
                            txtInfo.AppendText("  ");
                            txtInfo.InsertLink("More", item.Link);
                            string strTemp = " " + item.PubDate.Replace("+0000", "").Trim();
                            if (!string.IsNullOrEmpty(item.Creator))
                            {
                                strTemp += " By " + item.Creator;
                            }
                            strTemp += "\n\r";
                            txtInfo.SelectionColor = Color.Green;
                            txtInfo.AppendText(strTemp);
                            #endregion
                        }
                        #endregion
                        break;
                    //获得数据中心
                    case ConnectType.GetDataCenterSuccess:
                        #region
                        World[] _worlds = (World[])p_Value;
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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            connThread._strUserName = cblUsername.Text.Trim();
            connThread._strPassWord = txtPassword.Text.Trim();
            connThread._worldSelect = (World)cblServerList.SelectedItem;
            if (connThread._strPassWord.Trim() != string.Empty && connThread._strUserName.Trim() != string.Empty && connThread._worldSelect != null)
            {
                btnLogin.Enabled = false;
                Thread td = new Thread(connThread.LoginUser);
                td.IsBackground = true;//后台线程,程序关闭自动退出
                td.Start();
            }
            else { MessageBox.Show("请检查用户名,密码,以及服务器是否选择正确!"); }
            //dh.LoginAccount(lUser);
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            connThread.isClosed = true;
        }

        private void cblUsername_TextChanged(object sender, EventArgs e)
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
    }
}