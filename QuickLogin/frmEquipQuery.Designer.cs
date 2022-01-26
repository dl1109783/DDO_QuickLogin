
namespace QuickLogin
{
    partial class frmEquipQuery
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEquipQuery));
            this.txtLevelFrom = new System.Windows.Forms.TextBox();
            this.txtLevelTo = new System.Windows.Forms.TextBox();
            this.chkIsMinorArtifact = new System.Windows.Forms.CheckBox();
            this.cbSetBonus = new System.Windows.Forms.ComboBox();
            this.cbBaseProp = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 15);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(53, 12);
            label1.TabIndex = 5;
            label1.Text = "装备等级";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(115, 17);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(11, 12);
            label2.TabIndex = 7;
            label2.Text = "-";
            // 
            // txtLevelFrom
            // 
            this.txtLevelFrom.Location = new System.Drawing.Point(71, 12);
            this.txtLevelFrom.Name = "txtLevelFrom";
            this.txtLevelFrom.Size = new System.Drawing.Size(40, 21);
            this.txtLevelFrom.TabIndex = 0;
            // 
            // txtLevelTo
            // 
            this.txtLevelTo.Location = new System.Drawing.Point(127, 12);
            this.txtLevelTo.Name = "txtLevelTo";
            this.txtLevelTo.Size = new System.Drawing.Size(41, 21);
            this.txtLevelTo.TabIndex = 1;
            // 
            // chkIsMinorArtifact
            // 
            this.chkIsMinorArtifact.AutoSize = true;
            this.chkIsMinorArtifact.Location = new System.Drawing.Point(498, 14);
            this.chkIsMinorArtifact.Name = "chkIsMinorArtifact";
            this.chkIsMinorArtifact.Size = new System.Drawing.Size(48, 16);
            this.chkIsMinorArtifact.TabIndex = 2;
            this.chkIsMinorArtifact.Text = "神器";
            this.chkIsMinorArtifact.UseVisualStyleBackColor = true;
            // 
            // cbSetBonus
            // 
            this.cbSetBonus.FormattingEnabled = true;
            this.cbSetBonus.Location = new System.Drawing.Point(355, 12);
            this.cbSetBonus.Name = "cbSetBonus";
            this.cbSetBonus.Size = new System.Drawing.Size(121, 20);
            this.cbSetBonus.TabIndex = 3;
            // 
            // cbBaseProp
            // 
            this.cbBaseProp.FormattingEnabled = true;
            this.cbBaseProp.Location = new System.Drawing.Point(206, 12);
            this.cbBaseProp.Name = "cbBaseProp";
            this.cbBaseProp.Size = new System.Drawing.Size(121, 20);
            this.cbBaseProp.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(710, 372);
            this.dataGridView1.TabIndex = 6;
            // 
            // frmEquipQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 450);
            this.Controls.Add(label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(label1);
            this.Controls.Add(this.cbBaseProp);
            this.Controls.Add(this.cbSetBonus);
            this.Controls.Add(this.chkIsMinorArtifact);
            this.Controls.Add(this.txtLevelTo);
            this.Controls.Add(this.txtLevelFrom);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEquipQuery";
            this.Text = "frmEquipQuery";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLevelFrom;
        private System.Windows.Forms.TextBox txtLevelTo;
        private System.Windows.Forms.CheckBox chkIsMinorArtifact;
        private System.Windows.Forms.ComboBox cbSetBonus;
        private System.Windows.Forms.ComboBox cbBaseProp;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}