namespace Super_Mario_Bros.Screens
{
    partial class MenuScreen
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
            this.playButton = new System.Windows.Forms.Button();
            this.scoresButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.DarkTurquoise;
            this.playButton.FlatAppearance.BorderSize = 0;
            this.playButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playButton.Font = new System.Drawing.Font("Segoe Print", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playButton.ForeColor = System.Drawing.Color.Blue;
            this.playButton.Location = new System.Drawing.Point(424, 309);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(151, 59);
            this.playButton.TabIndex = 0;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            this.playButton.Enter += new System.EventHandler(this.playButton_Enter);
            // 
            // scoresButton
            // 
            this.scoresButton.BackColor = System.Drawing.Color.DarkTurquoise;
            this.scoresButton.FlatAppearance.BorderSize = 0;
            this.scoresButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scoresButton.Font = new System.Drawing.Font("Segoe Print", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoresButton.ForeColor = System.Drawing.Color.Blue;
            this.scoresButton.Location = new System.Drawing.Point(424, 377);
            this.scoresButton.Name = "scoresButton";
            this.scoresButton.Size = new System.Drawing.Size(153, 59);
            this.scoresButton.TabIndex = 1;
            this.scoresButton.Text = "Scores";
            this.scoresButton.UseVisualStyleBackColor = false;
            this.scoresButton.Click += new System.EventHandler(this.scoresButton_Click);
            this.scoresButton.Enter += new System.EventHandler(this.scoresButton_Enter);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.DarkTurquoise;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Segoe Print", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.Blue;
            this.exitButton.Location = new System.Drawing.Point(424, 445);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(153, 59);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            this.exitButton.Enter += new System.EventHandler(this.exitButton_Enter);
            // 
            // MenuScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Super_Mario_Bros.Properties.Resources.SuperMarioBros;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.scoresButton);
            this.Controls.Add(this.playButton);
            this.DoubleBuffered = true;
            this.Name = "MenuScreen";
            this.Size = new System.Drawing.Size(1000, 600);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button scoresButton;
        private System.Windows.Forms.Button exitButton;
    }
}
