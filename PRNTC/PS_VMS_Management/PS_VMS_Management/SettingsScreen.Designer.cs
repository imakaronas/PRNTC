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
            this.gpbPaths.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
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
            this.lbOLISPath.Location = new System.Drawing.Point(13, 120);
            this.lbOLISPath.Name = "lbOLISPath";
            this.lbOLISPath.Size = new System.Drawing.Size(65, 13);
            this.lbOLISPath.TabIndex = 7;
            this.lbOLISPath.Text = "OLIS Path";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.textBox4.Location = new System.Drawing.Point(93, 116);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(540, 20);
            this.textBox4.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.textBox3.Location = new System.Drawing.Point(93, 86);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(540, 20);
            this.textBox3.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.textBox2.Location = new System.Drawing.Point(93, 56);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(540, 20);
            this.textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.textBox1.Location = new System.Drawing.Point(93, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(540, 20);
            this.textBox1.TabIndex = 3;
            // 
            // lbEFGPath
            // 
            this.lbEFGPath.AutoSize = true;
            this.lbEFGPath.Location = new System.Drawing.Point(13, 90);
            this.lbEFGPath.Name = "lbEFGPath";
            this.lbEFGPath.Size = new System.Drawing.Size(61, 13);
            this.lbEFGPath.TabIndex = 2;
            this.lbEFGPath.Text = "EFG Path";
            // 
            // lbPBGPath
            // 
            this.lbPBGPath.AutoSize = true;
            this.lbPBGPath.Location = new System.Drawing.Point(13, 60);
            this.lbPBGPath.Name = "lbPBGPath";
            this.lbPBGPath.Size = new System.Drawing.Size(62, 13);
            this.lbPBGPath.TabIndex = 1;
            this.lbPBGPath.Text = "PBG Path";
            // 
            // lbNBGPath
            // 
            this.lbNBGPath.AutoSize = true;
            this.lbNBGPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lbNBGPath.Location = new System.Drawing.Point(13, 30);
            this.lbNBGPath.Name = "lbNBGPath";
            this.lbNBGPath.Size = new System.Drawing.Size(63, 13);
            this.lbNBGPath.TabIndex = 0;
            this.lbNBGPath.Text = "NBG Path";
            // 
            // SettingsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 196);
            this.Controls.Add(this.gpbPaths);
            this.Name = "SettingsScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SettingsScreen";
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
    }
}