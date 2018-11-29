namespace QuickLogin
{
    partial class CheckUser
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
            this.btnCheck = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbCheckList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(122, 195);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 23);
            this.btnCheck.TabIndex = 0;
            this.btnCheck.Text = "选择";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "土鳖把账号名加密了,暂时没找到解密方法,凑合用吧";
            // 
            // lbCheckList
            // 
            this.lbCheckList.FormattingEnabled = true;
            this.lbCheckList.ItemHeight = 12;
            this.lbCheckList.Location = new System.Drawing.Point(24, 24);
            this.lbCheckList.Name = "lbCheckList";
            this.lbCheckList.Size = new System.Drawing.Size(279, 160);
            this.lbCheckList.TabIndex = 2;
            // 
            // CheckUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 247);
            this.Controls.Add(this.lbCheckList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCheck);
            this.Name = "CheckUser";
            this.Text = "CheckUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbCheckList;
    }
}