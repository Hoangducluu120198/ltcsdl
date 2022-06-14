namespace StaffManagement1
{
    partial class DepartmentForm
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
            this.cbDepartment = new System.Windows.Forms.ComboBox();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.txtIDDepartment = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btaddDepartment = new System.Windows.Forms.Button();
            this.btSavingPB = new System.Windows.Forms.Button();
            this.btDeletePB = new System.Windows.Forms.Button();
            this.dgDepartment = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdNV = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNameNV = new System.Windows.Forms.TextBox();
            this.txtTitleNV = new System.Windows.Forms.TextBox();
            this.btSavingNvPB = new System.Windows.Forms.Button();
            this.btDeleteNvPB = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbNV = new System.Windows.Forms.ComboBox();
            this.btAddNvPB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgDepartment)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbDepartment
            // 
            this.cbDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDepartment.FormattingEnabled = true;
            this.cbDepartment.Location = new System.Drawing.Point(12, 57);
            this.cbDepartment.Name = "cbDepartment";
            this.cbDepartment.Size = new System.Drawing.Size(160, 28);
            this.cbDepartment.TabIndex = 0;
            this.cbDepartment.SelectedIndexChanged += new System.EventHandler(this.cbDepartment_SelectedIndexChanged);
            // 
            // txtDepartment
            // 
            this.txtDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepartment.Location = new System.Drawing.Point(303, 59);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(160, 26);
            this.txtDepartment.TabIndex = 1;
            // 
            // txtIDDepartment
            // 
            this.txtIDDepartment.Enabled = false;
            this.txtIDDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDDepartment.Location = new System.Drawing.Point(211, 57);
            this.txtIDDepartment.Name = "txtIDDepartment";
            this.txtIDDepartment.Size = new System.Drawing.Size(60, 26);
            this.txtIDDepartment.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(307, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên Phòng Ban";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(207, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "Phòng Ban";
            // 
            // btaddDepartment
            // 
            this.btaddDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btaddDepartment.Location = new System.Drawing.Point(322, 120);
            this.btaddDepartment.Name = "btaddDepartment";
            this.btaddDepartment.Size = new System.Drawing.Size(75, 35);
            this.btaddDepartment.TabIndex = 3;
            this.btaddDepartment.Text = "Thêm ";
            this.btaddDepartment.UseVisualStyleBackColor = true;
            this.btaddDepartment.Click += new System.EventHandler(this.btaddDepartment_Click);
            // 
            // btSavingPB
            // 
            this.btSavingPB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSavingPB.Location = new System.Drawing.Point(413, 120);
            this.btSavingPB.Name = "btSavingPB";
            this.btSavingPB.Size = new System.Drawing.Size(75, 35);
            this.btSavingPB.TabIndex = 3;
            this.btSavingPB.Text = "Lưu";
            this.btSavingPB.UseVisualStyleBackColor = true;
            this.btSavingPB.Click += new System.EventHandler(this.btSavingPB_Click);
            // 
            // btDeletePB
            // 
            this.btDeletePB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDeletePB.Location = new System.Drawing.Point(507, 120);
            this.btDeletePB.Name = "btDeletePB";
            this.btDeletePB.Size = new System.Drawing.Size(75, 35);
            this.btDeletePB.TabIndex = 3;
            this.btDeletePB.Text = "Xóa";
            this.btDeletePB.UseVisualStyleBackColor = true;
            this.btDeletePB.Click += new System.EventHandler(this.btDeletePB_Click);
            // 
            // dgDepartment
            // 
            this.dgDepartment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDepartment.Location = new System.Drawing.Point(10, 313);
            this.dgDepartment.Name = "dgDepartment";
            this.dgDepartment.Size = new System.Drawing.Size(600, 156);
            this.dgDepartment.TabIndex = 4;
            this.dgDepartment.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDepartment_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(635, 100);
            this.panel1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SeaShell;
            this.label3.Location = new System.Drawing.Point(86, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(433, 42);
            this.label3.TabIndex = 0;
            this.label3.Text = "QUẢN LÝ PHÒNG BAN";
            // 
            // txtIdNV
            // 
            this.txtIdNV.Enabled = false;
            this.txtIdNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdNV.Location = new System.Drawing.Point(136, 39);
            this.txtIdNV.Name = "txtIdNV";
            this.txtIdNV.Size = new System.Drawing.Size(59, 26);
            this.txtIdNV.TabIndex = 1;
            this.txtIdNV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 24);
            this.label5.TabIndex = 2;
            this.label5.Text = "Mã NV";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 24);
            this.label6.TabIndex = 2;
            this.label6.Text = "Họ tên NV";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 24);
            this.label7.TabIndex = 2;
            this.label7.Text = "Chức vụ";
            // 
            // txtNameNV
            // 
            this.txtNameNV.Enabled = false;
            this.txtNameNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameNV.Location = new System.Drawing.Point(136, 89);
            this.txtNameNV.Name = "txtNameNV";
            this.txtNameNV.Size = new System.Drawing.Size(160, 26);
            this.txtNameNV.TabIndex = 1;
            // 
            // txtTitleNV
            // 
            this.txtTitleNV.Enabled = false;
            this.txtTitleNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitleNV.Location = new System.Drawing.Point(136, 139);
            this.txtTitleNV.Name = "txtTitleNV";
            this.txtTitleNV.Size = new System.Drawing.Size(160, 26);
            this.txtTitleNV.TabIndex = 1;
            // 
            // btSavingNvPB
            // 
            this.btSavingNvPB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSavingNvPB.Location = new System.Drawing.Point(413, 128);
            this.btSavingNvPB.Name = "btSavingNvPB";
            this.btSavingNvPB.Size = new System.Drawing.Size(75, 35);
            this.btSavingNvPB.TabIndex = 3;
            this.btSavingNvPB.Text = "Lưu";
            this.btSavingNvPB.UseVisualStyleBackColor = true;
            this.btSavingNvPB.Click += new System.EventHandler(this.btSavingNvPB_Click);
            // 
            // btDeleteNvPB
            // 
            this.btDeleteNvPB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDeleteNvPB.Location = new System.Drawing.Point(507, 128);
            this.btDeleteNvPB.Name = "btDeleteNvPB";
            this.btDeleteNvPB.Size = new System.Drawing.Size(75, 35);
            this.btDeleteNvPB.TabIndex = 3;
            this.btDeleteNvPB.Text = "Xóa";
            this.btDeleteNvPB.UseVisualStyleBackColor = true;
            this.btDeleteNvPB.Click += new System.EventHandler(this.btDeleteNvPB_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btDeletePB);
            this.groupBox1.Controls.Add(this.btSavingPB);
            this.groupBox1.Controls.Add(this.btaddDepartment);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtIDDepartment);
            this.groupBox1.Controls.Add(this.txtDepartment);
            this.groupBox1.Controls.Add(this.cbDepartment);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(10, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(611, 178);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DEPARTMENT";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbNV);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtIdNV);
            this.groupBox2.Controls.Add(this.btAddNvPB);
            this.groupBox2.Controls.Add(this.txtNameNV);
            this.groupBox2.Controls.Add(this.txtTitleNV);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.btDeleteNvPB);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btSavingNvPB);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(10, 495);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(611, 178);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "EMPLOYEE";
            // 
            // cbNV
            // 
            this.cbNV.FormattingEnabled = true;
            this.cbNV.Location = new System.Drawing.Point(201, 39);
            this.cbNV.Name = "cbNV";
            this.cbNV.Size = new System.Drawing.Size(95, 32);
            this.cbNV.TabIndex = 4;
            // 
            // btAddNvPB
            // 
            this.btAddNvPB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAddNvPB.Location = new System.Drawing.Point(313, 128);
            this.btAddNvPB.Name = "btAddNvPB";
            this.btAddNvPB.Size = new System.Drawing.Size(75, 35);
            this.btAddNvPB.TabIndex = 3;
            this.btAddNvPB.Text = "Thêm ";
            this.btAddNvPB.UseVisualStyleBackColor = true;
            this.btAddNvPB.Click += new System.EventHandler(this.btAddNvPB_Click);
            // 
            // DepartmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(635, 705);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgDepartment);
            this.MaximizeBox = false;
            this.Name = "DepartmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Phòng Ban";
            this.Load += new System.EventHandler(this.DepartmentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgDepartment)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbDepartment;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.TextBox txtIDDepartment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btaddDepartment;
        private System.Windows.Forms.Button btSavingPB;
        private System.Windows.Forms.Button btDeletePB;
        private System.Windows.Forms.DataGridView dgDepartment;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdNV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNameNV;
        private System.Windows.Forms.TextBox txtTitleNV;
        private System.Windows.Forms.Button btSavingNvPB;
        private System.Windows.Forms.Button btDeleteNvPB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btAddNvPB;
        private System.Windows.Forms.ComboBox cbNV;
    }
}