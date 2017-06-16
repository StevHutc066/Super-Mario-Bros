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
            this.pointer1 = new System.Windows.Forms.PictureBox();
            this.pointer2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pointer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointer2)).BeginInit();
            this.SuspendLayout();
            // 
            // gameOverLabel
            // 
            this.gameOverLabel.BackColor = System.Drawing.Color.Transparent;
            this.gameOverLabel.Font = new System.Drawing.Font("Segoe Script", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameOverLabel.ForeColor = System.Drawing.Color.Blue;
            this.gameOverLabel.Location = new System.Drawing.Point(-1, 0);
            this.gameOverLabel.Name = "gameOverLabel";
            this.gameOverLabel.Size = new System.Drawing.Size(1001, 159);
            this.gameOverLabel.TabIndex = 0;
            this.gameOverLabel.Text = "GAME OVER";
            this.gameOverLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pointsOutput
            // 
            this.pointsOutput.BackColor = System.Drawing.Color.Transparent;
            this.pointsOutput.Font = new System.Drawing.Font("Segoe Script", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pointsOutput.ForeColor = System.Drawing.Color.Blue;
            this.pointsOutput.Location = new System.Drawing.Point(0, 176);
            this.pointsOutput.Name = "pointsOutput";
            this.pointsOutput.Size = new System.Drawing.Size(1000, 76);
            this.pointsOutput.TabIndex = 1;
            this.pointsOutput.Text = "Score: 0";
            this.pointsOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameText3
            // 
            this.nameText3.AutoSize = true;
            this.nameText3.BackColor = System.Drawing.Color.Transparent;
            this.nameText3.Font = new System.Drawing.Font("Segoe Script", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameText3.ForeColor = System.Drawing.Color.Blue;
            this.nameText3.Location = new System.Drawing.Point(554, 369);
            this.nameText3.Name = "nameText3";
            this.nameText3.Size = new System.Drawing.Size(97, 102);
            this.nameText3.TabIndex = 8;
            this.nameText3.Text = "A";
            this.nameText3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameText2
            // 
            this.nameText2.AutoSize = true;
            this.nameText2.BackColor = System.Drawing.Color.Transparent;
            this.nameText2.Font = new System.Drawing.Font("Segoe Script", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameText2.ForeColor = System.Drawing.Color.Blue;
            this.nameText2.Location = new System.Drawing.Point(453, 369);
            this.nameText2.Name = "nameText2";
            this.nameText2.Size = new System.Drawing.Size(97, 102);
            this.nameText2.TabIndex = 7;
            this.nameText2.Text = "A";
            this.nameText2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameText1
            // 
            this.nameText1.AutoSize = true;
            this.nameText1.BackColor = System.Drawing.Color.Transparent;
            this.nameText1.Font = new System.Drawing.Font("Segoe Script", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameText1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.nameText1.Location = new System.Drawing.Point(350, 369);
            this.nameText1.Name = "nameText1";
            this.nameText1.Size = new System.Drawing.Size(97, 102);
            this.nameText1.TabIndex = 6;
            this.nameText1.Text = "A";
            this.nameText1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pointer1
            // 
            this.pointer1.Image = global::Super_Mario_Bros.Properties.Resources.TriangleUp;
            this.pointer1.Location = new System.Drawing.Point(372, 317);
            this.pointer1.Name = "pointer1";
            this.pointer1.Size = new System.Drawing.Size(52, 49);
            this.pointer1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pointer1.TabIndex = 10;
            this.pointer1.TabStop = false;
            // 
            // pointer2
            // 
            this.pointer2.Image = global::Super_Mario_Bros.Properties.Resources.TriangleDown;
            this.pointer2.Location = new System.Drawing.Point(372, 474);
            this.pointer2.Name = "pointer2";
            this.pointer2.Size = new System.Drawing.Size(52, 49);
            this.pointer2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pointer2.TabIndex = 13;
            this.pointer2.TabStop = false;
            // 
            // LoseScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.pointer2);
            this.Controls.Add(this.pointer1);
            this.Controls.Add(this.nameText3);
            this.Controls.Add(this.nameText2);
            this.Controls.Add(this.nameText1);
            this.Controls.Add(this.pointsOutput);
            this.Controls.Add(this.gameOverLabel);
            this.Name = "LoseScreen";
            this.Size = new System.Drawing.Size(1000, 600);
            this.Load += new System.EventHandler(this.LoseScreen_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.LoseScreen_KeyUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.LoseScreen_PreviewKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pointer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointer2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gameOverLabel;
        private System.Windows.Forms.Label pointsOutput;
        private System.Windows.Forms.Label nameText3;
        private System.Windows.Forms.Label nameText2;
        private System.Windows.Forms.Label nameText1;
        private System.Windows.Forms.PictureBox pointer1;
        private System.Windows.Forms.PictureBox pointer2;
    }
}
