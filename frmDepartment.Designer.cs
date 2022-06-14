namespace QLPB
{
    partial class frmDepartment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDepartment));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbmaBP = new System.Windows.Forms.ComboBox();
            this.textDate = new System.Windows.Forms.DateTimePicker();
            this.textMaPB = new System.Windows.Forms.TextBox();
            this.textGhiChu = new System.Windows.Forms.TextBox();
            this.textTenPB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btSua = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgPB = new System.Windows.Forms.DataGridView();
            this.btXoa = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPB)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cbmaBP);
            this.groupBox1.Controls.Add(this.textDate);
            this.groupBox1.Controls.Add(this.textMaPB);
            this.groupBox1.Controls.Add(this.textGhiChu);
            this.groupBox1.Controls.Add(this.textTenPB);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(86, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(600, 141);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phòng ban";
            // 
            // cbmaBP
            // 
            this.cbmaBP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmaBP.FormattingEnabled = true;
            this.cbmaBP.Location = new System.Drawing.Point(116, 49);
            this.cbmaBP.Name = "cbmaBP";
            this.cbmaBP.Size = new System.Drawing.Size(149, 23);
            this.cbmaBP.TabIndex = 3;
            // 
            // textDate
            // 
            this.textDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.textDate.Location = new System.Drawing.Point(413, 81);
            this.textDate.Name = "textDate";
            this.textDate.Size = new System.Drawing.Size(148, 21);
            this.textDate.TabIndex = 2;
            // 
            // textMaPB
            // 
            this.textMaPB.Location = new System.Drawing.Point(116, 78);
            this.textMaPB.Name = "textMaPB";
            this.textMaPB.Size = new System.Drawing.Size(149, 21);
            this.textMaPB.TabIndex = 1;
            // 
            // textGhiChu
            // 
            this.textGhiChu.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.textGhiChu.AllowDrop = true;
            this.textGhiChu.Location = new System.Drawing.Point(116, 112);
            this.textGhiChu.Multiline = true;
            this.textGhiChu.Name = "textGhiChu";
            this.textGhiChu.Size = new System.Drawing.Size(445, 23);
            this.textGhiChu.TabIndex = 1;
            // 
            // textTenPB
            // 
            this.textTenPB.Location = new System.Drawing.Point(412, 49);
            this.textTenPB.Name = "textTenPB";
            this.textTenPB.Size = new System.Drawing.Size(149, 21);
            this.textTenPB.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ghi chú:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(311, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ngày thành lập:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(311, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên phòng ban:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã phòng ban:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã bộ phận:";
            // 
            // btSua
            // 
            this.btSua.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btSua.BackgroundImage")));
            this.btSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btSua.FlatAppearance.BorderSize = 0;
            this.btSua.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btSua.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSua.Location = new System.Drawing.Point(228, 20);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(70, 28);
            this.btSua.TabIndex = 8;
            this.btSua.Text = "Sửa   ";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btThem
            // 
            this.btThem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btThem.BackgroundImage")));
            this.btThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btThem.FlatAppearance.BorderSize = 0;
            this.btThem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btThem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThem.Location = new System.Drawing.Point(116, 20);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(70, 28);
            this.btThem.TabIndex = 7;
            this.btThem.Text = "Thêm ";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgPB);
            this.panel1.Location = new System.Drawing.Point(86, 264);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(561, 169);
            this.panel1.TabIndex = 5;
            // 
            // dgPB
            // 
            this.dgPB.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgPB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPB.Location = new System.Drawing.Point(0, 0);
            this.dgPB.Name = "dgPB";
            this.dgPB.Size = new System.Drawing.Size(561, 172);
            this.dgPB.TabIndex = 0;
            this.dgPB.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPB_CellClick);
            this.dgPB.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPB_CellContentClick);
            // 
            // btXoa
            // 
            this.btXoa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btXoa.BackgroundImage")));
            this.btXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btXoa.FlatAppearance.BorderSize = 0;
            this.btXoa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btXoa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btXoa.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btXoa.Location = new System.Drawing.Point(341, 20);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(70, 28);
            this.btXoa.TabIndex = 9;
            this.btXoa.Text = "Xóa   ";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btThoat
            // 
            this.btThoat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btThoat.BackgroundImage")));
            this.btThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btThoat.FlatAppearance.BorderSize = 0;
            this.btThoat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btThoat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThoat.Location = new System.Drawing.Point(452, 20);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(70, 28);
            this.btThoat.TabIndex = 11;
            this.btThoat.Text = "Thoát ";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btThoat);
            this.groupBox2.Controls.Add(this.btXoa);
            this.groupBox2.Controls.Add(this.btThem);
            this.groupBox2.Controls.Add(this.btSua);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.groupBox2.Location = new System.Drawing.Point(86, 193);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(600, 54);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(266, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(246, 36);
            this.label6.TabIndex = 6;
            this.label6.Text = "QUẢN LÝ PHÒNG BAN";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(688, 445);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmDepartment";
            this.Text = "frmDepartment";
            this.Load += new System.EventHandler(this.frmDepartment_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgPB)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbmaBP;
        private System.Windows.Forms.DateTimePicker textDate;
        private System.Windows.Forms.TextBox textMaPB;
        private System.Windows.Forms.TextBox textGhiChu;
        private System.Windows.Forms.TextBox textTenPB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgPB;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;

        public System.EventHandler cbmaBP_SelectedIndexChanged { get; set; }

        public System.EventHandler textMaPB_TextChanged { get; set; }
    }
}