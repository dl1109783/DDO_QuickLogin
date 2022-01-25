using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using QuickLogin.Properties;
using QuickLogin.Util;

namespace QuickLogin
{
    public partial class frmStrategy : Form
    {
        private Point mouseDownPoint;
        private bool isMove;
        private int zoomStep = 50;

        private List<Dictionary<string, string>> _dicContents;
        public frmStrategy()
        {
            InitializeComponent();
            LoadSettings();
        }

        private void LoadSettings()
        {
            _dicContents = new List<Dictionary<string, string>>();
            CsvUtil.ReadResourceCSV(_dicContents, Resources.strategy);

            foreach(Dictionary<string,string> _dic in _dicContents)
            {
                this.lbQuest.Items.Add(_dic["name"] + " " + _dic["desc"]);
            }
        }

        private void lbQuest_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbQuest.SelectedIndex < 0 || lbQuest.SelectedIndex > _dicContents.Count - 1)
            {
                return;
            }
            //pbImage.Image = (Image)_dicPics[lbQuest.SelectedIndex];
            pbImage.Image = Util.ResourceUtil.GetImage(_dicContents[lbQuest.SelectedIndex]["filename"]);
            this.pbImage.Location = new System.Drawing.Point(0, 0);
            this.pbImage.Size = this.panel1.Size;

            string strategy = _dicContents[lbQuest.SelectedIndex]["info"];
            if (string.IsNullOrEmpty(strategy))
            {
                strategy = "暂无备注";
            }
            rtInfo.Text = strategy.Replace('-','\n');
        }

        private void pbImage_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseDownPoint.X = Cursor.Position.X; //记录鼠标左键按下时位置
                mouseDownPoint.Y = Cursor.Position.Y;
                isMove = true;
                pbImage.Focus(); //鼠标滚轮事件(缩放时)需要picturebox有焦点
            }
        }

        private void pbImage_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMove = false;
            }
        }

        private void pbImage_MouseMove(object sender, MouseEventArgs e)
        {
            pbImage.Focus(); //鼠标在picturebox上时才有焦点，此时可以缩放
            if (isMove)
            {
                int x, y;   //新的pbImage.Location(x,y)
                int moveX, moveY; //X方向，Y方向移动大小。
                moveX = Cursor.Position.X - mouseDownPoint.X;
                moveY = Cursor.Position.Y - mouseDownPoint.Y;
                x = pbImage.Location.X + moveX;
                y = pbImage.Location.Y + moveY;
                pbImage.Location = new Point(x, y);
                mouseDownPoint.X = Cursor.Position.X;
                mouseDownPoint.Y = Cursor.Position.Y;
            }
        }

        private void pbImage_MouseWheel(object sender, MouseEventArgs e)
        {
            if (pbImage.Image == null)
            {
                return;
            }
            int x = e.Location.X;
            int y = e.Location.Y;
            int ow = pbImage.Width;
            int oh = pbImage.Height;
            int VX, VY;  //因缩放产生的位移矢量
            if (e.Delta > 0) //放大
            {
                //第①步
                pbImage.Width += zoomStep;
                pbImage.Height += zoomStep;
                //第②步
                PropertyInfo pInfo = pbImage.GetType().GetProperty("ImageRectangle", BindingFlags.Instance |
                 BindingFlags.NonPublic);
                Rectangle rect = (Rectangle)pInfo.GetValue(pbImage, null);
                //第③步
                pbImage.Width = rect.Width;
                pbImage.Height = rect.Height;
            }
            if (e.Delta < 0) //缩小
            {
                //防止一直缩成负值
                //if (pbImage.Width < pbImage.Image.Width / 10)
                //    return;
                if (pbImage.Width < 10)
                    return;

                pbImage.Width -= zoomStep;
                pbImage.Height -= zoomStep;
                PropertyInfo pInfo = pbImage.GetType().GetProperty("ImageRectangle", BindingFlags.Instance |
                 BindingFlags.NonPublic);
                Rectangle rect = (Rectangle)pInfo.GetValue(pbImage, null);
                pbImage.Width = rect.Width;
                pbImage.Height = rect.Height;
            }
            //第④步，求因缩放产生的位移，进行补偿，实现锚点缩放的效果
            VX = (int)((double)x * (ow - pbImage.Width) / ow);
            VY = (int)((double)y * (oh - pbImage.Height) / oh);
            pbImage.Location = new Point(pbImage.Location.X + VX, pbImage.Location.Y + VY);
        }
    }
}
