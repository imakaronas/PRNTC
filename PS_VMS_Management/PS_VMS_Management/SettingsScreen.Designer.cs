namespace PS_VMS_Management
{
    partial class SettingsScreen
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
            this.gpbPaths = new System.Windows.Forms.GroupBox();
            this.lbOLISPath = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbEFGPath = new System.Windows.Forms.Label();
            this.lbPBGPath = new System.Windows.Forms.Label();
            this.lbNBGPath = new System.Windows.Forms.Label();
            this.btnSaveClose = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gpbPaths.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbPaths
            // 
            this.gpbPaths.Controls.Add(this.lbOLISPath);
            this.gpbPaths.Controls.Add(this.textBox4);
            this.gpbPaths.Controls.Add(this.textBox3);
            this.gpbPaths.Controls.Add(this.textBox2);
            this.gpbPaths.Controls.Add(this.textBox1);
            this.gpbPaths.Controls.Add(this.lbEFGPath);
            this.gpbPaths.Controls.Add(this.lbPBGPath);
            this.gpbPaths.Controls.Add(this.lbNBGPath);
            this.gpbPaths.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.gpbPaths.Location = new System.Drawing.Point(10, 20);
            this.gpbPaths.Name = "gpbPaths";
            this.gpbPaths.Size = new System.Drawing.Size(650, 150);
            this.gpbPaths.TabIndex = 0;
            this.gpbPaths.TabStop = false;
            this.gpbPaths.Text = "Mock Paths";
            // 
            // lbOLISPath
            // 
            this.lbOLISPath.AutoSize = true;
            this.lbOLISPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lbOLISPath.Location = new System.Drawing.Point(13, 125);
            this.lbOLISPath.Name = "lbOLISPath";
            this.lbOLISPath.Size = new System.Drawing.Size(102, 13);
            this.lbOLISPath.TabIndex = 7;
            this.lbOLISPath.Text = "PBG OLIS Path :";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.textBox4.Location = new System.Drawing.Point(120, 121);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(513, 20);
            this.textBox4.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.textBox3.Location = new System.Drawing.Point(120, 61);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(513, 20);
            this.textBox3.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.textBox2.Location = new System.Drawing.Point(120, 91);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(513, 20);
            this.textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.textBox1.Location = new System.Drawing.Point(120, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(513, 20);
            this.textBox1.TabIndex = 3;
            // 
            // lbEFGPath
            // 
            this.lbEFGPath.AutoSize = true;
            this.lbEFGPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lbEFGPath.Location = new System.Drawing.Point(13, 65);
            this.lbEFGPath.Name = "lbEFGPath";
            this.lbEFGPath.Size = new System.Drawing.Size(69, 13);
            this.lbEFGPath.TabIndex = 2;
            this.lbEFGPath.Text = "EFG Path :";
            // 
            // lbPBGPath
            // 
            this.lbPBGPath.AutoSize = true;
            this.lbPBGPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lbPBGPath.Location = new System.Drawing.Point(13, 95);
            this.lbPBGPath.Name = "lbPBGPath";
            this.lbPBGPath.Size = new System.Drawing.Size(70, 13);
            this.lbPBGPath.TabIndex = 1;
            this.lbPBGPath.Text = "PBG Path :";
            // 
            // lbNBGPath
            // 
            this.lbNBGPath.AutoSize = true;
            this.lbNBGPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lbNBGPath.Location = new System.Drawing.Point(13, 35);
            this.lbNBGPath.Name = "lbNBGPath";
            this.lbNBGPath.Size = new System.Drawing.Size(71, 13);
            this.lbNBGPath.TabIndex = 0;
            this.lbNBGPath.Text = "NBG Path :";
            // 
            // btnSaveClose
            // 
            this.btnSaveClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnSaveClose.Location = new System.Drawing.Point(427, 179);
            this.btnSaveClose.Name = "btnSaveClose";
            this.btnSaveClose.Size = new System.Drawing.Size(110, 40);
            this.btnSaveClose.TabIndex = 1;
            this.btnSaveClose.Text = "Save && Close";
            this.btnSaveClose.UseVisualStyleBackColor = true;
            this.btnSaveClose.Click += new System.EventHandler(this.btnSaveClose_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnCancel.Location = new System.Drawing.Point(545, 179);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 40);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // SettingsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 227);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSaveClose);
            this.Controls.Add(this.gpbPaths);
            this.Name = "SettingsScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PS VM Management [I.P. : ] - SettingsScreen";
            this.Load += new System.EventHandler(this.SettingsScreen_Load);
            this.gpbPaths.ResumeLayout(false);
            this.gpbPaths.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbPaths;
        private System.Windows.Forms.Label lbOLISPath;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbEFGPath;
        private System.Windows.Forms.Label lbPBGPath;
        private System.Windows.Forms.Label lbNBGPath;
        private System.Windows.Forms.Button btnSaveClose;
        private System.Windows.Forms.Button btnCancel;
    }
}