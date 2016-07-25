namespace 天魔墨香登入器
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.officialWeb_button = new System.Windows.Forms.PictureBox();
            this.facebook_button = new System.Windows.Forms.PictureBox();
            this.register_button = new System.Windows.Forms.PictureBox();
            this.reload_button = new System.Windows.Forms.PictureBox();
            this.update_button = new System.Windows.Forms.PictureBox();
            this.login_button = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.close_button = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.resolution_back = new System.Windows.Forms.PictureBox();
            this.resolution_800 = new System.Windows.Forms.PictureBox();
            this.resolution_1024 = new System.Windows.Forms.PictureBox();
            this.resolution_full = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.officialWeb_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facebook_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.register_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reload_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.update_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.login_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resolution_back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resolution_800)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resolution_1024)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resolution_full)).BeginInit();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(13, 105);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(754, 246);
            this.webBrowser1.TabIndex = 3;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(13, 433);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(544, 23);
            this.progressBar1.TabIndex = 7;
            // 
            // officialWeb_button
            // 
            this.officialWeb_button.BackColor = System.Drawing.Color.Transparent;
            this.officialWeb_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.officialWeb_button.Image = ((System.Drawing.Image)(resources.GetObject("officialWeb_button.Image")));
            this.officialWeb_button.Location = new System.Drawing.Point(30, 363);
            this.officialWeb_button.Name = "officialWeb_button";
            this.officialWeb_button.Size = new System.Drawing.Size(73, 41);
            this.officialWeb_button.TabIndex = 8;
            this.officialWeb_button.TabStop = false;
            this.officialWeb_button.Click += new System.EventHandler(this.officialWeb_button_Click);
            this.officialWeb_button.MouseEnter += new System.EventHandler(this.officialWeb_button_MouseEnter);
            this.officialWeb_button.MouseLeave += new System.EventHandler(this.officialWeb_button_MouseLeave);
            // 
            // facebook_button
            // 
            this.facebook_button.BackColor = System.Drawing.Color.Transparent;
            this.facebook_button.Image = global::天魔墨香登入器.Properties.Resources.facebook1;
            this.facebook_button.Location = new System.Drawing.Point(131, 363);
            this.facebook_button.Name = "facebook_button";
            this.facebook_button.Size = new System.Drawing.Size(92, 41);
            this.facebook_button.TabIndex = 9;
            this.facebook_button.TabStop = false;
            this.facebook_button.Click += new System.EventHandler(this.facebook_button_Click);
            this.facebook_button.MouseEnter += new System.EventHandler(this.facebook_button_MouseEnter);
            this.facebook_button.MouseLeave += new System.EventHandler(this.facebook_button_MouseLeave);
            // 
            // register_button
            // 
            this.register_button.BackColor = System.Drawing.Color.Transparent;
            this.register_button.Image = global::天魔墨香登入器.Properties.Resources.member1;
            this.register_button.Location = new System.Drawing.Point(252, 363);
            this.register_button.Name = "register_button";
            this.register_button.Size = new System.Drawing.Size(76, 41);
            this.register_button.TabIndex = 10;
            this.register_button.TabStop = false;
            this.register_button.Click += new System.EventHandler(this.register_button_Click);
            this.register_button.MouseEnter += new System.EventHandler(this.register_button_MouseEnter);
            this.register_button.MouseLeave += new System.EventHandler(this.register_button_MouseLeave);
            // 
            // reload_button
            // 
            this.reload_button.BackColor = System.Drawing.Color.Transparent;
            this.reload_button.Image = global::天魔墨香登入器.Properties.Resources.reload1;
            this.reload_button.Location = new System.Drawing.Point(366, 363);
            this.reload_button.Name = "reload_button";
            this.reload_button.Size = new System.Drawing.Size(70, 41);
            this.reload_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.reload_button.TabIndex = 11;
            this.reload_button.TabStop = false;
            this.reload_button.Click += new System.EventHandler(this.reload_button_Click);
            this.reload_button.MouseEnter += new System.EventHandler(this.reload_button_MouseEnter);
            this.reload_button.MouseLeave += new System.EventHandler(this.reload_button_MouseLeave);
            // 
            // update_button
            // 
            this.update_button.BackColor = System.Drawing.Color.Transparent;
            this.update_button.Image = global::天魔墨香登入器.Properties.Resources.update1;
            this.update_button.Location = new System.Drawing.Point(472, 363);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(71, 41);
            this.update_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.update_button.TabIndex = 12;
            this.update_button.TabStop = false;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            this.update_button.MouseEnter += new System.EventHandler(this.update_button_MouseEnter);
            this.update_button.MouseLeave += new System.EventHandler(this.update_button_MouseLeave);
            // 
            // login_button
            // 
            this.login_button.BackColor = System.Drawing.Color.Transparent;
            this.login_button.Image = global::天魔墨香登入器.Properties.Resources.login_1;
            this.login_button.Location = new System.Drawing.Point(571, 357);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(196, 77);
            this.login_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.login_button.TabIndex = 13;
            this.login_button.TabStop = false;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            this.login_button.MouseEnter += new System.EventHandler(this.login_button_MouseEnter);
            this.login_button.MouseLeave += new System.EventHandler(this.login_button_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 415);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 16);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // close_button
            // 
            this.close_button.BackColor = System.Drawing.Color.Transparent;
            this.close_button.Image = ((System.Drawing.Image)(resources.GetObject("close_button.Image")));
            this.close_button.Location = new System.Drawing.Point(758, 0);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(20, 20);
            this.close_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.close_button.TabIndex = 15;
            this.close_button.TabStop = false;
            this.toolTip1.SetToolTip(this.close_button, "點擊這個退出登入器");
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
            this.close_button.MouseEnter += new System.EventHandler(this.close_button_MouseEnter);
            this.close_button.MouseLeave += new System.EventHandler(this.close_button_MouseLeave);
            // 
            // resolution_back
            // 
            this.resolution_back.BackColor = System.Drawing.Color.Transparent;
            this.resolution_back.Image = ((System.Drawing.Image)(resources.GetObject("resolution_back.Image")));
            this.resolution_back.Location = new System.Drawing.Point(599, 434);
            this.resolution_back.Name = "resolution_back";
            this.resolution_back.Size = new System.Drawing.Size(146, 28);
            this.resolution_back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.resolution_back.TabIndex = 16;
            this.resolution_back.TabStop = false;
            this.toolTip1.SetToolTip(this.resolution_back, "选择游戏视窗大小");
            this.resolution_back.Click += new System.EventHandler(this.resolution_back_Click);
            // 
            // resolution_800
            // 
            this.resolution_800.BackColor = System.Drawing.Color.Linen;
            this.resolution_800.Image = ((System.Drawing.Image)(resources.GetObject("resolution_800.Image")));
            this.resolution_800.Location = new System.Drawing.Point(621, 363);
            this.resolution_800.Name = "resolution_800";
            this.resolution_800.Size = new System.Drawing.Size(97, 18);
            this.resolution_800.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.resolution_800.TabIndex = 17;
            this.resolution_800.TabStop = false;
            this.resolution_800.Visible = false;
            this.resolution_800.Click += new System.EventHandler(this.resolution_800_Click);
            // 
            // resolution_1024
            // 
            this.resolution_1024.BackColor = System.Drawing.Color.Linen;
            this.resolution_1024.Image = ((System.Drawing.Image)(resources.GetObject("resolution_1024.Image")));
            this.resolution_1024.Location = new System.Drawing.Point(621, 383);
            this.resolution_1024.Name = "resolution_1024";
            this.resolution_1024.Size = new System.Drawing.Size(100, 21);
            this.resolution_1024.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.resolution_1024.TabIndex = 18;
            this.resolution_1024.TabStop = false;
            this.resolution_1024.Visible = false;
            this.resolution_1024.Click += new System.EventHandler(this.resolution_1024_Click);
            // 
            // resolution_full
            // 
            this.resolution_full.BackColor = System.Drawing.Color.Linen;
            this.resolution_full.Image = ((System.Drawing.Image)(resources.GetObject("resolution_full.Image")));
            this.resolution_full.Location = new System.Drawing.Point(621, 406);
            this.resolution_full.Name = "resolution_full";
            this.resolution_full.Size = new System.Drawing.Size(106, 20);
            this.resolution_full.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.resolution_full.TabIndex = 19;
            this.resolution_full.TabStop = false;
            this.resolution_full.Visible = false;
            this.resolution_full.Click += new System.EventHandler(this.resolution_full_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(778, 461);
            this.ControlBox = false;
            this.Controls.Add(this.resolution_full);
            this.Controls.Add(this.resolution_1024);
            this.Controls.Add(this.resolution_800);
            this.Controls.Add(this.resolution_back);
            this.Controls.Add(this.close_button);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.update_button);
            this.Controls.Add(this.reload_button);
            this.Controls.Add(this.register_button);
            this.Controls.Add(this.facebook_button);
            this.Controls.Add(this.officialWeb_button);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.webBrowser1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "天魔墨香登入器-VERSION 1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.officialWeb_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facebook_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.register_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reload_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.update_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.login_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resolution_back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resolution_800)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resolution_1024)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resolution_full)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.PictureBox officialWeb_button;
        private System.Windows.Forms.PictureBox facebook_button;
        private System.Windows.Forms.PictureBox register_button;
        private System.Windows.Forms.PictureBox reload_button;
        private System.Windows.Forms.PictureBox update_button;
        private System.Windows.Forms.PictureBox login_button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox close_button;
        private System.Windows.Forms.ToolTip toolTip1;
        public System.Windows.Forms.PictureBox resolution_back;
        public bool num = false;
        private System.Windows.Forms.PictureBox resolution_800;
        private System.Windows.Forms.PictureBox resolution_1024;
        private System.Windows.Forms.PictureBox resolution_full;
    }
}

