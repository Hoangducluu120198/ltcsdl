namespace StaffManagement1
{
    partial class Mform
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quảnLýPhòngBanToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.hồSơNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýPhòngBanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýLươngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngKýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýPhòngBanToolStripMenuItem1,
            this.hồSơNhânViênToolStripMenuItem,
            this.quảnLýPhòngBanToolStripMenuItem,
            this.quảnLýLươngToolStripMenuItem,
            this.tàiKhoảnToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(667, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quảnLýPhòngBanToolStripMenuItem1
            // 
            this.quảnLýPhòngBanToolStripMenuItem1.Name = "quảnLýPhòngBanToolStripMenuItem1";
            this.quảnLýPhòngBanToolStripMenuItem1.Size = new System.Drawing.Size(123, 20);
            this.quảnLýPhòngBanToolStripMenuItem1.Text = "Quản Lý Phòng Ban";
            this.quảnLýPhòngBanToolStripMenuItem1.Click += new System.EventHandler(this.quảnLýPhòngBanToolStripMenuItem1_Click);
            // 
            // hồSơNhânViênToolStripMenuItem
            // 
            this.hồSơNhânViênToolStripMenuItem.Name = "hồSơNhânViênToolStripMenuItem";
            this.hồSơNhânViênToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.hồSơNhânViênToolStripMenuItem.Text = "Hồ Sơ Nhân Viên";
            this.hồSơNhânViênToolStripMenuItem.Click += new System.EventHandler(this.hồSơNhânViênToolStripMenuItem_Click);
            // 
            // quảnLýPhòngBanToolStripMenuItem
            // 
            this.quảnLýPhòngBanToolStripMenuItem.Name = "quảnLýPhòngBanToolStripMenuItem";
            this.quảnLýPhòngBanToolStripMenuItem.Size = new System.Drawing.Size(12, 20);
            // 
            // quảnLýLươngToolStripMenuItem
            // 
            this.quảnLýLươngToolStripMenuItem.Name = "quảnLýLươngToolStripMenuItem";
            this.quảnLýLươngToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.quảnLýLươngToolStripMenuItem.Text = "Quản Lý Lương";
            this.quảnLýLươngToolStripMenuItem.Click += new System.EventHandler(this.quảnLýLươngToolStripMenuItem_Click);
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            this.tàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngKýToolStripMenuItem});
            this.tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            this.tàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.tàiKhoảnToolStripMenuItem.Text = "Tài Khoản";
            // 
            // đăngKýToolStripMenuItem
            // 
            this.đăngKýToolStripMenuItem.Name = "đăngKýToolStripMenuItem";
            this.đăngKýToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.đăngKýToolStripMenuItem.Text = "Đăng Ký";
            this.đăngKýToolStripMenuItem.Click += new System.EventHandler(this.đăngKýToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // Mform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::StaffManagement1.Properties.Resources.nhansu_15272952345711312615035;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(667, 335);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimizeBox = false;
            this.Name = "Mform";
            this.Text = "Quản Lý Nhân Viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Mform_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hồSơNhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýPhòngBanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýLươngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýPhòngBanToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngKýToolStripMenuItem;
    }
}

