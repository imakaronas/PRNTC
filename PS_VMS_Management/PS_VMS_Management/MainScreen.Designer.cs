namespace PS_VMS_Management
{
    partial class MainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnIIStop = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnIISStart = new System.Windows.Forms.Button();
            this.btnIISReset = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnNBG = new System.Windows.Forms.Button();
            this.btnEFG = new System.Windows.Forms.Button();
            this.btnPBG_OLIS = new System.Windows.Forms.Button();
            this.btnPBG = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(358, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(64, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Professional Services Department";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnIIStop);
            this.groupBox1.Controls.Add(this.btnIISStart);
            this.groupBox1.Controls.Add(this.btnIISReset);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.groupBox1.Location = new System.Drawing.Point(10, 157);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 90);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "I.I.S.";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnIIStop
            // 
            this.btnIIStop.ImageIndex = 2;
            this.btnIIStop.ImageList = this.imageList1;
            this.btnIIStop.Location = new System.Drawing.Point(96, 30);
            this.btnIIStop.Name = "btnIIStop";
            this.btnIIStop.Size = new System.Drawing.Size(70, 50);
            this.btnIIStop.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btnIIStop, "Stop IIS");
            this.btnIIStop.UseVisualStyleBackColor = true;
            this.btnIIStop.Click += new System.EventHandler(this.btnIIStop_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Actions-arrow-right-icon.png");
            this.imageList1.Images.SetKeyName(1, "Actions-edit-redo-icon.png");
            this.imageList1.Images.SetKeyName(2, "Button-Close-icon.png");
            this.imageList1.Images.SetKeyName(3, "Button-Play-icon.png");
            this.imageList1.Images.SetKeyName(4, "Button-Refresh-icon.png");
            this.imageList1.Images.SetKeyName(5, "Button-Stop-icon.png");
            this.imageList1.Images.SetKeyName(6, "Programming-Settings-3-icon.png");
            this.imageList1.Images.SetKeyName(7, "settings-icon (1).png");
            this.imageList1.Images.SetKeyName(8, "Settings-icon.png");
            // 
            // btnIISStart
            // 
            this.btnIISStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnIISStart.ImageIndex = 3;
            this.btnIISStart.ImageList = this.imageList1;
            this.btnIISStart.Location = new System.Drawing.Point(20, 30);
            this.btnIISStart.Name = "btnIISStart";
            this.btnIISStart.Size = new System.Drawing.Size(70, 50);
            this.btnIISStart.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btnIISStart, "Start IIS");
            this.btnIISStart.UseVisualStyleBackColor = true;
            this.btnIISStart.Click += new System.EventHandler(this.btnIISStart_Click);
            // 
            // btnIISReset
            // 
            this.btnIISReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnIISReset.ImageIndex = 4;
            this.btnIISReset.ImageList = this.imageList1;
            this.btnIISReset.Location = new System.Drawing.Point(172, 30);
            this.btnIISReset.Name = "btnIISReset";
            this.btnIISReset.Size = new System.Drawing.Size(70, 50);
            this.btnIISReset.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnIISReset, "Restart IIS");
            this.btnIISReset.UseVisualStyleBackColor = true;
            this.btnIISReset.Click += new System.EventHandler(this.btnIISReset_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSettings);
            this.groupBox2.Controls.Add(this.btnNBG);
            this.groupBox2.Controls.Add(this.btnEFG);
            this.groupBox2.Controls.Add(this.btnPBG_OLIS);
            this.groupBox2.Controls.Add(this.btnPBG);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.groupBox2.Location = new System.Drawing.Point(10, 257);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(360, 343);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mocks";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnSettings
            // 
            this.btnSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.ImageIndex = 6;
            this.btnSettings.ImageList = this.imageList1;
            this.btnSettings.Location = new System.Drawing.Point(20, 20);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(100, 40);
            this.btnSettings.TabIndex = 4;
            this.btnSettings.Text = "Settings";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnNBG
            // 
            this.btnNBG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnNBG.Location = new System.Drawing.Point(20, 80);
            this.btnNBG.Name = "btnNBG";
            this.btnNBG.Size = new System.Drawing.Size(320, 53);
            this.btnNBG.TabIndex = 5;
            this.btnNBG.Text = "Start NBG Mock";
            this.btnNBG.UseVisualStyleBackColor = true;
            this.btnNBG.Click += new System.EventHandler(this.btnNBG_Click);
            // 
            // btnEFG
            // 
            this.btnEFG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnEFG.Location = new System.Drawing.Point(20, 140);
            this.btnEFG.Name = "btnEFG";
            this.btnEFG.Size = new System.Drawing.Size(320, 53);
            this.btnEFG.TabIndex = 6;
            this.btnEFG.Text = "Start EFG Mock";
            this.btnEFG.UseVisualStyleBackColor = true;
            this.btnEFG.Click += new System.EventHandler(this.btnEFG_Click);
            // 
            // btnPBG_OLIS
            // 
            this.btnPBG_OLIS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnPBG_OLIS.Location = new System.Drawing.Point(20, 260);
            this.btnPBG_OLIS.Name = "btnPBG_OLIS";
            this.btnPBG_OLIS.Size = new System.Drawing.Size(320, 53);
            this.btnPBG_OLIS.TabIndex = 7;
            this.btnPBG_OLIS.Text = "Start PBG OLIS Mock";
            this.btnPBG_OLIS.UseVisualStyleBackColor = true;
            this.btnPBG_OLIS.Click += new System.EventHandler(this.btnPBG_OLIS_Click);
            // 
            // btnPBG
            // 
            this.btnPBG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnPBG.Location = new System.Drawing.Point(20, 200);
            this.btnPBG.Name = "btnPBG";
            this.btnPBG.Size = new System.Drawing.Size(320, 53);
            this.btnPBG.TabIndex = 8;
            this.btnPBG.Text = "Start PBG Mock";
            this.btnPBG.UseVisualStyleBackColor = true;
            this.btnPBG.Click += new System.EventHandler(this.btnPBG_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "PS VM Management";
            this.notifyIcon.Visible = true;
            this.notifyIcon.BalloonTipClicked += new System.EventHandler(this.Info);
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 610);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MainScreen";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PS VM Management [I.P. : ]";
            this.Load += new System.EventHandler(this.MainScreen_Load);
            this.Resize += new System.EventHandler(this.MainScreen_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnIIStop;
        private System.Windows.Forms.Button btnIISStart;
        private System.Windows.Forms.Button btnIISReset;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnNBG;
        private System.Windows.Forms.Button btnEFG;
        private System.Windows.Forms.Button btnPBG_OLIS;
        private System.Windows.Forms.Button btnPBG;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.NotifyIcon notifyIcon;
    }
}

