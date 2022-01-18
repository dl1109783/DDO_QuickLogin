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

namespace QuickLogin
{
    public partial class frmStrategy : Form
    {
        private Point mouseDownPoint;
        private bool isMove;
        private int zoomStep = 50;

        private List<Object> _dicPics;
        public frmStrategy()
        {
            LoadSettings();
            InitializeComponent();
        }

        private void LoadSettings()
        {
            _dicPics = new List<object>();
            _dicPics.Add(Resources.Strategy_1);
            _dicPics.Add(Resources.Strategy_2);
            _dicPics.Add(Resources.Strategy_3);
        }

        private void lbQuest_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbQuest.SelectedIndex < 0 || lbQuest.SelectedIndex > _dicPics.Count - 1)
            {
                return;
            }
            pbImage.Image = (Image)_dicPics[lbQuest.SelectedIndex];
            this.pbImage.Location = new System.Drawing.Point(269, 12);
            this.pbImage.Size = new System.Drawing.Size(690, 541);
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
                if (pbImage.Width < pbImage.Image.Width / 10)
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

        //private void panel2_MouseDown(object sender, MouseEventArgs e)
        //{
        //    if (e.Button == MouseButtons.Left)
        //    {
        //        mouseDownPoint.X = Cursor.Position.X; //记录鼠标左键按下时位置
        //        mouseDownPoint.Y = Cursor.Position.Y;
        //        isMove = true;
        //    }
        //}

        //private void panel2_MouseUp(object sender, MouseEventArgs e)
        //{
        //    if (e.Button == MouseButtons.Left)
        //    {
        //        isMove = false;
        //    }
        //}

        //private void panel2_MouseMove(object sender, MouseEventArgs e)
        //{
        //    panel2.Focus(); //鼠标不在picturebox上时焦点给别的控件，此时无法缩放   
        //    if (isMove)
        //    {
        //        int x, y;   //新的pbImage.Location(x,y)
        //        int moveX, moveY; //X方向，Y方向移动大小。
        //        moveX = Cursor.Position.X - mouseDownPoint.X;
        //        moveY = Cursor.Position.Y - mouseDownPoint.Y;
        //        x = pbImage.Location.X + moveX;
        //        y = pbImage.Location.Y + moveY;
        //        pbImage.Location = new Point(x, y);
        //        mouseDownPoint.X = Cursor.Position.X;
        //        mouseDownPoint.Y = Cursor.Position.Y;
        //    }
        //}
    }
}
