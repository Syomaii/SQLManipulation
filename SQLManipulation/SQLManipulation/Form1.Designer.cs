namespace SQLManipulation
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
            this.btnEAPAS = new System.Windows.Forms.Button();
            this.btnDTS = new System.Windows.Forms.Button();
            this.btnDSLNSM = new System.Windows.Forms.Button();
            this.btnDPEADS = new System.Windows.Forms.Button();
            this.btnDTSDS = new System.Windows.Forms.Button();
            this.btnDELS = new System.Windows.Forms.Button();
            this.btnDEMT = new System.Windows.Forms.Button();
            this.btnDETC = new System.Windows.Forms.Button();
            this.btnPAMT = new System.Windows.Forms.Button();
            this.dGrid1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEAPAS
            // 
            this.btnEAPAS.BackColor = System.Drawing.Color.Cyan;
            this.btnEAPAS.Location = new System.Drawing.Point(837, 121);
            this.btnEAPAS.Name = "btnEAPAS";
            this.btnEAPAS.Size = new System.Drawing.Size(320, 50);
            this.btnEAPAS.TabIndex = 0;
            this.btnEAPAS.Text = "Display Employees Above Production Average Salary";
            this.btnEAPAS.UseVisualStyleBackColor = false;
            this.btnEAPAS.Click += new System.EventHandler(this.btnEAPAS_Click);
            // 
            // btnDTS
            // 
            this.btnDTS.BackColor = System.Drawing.Color.Cyan;
            this.btnDTS.Location = new System.Drawing.Point(837, 177);
            this.btnDTS.Name = "btnDTS";
            this.btnDTS.Size = new System.Drawing.Size(320, 46);
            this.btnDTS.TabIndex = 1;
            this.btnDTS.Text = "Display Total Salaries";
            this.btnDTS.UseVisualStyleBackColor = false;
            this.btnDTS.Click += new System.EventHandler(this.btnDTS_Click);
            // 
            // btnDSLNSM
            // 
            this.btnDSLNSM.BackColor = System.Drawing.Color.Cyan;
            this.btnDSLNSM.Location = new System.Drawing.Point(837, 229);
            this.btnDSLNSM.Name = "btnDSLNSM";
            this.btnDSLNSM.Size = new System.Drawing.Size(320, 52);
            this.btnDSLNSM.TabIndex = 2;
            this.btnDSLNSM.Text = "Display Salary of Last Name Starting with M";
            this.btnDSLNSM.UseVisualStyleBackColor = false;
            this.btnDSLNSM.Click += new System.EventHandler(this.btnDSLNSM_Click);
            // 
            // btnDPEADS
            // 
            this.btnDPEADS.BackColor = System.Drawing.Color.Cyan;
            this.btnDPEADS.Location = new System.Drawing.Point(837, 287);
            this.btnDPEADS.Name = "btnDPEADS";
            this.btnDPEADS.Size = new System.Drawing.Size(320, 71);
            this.btnDPEADS.TabIndex = 3;
            this.btnDPEADS.Text = "Display Production Employee Above Department Salary";
            this.btnDPEADS.UseVisualStyleBackColor = false;
            this.btnDPEADS.Click += new System.EventHandler(this.btnDPEADS_Click);
            // 
            // btnDTSDS
            // 
            this.btnDTSDS.BackColor = System.Drawing.Color.Cyan;
            this.btnDTSDS.Location = new System.Drawing.Point(837, 364);
            this.btnDTSDS.Name = "btnDTSDS";
            this.btnDTSDS.Size = new System.Drawing.Size(320, 44);
            this.btnDTSDS.TabIndex = 4;
            this.btnDTSDS.Text = "Display Total Sales Department Salaries";
            this.btnDTSDS.UseVisualStyleBackColor = false;
            this.btnDTSDS.Click += new System.EventHandler(this.btnDTSDS_Click);
            // 
            // btnDELS
            // 
            this.btnDELS.BackColor = System.Drawing.Color.Cyan;
            this.btnDELS.Location = new System.Drawing.Point(837, 414);
            this.btnDELS.Name = "btnDELS";
            this.btnDELS.Size = new System.Drawing.Size(320, 51);
            this.btnDELS.TabIndex = 5;
            this.btnDELS.Text = "Display Employee with Least Salary";
            this.btnDELS.UseVisualStyleBackColor = false;
            this.btnDELS.Click += new System.EventHandler(this.btnDELS_Click);
            // 
            // btnDEMT
            // 
            this.btnDEMT.BackColor = System.Drawing.Color.Cyan;
            this.btnDEMT.Location = new System.Drawing.Point(837, 532);
            this.btnDEMT.Name = "btnDEMT";
            this.btnDEMT.Size = new System.Drawing.Size(320, 52);
            this.btnDEMT.TabIndex = 6;
            this.btnDEMT.Text = "Display Employee with Multiple Trainings";
            this.btnDEMT.UseVisualStyleBackColor = false;
            this.btnDEMT.Click += new System.EventHandler(this.btnDEMT_Click);
            // 
            // btnDETC
            // 
            this.btnDETC.BackColor = System.Drawing.Color.Cyan;
            this.btnDETC.Location = new System.Drawing.Point(837, 471);
            this.btnDETC.Name = "btnDETC";
            this.btnDETC.Size = new System.Drawing.Size(320, 55);
            this.btnDETC.TabIndex = 7;
            this.btnDETC.Text = "Display Employee with Training Course";
            this.btnDETC.UseVisualStyleBackColor = false;
            this.btnDETC.Click += new System.EventHandler(this.btnDETC_Click);
            // 
            // btnPAMT
            // 
            this.btnPAMT.BackColor = System.Drawing.Color.Cyan;
            this.btnPAMT.Location = new System.Drawing.Point(837, 590);
            this.btnPAMT.Name = "btnPAMT";
            this.btnPAMT.Size = new System.Drawing.Size(320, 54);
            this.btnPAMT.TabIndex = 8;
            this.btnPAMT.Text = "Display Participants of Anger Management Training";
            this.btnPAMT.UseVisualStyleBackColor = false;
            this.btnPAMT.Click += new System.EventHandler(this.btnPAMT_Click);
            // 
            // dGrid1
            // 
            this.dGrid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGrid1.BackgroundColor = System.Drawing.Color.Aquamarine;
            this.dGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGrid1.Location = new System.Drawing.Point(43, 121);
            this.dGrid1.Name = "dGrid1";
            this.dGrid1.RowHeadersWidth = 51;
            this.dGrid1.RowTemplate.Height = 24;
            this.dGrid1.Size = new System.Drawing.Size(765, 523);
            this.dGrid1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(314, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(558, 97);
            this.label1.TabIndex = 10;
            this.label1.Text = "KOMPANYA";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(1180, 679);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dGrid1);
            this.Controls.Add(this.btnPAMT);
            this.Controls.Add(this.btnDETC);
            this.Controls.Add(this.btnDEMT);
            this.Controls.Add(this.btnDELS);
            this.Controls.Add(this.btnDTSDS);
            this.Controls.Add(this.btnDPEADS);
            this.Controls.Add(this.btnDSLNSM);
            this.Controls.Add(this.btnDTS);
            this.Controls.Add(this.btnEAPAS);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Kompanya";
            ((System.ComponentModel.ISupportInitialize)(this.dGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEAPAS;
        private System.Windows.Forms.Button btnDTS;
        private System.Windows.Forms.Button btnDSLNSM;
        private System.Windows.Forms.Button btnDPEADS;
        private System.Windows.Forms.Button btnDTSDS;
        private System.Windows.Forms.Button btnDELS;
        private System.Windows.Forms.Button btnDEMT;
        private System.Windows.Forms.Button btnDETC;
        private System.Windows.Forms.Button btnPAMT;
        private System.Windows.Forms.DataGridView dGrid1;
        private System.Windows.Forms.Label label1;
    }
}

