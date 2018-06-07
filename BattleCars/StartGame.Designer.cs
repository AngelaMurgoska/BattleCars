namespace WindowsFormsApp1
{
    partial class StartGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartGame));
            this.lblName = new System.Windows.Forms.Label();
            this.btnSinglePlayer = new System.Windows.Forms.Button();
            this.lblSinglePlayer = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMultiPlayer = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("High Tower Text", 53.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Orange;
            this.lblName.Location = new System.Drawing.Point(182, 48);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(361, 83);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Battle Cars";
            // 
            // btnSinglePlayer
            // 
            this.btnSinglePlayer.Image = ((System.Drawing.Image)(resources.GetObject("btnSinglePlayer.Image")));
            this.btnSinglePlayer.Location = new System.Drawing.Point(166, 170);
            this.btnSinglePlayer.Name = "btnSinglePlayer";
            this.btnSinglePlayer.Size = new System.Drawing.Size(377, 87);
            this.btnSinglePlayer.TabIndex = 1;
            this.btnSinglePlayer.UseVisualStyleBackColor = true;
            this.btnSinglePlayer.Click += new System.EventHandler(this.btnSinglePlayer_Click);
            // 
            // lblSinglePlayer
            // 
            this.lblSinglePlayer.AutoSize = true;
            this.lblSinglePlayer.BackColor = System.Drawing.Color.Transparent;
            this.lblSinglePlayer.Location = new System.Drawing.Point(126, 143);
            this.lblSinglePlayer.Name = "lblSinglePlayer";
            this.lblSinglePlayer.Size = new System.Drawing.Size(0, 13);
            this.lblSinglePlayer.TabIndex = 3;
            this.lblSinglePlayer.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExit.Location = new System.Drawing.Point(241, 390);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(236, 82);
            this.btnExit.TabIndex = 6;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(781, 574);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btnMultiPlayer
            // 
            this.btnMultiPlayer.Image = ((System.Drawing.Image)(resources.GetObject("btnMultiPlayer.Image")));
            this.btnMultiPlayer.Location = new System.Drawing.Point(166, 281);
            this.btnMultiPlayer.Name = "btnMultiPlayer";
            this.btnMultiPlayer.Size = new System.Drawing.Size(377, 84);
            this.btnMultiPlayer.TabIndex = 2;
            this.btnMultiPlayer.UseVisualStyleBackColor = true;
            this.btnMultiPlayer.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHelp.BackgroundImage")));
            this.btnHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHelp.Image = ((System.Drawing.Image)(resources.GetObject("btnHelp.Image")));
            this.btnHelp.Location = new System.Drawing.Point(573, 36);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(120, 52);
            this.btnHelp.TabIndex = 8;
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.button1_Click);
            // 
            // StartGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 574);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblSinglePlayer);
            this.Controls.Add(this.btnMultiPlayer);
            this.Controls.Add(this.btnSinglePlayer);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.pictureBox1);
            this.Name = "StartGame";
            this.Text = "StartGame";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnSinglePlayer;
        private System.Windows.Forms.Label lblSinglePlayer;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnMultiPlayer;
        private System.Windows.Forms.Button btnHelp;
    }
}