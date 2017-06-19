namespace Super_Mario_Bros.Screens
{
    partial class GameOverScreen
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
            this.gameOverLabel = new System.Windows.Forms.Label();
            this.pointsLabel = new System.Windows.Forms.Label();
            this.nameText1 = new System.Windows.Forms.Label();
            this.nameText2 = new System.Windows.Forms.Label();
            this.nameText3 = new System.Windows.Forms.Label();
            this.menuButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gameOverLabel
            // 
            this.gameOverLabel.AutoSize = true;
            this.gameOverLabel.BackColor = System.Drawing.Color.Transparent;
            this.gameOverLabel.Font = new System.Drawing.Font("OCR A Std", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameOverLabel.ForeColor = System.Drawing.Color.White;
            this.gameOverLabel.Location = new System.Drawing.Point(279, 15);
            this.gameOverLabel.Name = "gameOverLabel";
            this.gameOverLabel.Size = new System.Drawing.Size(443, 68);
            this.gameOverLabel.TabIndex = 0;
            this.gameOverLabel.Text = "GAME OVER";
            // 
            // pointsLabel
            // 
            this.pointsLabel.BackColor = System.Drawing.Color.Transparent;
            this.pointsLabel.Font = new System.Drawing.Font("Sitka Small", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pointsLabel.ForeColor = System.Drawing.Color.White;
            this.pointsLabel.Location = new System.Drawing.Point(360, 161);
            this.pointsLabel.Name = "pointsLabel";
            this.pointsLabel.Size = new System.Drawing.Size(496, 71);
            this.pointsLabel.TabIndex = 1;
            this.pointsLabel.Text = "15367 Points";
            this.pointsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nameText1
            // 
            this.nameText1.AutoSize = true;
            this.nameText1.BackColor = System.Drawing.Color.Transparent;
            this.nameText1.Font = new System.Drawing.Font("Sitka Small", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameText1.ForeColor = System.Drawing.Color.Red;
            this.nameText1.Location = new System.Drawing.Point(145, 161);
            this.nameText1.Name = "nameText1";
            this.nameText1.Size = new System.Drawing.Size(63, 71);
            this.nameText1.TabIndex = 6;
            this.nameText1.Text = "A";
            this.nameText1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameText2
            // 
            this.nameText2.AutoSize = true;
            this.nameText2.BackColor = System.Drawing.Color.Transparent;
            this.nameText2.Font = new System.Drawing.Font("Sitka Small", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameText2.ForeColor = System.Drawing.Color.White;
            this.nameText2.Location = new System.Drawing.Point(212, 161);
            this.nameText2.Name = "nameText2";
            this.nameText2.Size = new System.Drawing.Size(63, 71);
            this.nameText2.TabIndex = 7;
            this.nameText2.Text = "A";
            this.nameText2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameText3
            // 
            this.nameText3.AutoSize = true;
            this.nameText3.BackColor = System.Drawing.Color.Transparent;
            this.nameText3.Font = new System.Drawing.Font("Sitka Small", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameText3.ForeColor = System.Drawing.Color.White;
            this.nameText3.Location = new System.Drawing.Point(279, 161);
            this.nameText3.Name = "nameText3";
            this.nameText3.Size = new System.Drawing.Size(63, 71);
            this.nameText3.TabIndex = 8;
            this.nameText3.Text = "A";
            this.nameText3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuButton
            // 
            this.menuButton.BackColor = System.Drawing.Color.Transparent;
            this.menuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuButton.Font = new System.Drawing.Font("Sitka Small", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuButton.ForeColor = System.Drawing.Color.White;
            this.menuButton.Location = new System.Drawing.Point(392, 428);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(217, 81);
            this.menuButton.TabIndex = 9;
            this.menuButton.Text = "Menu";
            this.menuButton.UseVisualStyleBackColor = false;
            // 
            // GameOverScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.nameText3);
            this.Controls.Add(this.nameText2);
            this.Controls.Add(this.nameText1);
            this.Controls.Add(this.pointsLabel);
            this.Controls.Add(this.gameOverLabel);
            this.Name = "GameOverScreen";
            this.Size = new System.Drawing.Size(1000, 600);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gameOverLabel;
        private System.Windows.Forms.Label pointsLabel;
        private System.Windows.Forms.Label nameText1;
        private System.Windows.Forms.Label nameText2;
        private System.Windows.Forms.Label nameText3;
        private System.Windows.Forms.Button menuButton;
    }
}
