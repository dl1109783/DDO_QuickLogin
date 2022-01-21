
namespace QuickLogin
{
    partial class frmStrategy
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStrategy));
            this.lbQuest = new System.Windows.Forms.ListBox();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rtInfo = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbQuest
            // 
            this.lbQuest.FormattingEnabled = true;
            this.lbQuest.ItemHeight = 12;
            this.lbQuest.Location = new System.Drawing.Point(9, 9);
            this.lbQuest.Name = "lbQuest";
            this.lbQuest.Size = new System.Drawing.Size(250, 328);
            this.lbQuest.TabIndex = 1;
            this.lbQuest.SelectedIndexChanged += new System.EventHandler(this.lbQuest_SelectedIndexChanged);
            // 
            // pbImage
            // 
            this.pbImage.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.pbImage.Location = new System.Drawing.Point(1, 1);
            this.pbImage.Margin = new System.Windows.Forms.Padding(0);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(690, 541);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImage.TabIndex = 2;
            this.pbImage.TabStop = false;
            this.pbImage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbImage_MouseDown);
            this.pbImage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbImage_MouseMove);
            this.pbImage.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbImage_MouseUp);
            this.pbImage.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.pbImage_MouseWheel);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pbImage);
            this.panel1.Location = new System.Drawing.Point(268, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(693, 544);
            this.panel1.TabIndex = 2;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbImage_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbImage_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbImage_MouseUp);
            this.panel1.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.pbImage_MouseWheel);
            // 
            // rtInfo
            // 
            this.rtInfo.Location = new System.Drawing.Point(9, 344);
            this.rtInfo.Name = "rtInfo";
            this.rtInfo.Size = new System.Drawing.Size(250, 205);
            this.rtInfo.TabIndex = 3;
            this.rtInfo.Text = "";
            // 
            // frmStrategy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 561);
            this.Controls.Add(this.rtInfo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbQuest);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmStrategy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "副本图片攻略";
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox lbQuest;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox rtInfo;
    }
}