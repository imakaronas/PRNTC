namespace TMS_ClearLogFiles_UI
{
    partial class TMS_ClearLogFiles_UI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TMS_ClearLogFiles_UI));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbDrives = new System.Windows.Forms.ComboBox();
            this.lblDiskStatus = new System.Windows.Forms.Label();
            this.btnCheckFreeSpace = new System.Windows.Forms.Button();
            this.lblDiskFreeSpace = new System.Windows.Forms.Label();
            this.txtDiskFreeSpace = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSendEmail = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbDiskPath = new System.Windows.Forms.Label();
            this.cbMonth = new System.Windows.Forms.CheckBox();
            this.txtDelFilesDiskPath = new System.Windows.Forms.TextBox();
            this.cb15Days = new System.Windows.Forms.CheckBox();
            this.btnExecuteDelete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbSendEmail = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(513, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbSendEmail);
            this.groupBox1.Controls.Add(this.cbDrives);
            this.groupBox1.Controls.Add(this.lblDiskStatus);
            this.groupBox1.Controls.Add(this.btnCheckFreeSpace);
            this.groupBox1.Controls.Add(this.lblDiskFreeSpace);
            this.groupBox1.Controls.Add(this.txtDiskFreeSpace);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnSendEmail);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(495, 144);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "  Πληροφορίες Δίσκου  ";
            // 
            // cbDrives
            // 
            this.cbDrives.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDrives.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.cbDrives.FormattingEnabled = true;
            this.cbDrives.Location = new System.Drawing.Point(125, 44);
            this.cbDrives.Name = "cbDrives";
            this.cbDrives.Size = new System.Drawing.Size(96, 21);
            this.cbDrives.TabIndex = 33;
            // 
            // lblDiskStatus
            // 
            this.lblDiskStatus.AutoSize = true;
            this.lblDiskStatus.Location = new System.Drawing.Point(238, 90);
            this.lblDiskStatus.Name = "lblDiskStatus";
            this.lblDiskStatus.Size = new System.Drawing.Size(40, 13);
            this.lblDiskStatus.TabIndex = 32;
            this.lblDiskStatus.Text = "Status ";
            // 
            // btnCheckFreeSpace
            // 
            this.btnCheckFreeSpace.Location = new System.Drawing.Point(241, 42);
            this.btnCheckFreeSpace.Name = "btnCheckFreeSpace";
            this.btnCheckFreeSpace.Size = new System.Drawing.Size(136, 25);
            this.btnCheckFreeSpace.TabIndex = 31;
            this.btnCheckFreeSpace.Text = "Έλεγχος Διαθ. Χώρου";
            this.btnCheckFreeSpace.UseVisualStyleBackColor = true;
            this.btnCheckFreeSpace.Click += new System.EventHandler(this.btnCheckFreeSpace_Click);
            // 
            // lblDiskFreeSpace
            // 
            this.lblDiskFreeSpace.AutoSize = true;
            this.lblDiskFreeSpace.Location = new System.Drawing.Point(16, 90);
            this.lblDiskFreeSpace.Name = "lblDiskFreeSpace";
            this.lblDiskFreeSpace.Size = new System.Drawing.Size(103, 13);
            this.lblDiskFreeSpace.TabIndex = 30;
            this.lblDiskFreeSpace.Text = "Διαθέσιμος Χώρος:";
            // 
            // txtDiskFreeSpace
            // 
            this.txtDiskFreeSpace.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtDiskFreeSpace.Location = new System.Drawing.Point(125, 86);
            this.txtDiskFreeSpace.Name = "txtDiskFreeSpace";
            this.txtDiskFreeSpace.ReadOnly = true;
            this.txtDiskFreeSpace.Size = new System.Drawing.Size(96, 20);
            this.txtDiskFreeSpace.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Δίσκος :";
            // 
            // btnSendEmail
            // 
            this.btnSendEmail.Location = new System.Drawing.Point(387, 79);
            this.btnSendEmail.Name = "btnSendEmail";
            this.btnSendEmail.Size = new System.Drawing.Size(80, 24);
            this.btnSendEmail.TabIndex = 34;
            this.btnSendEmail.Text = "Send email";
            this.btnSendEmail.UseVisualStyleBackColor = true;
            this.btnSendEmail.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbDiskPath);
            this.groupBox2.Controls.Add(this.cbMonth);
            this.groupBox2.Controls.Add(this.txtDelFilesDiskPath);
            this.groupBox2.Controls.Add(this.cb15Days);
            this.groupBox2.Controls.Add(this.btnExecuteDelete);
            this.groupBox2.Location = new System.Drawing.Point(12, 170);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(653, 132);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "  Διαγραφή Αρχείων  ";
            // 
            // lbDiskPath
            // 
            this.lbDiskPath.Location = new System.Drawing.Point(14, 37);
            this.lbDiskPath.Name = "lbDiskPath";
            this.lbDiskPath.Size = new System.Drawing.Size(158, 20);
            this.lbDiskPath.TabIndex = 17;
            this.lbDiskPath.Text = "Διαγραφή αρχείων από (Path):";
            // 
            // cbMonth
            // 
            this.cbMonth.AutoSize = true;
            this.cbMonth.Checked = true;
            this.cbMonth.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbMonth.Enabled = false;
            this.cbMonth.Location = new System.Drawing.Point(576, 82);
            this.cbMonth.Name = "cbMonth";
            this.cbMonth.Size = new System.Drawing.Size(59, 17);
            this.cbMonth.TabIndex = 16;
            this.cbMonth.Text = "Μήνας";
            this.cbMonth.UseVisualStyleBackColor = true;
            // 
            // txtDelFilesDiskPath
            // 
            this.txtDelFilesDiskPath.Location = new System.Drawing.Point(178, 37);
            this.txtDelFilesDiskPath.Name = "txtDelFilesDiskPath";
            this.txtDelFilesDiskPath.Size = new System.Drawing.Size(457, 20);
            this.txtDelFilesDiskPath.TabIndex = 15;
            // 
            // cb15Days
            // 
            this.cb15Days.AutoSize = true;
            this.cb15Days.Enabled = false;
            this.cb15Days.Location = new System.Drawing.Point(486, 82);
            this.cb15Days.Name = "cb15Days";
            this.cb15Days.Size = new System.Drawing.Size(68, 17);
            this.cb15Days.TabIndex = 14;
            this.cb15Days.Text = "15ήμερο";
            this.cb15Days.UseVisualStyleBackColor = true;
            // 
            // btnExecuteDelete
            // 
            this.btnExecuteDelete.Location = new System.Drawing.Point(17, 82);
            this.btnExecuteDelete.Name = "btnExecuteDelete";
            this.btnExecuteDelete.Size = new System.Drawing.Size(182, 36);
            this.btnExecuteDelete.TabIndex = 13;
            this.btnExecuteDelete.Text = "Διαγραφή Αρχείων";
            this.btnExecuteDelete.UseVisualStyleBackColor = true;
            this.btnExecuteDelete.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(612, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "ver. 1.0";
            // 
            // cbSendEmail
            // 
            this.cbSendEmail.AutoSize = true;
            this.cbSendEmail.Location = new System.Drawing.Point(387, 46);
            this.cbSendEmail.Name = "cbSendEmail";
            this.cbSendEmail.Size = new System.Drawing.Size(102, 17);
            this.cbSendEmail.TabIndex = 35;
            this.cbSendEmail.Text = "Αποστολή email";
            this.cbSendEmail.UseVisualStyleBackColor = true;
            this.cbSendEmail.CheckedChanged += new System.EventHandler(this.cbSendEmail_CheckedChanged);
            // 
            // TMS_ClearLogFiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 336);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "TMS_ClearLogFiles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TMS Clear Log Files";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbDrives;
        private System.Windows.Forms.Label lblDiskStatus;
        private System.Windows.Forms.Button btnCheckFreeSpace;
        private System.Windows.Forms.Label lblDiskFreeSpace;
        private System.Windows.Forms.TextBox txtDiskFreeSpace;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSendEmail;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbDiskPath;
        private System.Windows.Forms.CheckBox cbMonth;
        private System.Windows.Forms.TextBox txtDelFilesDiskPath;
        private System.Windows.Forms.CheckBox cb15Days;
        private System.Windows.Forms.Button btnExecuteDelete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbSendEmail;
    }
}

