namespace 天魔墨香登入器
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.resolution_800 = new System.Windows.Forms.PictureBox();
            this.resolution_1024 = new System.Windows.Forms.PictureBox();
            this.resolution_full = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.resolution_800)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resolution_1024)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resolution_full)).BeginInit();
            this.SuspendLayout();
            // 
            // resolution_800
            // 
            this.resolution_800.BackColor = System.Drawing.Color.Transparent;
            this.resolution_800.Image = ((System.Drawing.Image)(resources.GetObject("resolution_800.Image")));
            this.resolution_800.Location = new System.Drawing.Point(6, 12);
            this.resolution_800.Name = "resolution_800";
            this.resolution_800.Size = new System.Drawing.Size(97, 18);
            this.resolution_800.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.resolution_800.TabIndex = 0;
            this.resolution_800.TabStop = false;
            this.resolution_800.Click += new System.EventHandler(this.resolution_800_Click);
            // 
            // resolution_1024
            // 
            this.resolution_1024.BackColor = System.Drawing.Color.Transparent;
            this.resolution_1024.Image = ((System.Drawing.Image)(resources.GetObject("resolution_1024.Image")));
            this.resolution_1024.Location = new System.Drawing.Point(6, 36);
            this.resolution_1024.Name = "resolution_1024";
            this.resolution_1024.Size = new System.Drawing.Size(100, 21);
            this.resolution_1024.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.resolution_1024.TabIndex = 1;
            this.resolution_1024.TabStop = false;
            // 
            // resolution_full
            // 
            this.resolution_full.BackColor = System.Drawing.Color.Transparent;
            this.resolution_full.Image = ((System.Drawing.Image)(resources.GetObject("resolution_full.Image")));
            this.resolution_full.Location = new System.Drawing.Point(6, 63);
            this.resolution_full.Name = "resolution_full";
            this.resolution_full.Size = new System.Drawing.Size(106, 20);
            this.resolution_full.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.resolution_full.TabIndex = 2;
            this.resolution_full.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(116, 94);
            this.ControlBox = false;
            this.Controls.Add(this.resolution_full);
            this.Controls.Add(this.resolution_1024);
            this.Controls.Add(this.resolution_800);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "请选择视窗大小";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.resolution_800)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resolution_1024)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resolution_full)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox resolution_800;
        private System.Windows.Forms.PictureBox resolution_1024;
        private System.Windows.Forms.PictureBox resolution_full;
       // public System.Windows.Forms.PictureBox resolution_back;
    }
}