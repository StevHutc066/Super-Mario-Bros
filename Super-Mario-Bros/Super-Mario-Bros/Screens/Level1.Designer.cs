namespace Super_Mario_Bros.Screens
{
    partial class Level1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.marioBox = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.marioBox)).BeginInit();
            this.SuspendLayout();
            // 
            // marioBox
            // 
            this.marioBox.BackColor = System.Drawing.Color.Transparent;
            this.marioBox.Location = new System.Drawing.Point(3, 395);
            this.marioBox.Name = "marioBox";
            this.marioBox.Size = new System.Drawing.Size(81, 117);
            this.marioBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.marioBox.TabIndex = 0;
            this.marioBox.TabStop = false;
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 13;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // Level1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::Super_Mario_Bros.Properties.Resources.FirstLevelBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.marioBox);
            this.Name = "Level1";
            this.Size = new System.Drawing.Size(1000, 600);
            this.Load += new System.EventHandler(this.Level1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Level1_Paint);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Level1_PreviewKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.marioBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox marioBox;
        private System.Windows.Forms.Timer gameTimer;
    }
}
