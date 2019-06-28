using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using System.Xml.Linq;
using QuickLogin.Connect;

namespace QuickLogin
{
    public partial class frmMain : Form
    {

        /// <summary>
        /// ��¼��Ϣ
        /// </summary>
        /// <param name="p_Type"></param>
        /// <param name="p_Value"></param>
        private void DelegateCallBack(ConnectType p_Type, object p_Value)
        {
            try
            {
                switch (p_Type)
                {
                    //����
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
                            //����
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
                    //�����������
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
                    //��½�û�
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
                    //����
                    case ConnectType.Error:
                        #region
                        Exception ex = (Exception)p_Value;
                        if (ex.Message == "No Subscriber Formal Entity was found.")
                        {
                            //
                            MessageBox.Show("�û������������!");
                        }
                        //else if (ex.Message.IndexOf("content.turbine.com") > 0)
                        //{
                        //    //������������ʱ����.
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
        /// <summary>
        /// ��¼��ť
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (!File.Exists("dndclient.exe"))
                {
                    MessageBox.Show("�뽫���������DDO��ϷĿ¼!");
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
                else { MessageBox.Show("�����û���,����,�Լ��������Ƿ�ѡ����ȷ!"); }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
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
                    BindLableText(lbUrl1, Program.Url1);
                    BindLableText(lbUrl2, Program.Url2);
                    BindLableText(lbUrl3, Program.Url3);
                    BindLableText(lbUrl4, Program.Url4);
                    BindLableText(lbUrl5, Program.Url5);

                    //��÷�����״̬
                    Thread td = new Thread(connThread.GetDataCenter);
                    td.IsBackground = true;//��̨�߳�,����ر��Զ��˳�
                    td.Start();
                    //�������
                    Thread td2 = new Thread(connThread.GetNews);
                    td2.IsBackground = true;//��̨�߳�,����ر��Զ��˳�
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
        /// ������ѡ��ı�
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

        #region ��������
        /// <summary>
        /// ���ùٷ��ͻ��˸�����Ϸ
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
                else MessageBox.Show("�Ҳ���DNDLauncher.exe�ļ�!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        /// <summary>
        /// ��ʾ����
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
        private void lbUrl_Click(object sender, EventArgs e)
        {
            OpenUrl(((Label)sender).Tag.ToString());
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //�����϶�
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
        /// �����е����ӵ��
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
        /// ����Ĭ�������������
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
        /// <summary>
        /// �󶨱�ǩ���Ӻ�����
        /// </summary>
        /// <param name="label"></param>
        /// <param name="str"></param>
        private void BindLableText(Label label, string str)
        {
            if (!string.IsNullOrEmpty(str) && str.Contains("|"))
            {
                var aryInfo = str.Split('|');
                if (aryInfo.Length > 1)
                {
                    label.Text = aryInfo[0];
                    label.Tag = aryInfo[1];
                    return;
                }
            }
            label.Text = string.Empty;
            label.Tag = string.Empty;
        }

        bool CheckXmlFile()
        {
            if (!File.Exists(Program.XML_FILE_PATH))
            {
                CreadNewXml();
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
                        DialogResult dr = MessageBox.Show("�������ļ������޷����뱣����˻����ݣ��Ƿ��ؽ������ļ���", "�����ˣ�", messButton);
                        if (dr == DialogResult.Cancel)
                        {
                            this.Close();
                            return false;
                        }
                        else
                        {
                            File.Delete(Program.XML_FILE_PATH);
                            CreadNewXml();
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
        void CreadNewXml()
        {
            XDocument xd = new XDocument(
                  new XElement("Users", new XAttribute("DefaultUser", "Default"),
                  new XElement("User", new XAttribute("Username", "Administrator"), new XAttribute("World", "Sarlona"), new XAttribute("Password", ""))));
            xd.Save(Program.XML_FILE_PATH);
        }
        #endregion


    }
}