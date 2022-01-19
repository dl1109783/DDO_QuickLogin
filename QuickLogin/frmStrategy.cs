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
            InitializeComponent();
            LoadSettings();
        }

        private void LoadSettings()
        {
            _dicPics = new List<object>();
            _dicPics.Add(Resources.prove_your_worth);
            _dicPics.Add(Resources.pit_1);
            _dicPics.Add(Resources.shadow_crypt_8_gears_fix);
            _dicPics.Add(Resources.Map_TombOfTheTormented_RatPaths);
            _dicPics.Add(Resources.sand);
            _dicPics.Add(Resources.von5);
            _dicPics.Add(Resources.An_invitation_to_dinner_map);
            _dicPics.Add(Resources.amber);
            _dicPics.Add(Resources.inferno);


            this.lbQuest.Items.AddRange(new object[] {
                "Prove Your Worth 三桶湾",
                "The Pit 矿坑",
                "The Shadow Crypt 幽影墓穴",
                "Tomb of the Tormented 不死3老鼠本",
                "Sand of Menechtarun 沙漠野外",
                "The Vault of Night 龙5",
                "An Invitation to Dinner 晚宴(U37C1)",
                "Sealed in Amber 翡翠神殿(U37C2)",
                "Inferno the Damned 不死4地狱",
            });
        }

        private void lbQuest_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbQuest.SelectedIndex < 0 || lbQuest.SelectedIndex > _dicPics.Count - 1)
            {
                return;
            }
            pbImage.Image = (Image)_dicPics[lbQuest.SelectedIndex];
            this.pbImage.Location = new System.Drawing.Point(0, 0);
            this.pbImage.Size = this.panel1.Size;
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
