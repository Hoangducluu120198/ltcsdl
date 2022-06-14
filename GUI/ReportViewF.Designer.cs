namespace StaffManagement1
{
    partial class ReportViewF
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
            this.RPView = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.btReport = new System.Windows.Forms.Button();
            this.btReportEmployee = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RPView
            // 
            this.RPView.ActiveViewIndex = -1;
            this.RPView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RPView.Cursor = System.Windows.Forms.Cursors.Default;
            this.RPView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RPView.Location = new System.Drawing.Point(0, 0);
            this.RPView.Name = "RPView";
            this.RPView.Size = new System.Drawing.Size(800, 450);
            this.RPView.TabIndex = 0;
            // 
            // btReport
            // 
            this.btReport.Location = new System.Drawing.Point(43, 58);
            this.btReport.Name = "btReport";
            this.btReport.Size = new System.Drawing.Size(120, 23);
            this.btReport.TabIndex = 1;
            this.btReport.Text = "Report Payroll";
            this.btReport.UseVisualStyleBackColor = true;
            this.btReport.Click += new System.EventHandler(this.ReportViewF_Click);
            // 
            // btReportEmployee
            // 
            this.btReportEmployee.Location = new System.Drawing.Point(43, 100);
            this.btReportEmployee.Name = "btReportEmployee";
            this.btReportEmployee.Size = new System.Drawing.Size(120, 23);
            this.btReportEmployee.TabIndex = 1;
            this.btReportEmployee.Text = "Report Employee";
            this.btReportEmployee.UseVisualStyleBackColor = true;
            this.btReportEmployee.Click += new System.EventHandler(this.btReportEmployee_Click);
            // 
            // ReportViewF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btReportEmployee);
            this.Controls.Add(this.btReport);
            this.Controls.Add(this.RPView);
            this.Name = "ReportViewF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer RPView;
        private System.Windows.Forms.Button btReport;
        private System.Windows.Forms.Button btReportEmployee;
    }
}