namespace Super_Mario_Bros.Screens
{
    partial class LoseScreen
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
            this.pointsOutput = new System.Windows.Forms.Label();
            this.nameText3 = new System.Windows.Forms.Label();
            this.nameText2 = new System.Windows.Forms.Label();
            this.nameText1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gameOverLabel
            // 
            this.gameOverLabel.AutoSize = true;
            this.gameOverLabel.BackColor = System.Drawing.Color.Transparent;
            this.gameOverLabel.Font = new System.Drawing.Font("Papyrus", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameOverLabel.ForeColor = System.Drawing.Color.Maroon;
            this.gameOverLabel.Location = new System.Drawing.Point(295, 34);
            this.gameOverLabel.Name = "gameOverLabel";
            this.gameOverLabel.Size = new System.Drawing.Size(410, 76);
            this.gameOverLabel.TabIndex = 0;
            this.gameOverLabel.Text = "GAME OVER";
            // 
            // pointsOutput
            // 
            this.pointsOutput.BackColor = System.Drawing.Color.Transparent;
            this.pointsOutput.Font = new System.Drawing.Font("Papyrus", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pointsOutput.ForeColor = System.Drawing.Color.Maroon;
            this.pointsOutput.Location = new System.Drawing.Point(395, 262);
            this.pointsOutput.Name = "pointsOutput";
            this.pointsOutput.Size = new System.Drawing.Size(590, 76);
            this.pointsOutput.TabIndex = 1;
            this.pointsOutput.Text = "Score: 12345";
            // 
            // nameText3
            // 
            this.nameText3.AutoSize = true;
            this.nameText3.BackColor = System.Drawing.Color.Transparent;
            this.nameText3.Font = new System.Drawing.Font("Papyrus", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameText3.ForeColor = System.Drawing.Color.Maroon;
            this.nameText3.Location = new System.Drawing.Point(261, 274);
            this.nameText3.Name = "nameText3";
            this.nameText3.Size = new System.Drawing.Size(61, 58);
            this.nameText3.TabIndex = 8;
            this.nameText3.Text = "A";
            this.nameText3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameText2
            // 
            this.nameText2.AutoSize = true;
            this.nameText2.BackColor = System.Drawing.Color.Transparent;
            this.nameText2.Font = new System.Drawing.Font("Papyrus", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameText2.ForeColor = System.Drawing.Color.Maroon;
            this.nameText2.Location = new System.Drawing.Point(194, 274);
            this.nameText2.Name = "nameText2";
            this.nameText2.Size = new System.Drawing.Size(61, 58);
            this.nameText2.TabIndex = 7;
            this.nameText2.Text = "A";
            this.nameText2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameText1
            // 
            this.nameText1.AutoSize = true;
            this.nameText1.BackColor = System.Drawing.Color.Transparent;
            this.nameText1.Font = new System.Drawing.Font("Papyrus", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameText1.ForeColor = System.Drawing.Color.White;
            this.nameText1.Location = new System.Drawing.Point(127, 274);
            this.nameText1.Name = "nameText1";
            this.nameText1.Size = new System.Drawing.Size(61, 58);
            this.nameText1.TabIndex = 6;
            this.nameText1.Text = "A";
            this.nameText1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Papyrus", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(769, 476);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 100);
            this.label1.TabIndex = 9;
            this.label1.Text = "Menu";
            // 
            // LoseScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameText3);
            this.Controls.Add(this.nameText2);
            this.Controls.Add(this.nameText1);
            this.Controls.Add(this.pointsOutput);
            this.Controls.Add(this.gameOverLabel);
            this.Name = "LoseScreen";
            this.Size = new System.Drawing.Size(1000, 600);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gameOverLabel;
        private System.Windows.Forms.Label pointsOutput;
        private System.Windows.Forms.Label nameText3;
        private System.Windows.Forms.Label nameText2;
        private System.Windows.Forms.Label nameText1;
        private System.Windows.Forms.Label label1;
    }
}
