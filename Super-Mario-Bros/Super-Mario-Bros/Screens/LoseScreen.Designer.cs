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
            this.menuButton = new System.Windows.Forms.Label();
            this.pointer1 = new System.Windows.Forms.PictureBox();
            this.pointer = new System.Windows.Forms.PictureBox();
            this.pointer2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pointer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointer2)).BeginInit();
            this.SuspendLayout();
            // 
            // gameOverLabel
            // 
            this.gameOverLabel.AutoSize = true;
            this.gameOverLabel.BackColor = System.Drawing.Color.Transparent;
            this.gameOverLabel.Font = new System.Drawing.Font("Segoe Script", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameOverLabel.ForeColor = System.Drawing.Color.Blue;
            this.gameOverLabel.Location = new System.Drawing.Point(245, 34);
            this.gameOverLabel.Name = "gameOverLabel";
            this.gameOverLabel.Size = new System.Drawing.Size(511, 106);
            this.gameOverLabel.TabIndex = 0;
            this.gameOverLabel.Text = "GAME OVER";
            // 
            // pointsOutput
            // 
            this.pointsOutput.BackColor = System.Drawing.Color.Transparent;
            this.pointsOutput.Font = new System.Drawing.Font("Segoe Script", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pointsOutput.ForeColor = System.Drawing.Color.Blue;
            this.pointsOutput.Location = new System.Drawing.Point(367, 274);
            this.pointsOutput.Name = "pointsOutput";
            this.pointsOutput.Size = new System.Drawing.Size(630, 76);
            this.pointsOutput.TabIndex = 1;
            this.pointsOutput.Text = "Score: 12345";
            // 
            // nameText3
            // 
            this.nameText3.AutoSize = true;
            this.nameText3.BackColor = System.Drawing.Color.Transparent;
            this.nameText3.Font = new System.Drawing.Font("Segoe Script", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameText3.ForeColor = System.Drawing.Color.Blue;
            this.nameText3.Location = new System.Drawing.Point(236, 274);
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
            this.nameText2.Location = new System.Drawing.Point(135, 274);
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
            this.nameText1.Location = new System.Drawing.Point(32, 274);
            this.nameText1.Name = "nameText1";
            this.nameText1.Size = new System.Drawing.Size(97, 102);
            this.nameText1.TabIndex = 6;
            this.nameText1.Text = "A";
            this.nameText1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuButton
            // 
            this.menuButton.AutoSize = true;
            this.menuButton.BackColor = System.Drawing.Color.Transparent;
            this.menuButton.Font = new System.Drawing.Font("Segoe Script", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuButton.ForeColor = System.Drawing.Color.Blue;
            this.menuButton.Location = new System.Drawing.Point(383, 483);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(234, 102);
            this.menuButton.TabIndex = 9;
            this.menuButton.Text = "Menu";
            // 
            // pointer1
            // 
            this.pointer1.Image = global::Super_Mario_Bros.Properties.Resources.TriangleUp;
            this.pointer1.Location = new System.Drawing.Point(56, 222);
            this.pointer1.Name = "pointer1";
            this.pointer1.Size = new System.Drawing.Size(52, 49);
            this.pointer1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pointer1.TabIndex = 10;
            this.pointer1.TabStop = false;
            // 
            // pointer
            // 
            this.pointer.BackColor = System.Drawing.Color.Transparent;
            this.pointer.Image = global::Super_Mario_Bros.Properties.Resources.TriangleRight;
            this.pointer.Location = new System.Drawing.Point(327, 510);
            this.pointer.Name = "pointer";
            this.pointer.Size = new System.Drawing.Size(71, 49);
            this.pointer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pointer.TabIndex = 12;
            this.pointer.TabStop = false;
            this.pointer.Visible = false;
            // 
            // pointer2
            // 
            this.pointer2.Image = global::Super_Mario_Bros.Properties.Resources.TriangleDown;
            this.pointer2.Location = new System.Drawing.Point(56, 379);
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
            this.Controls.Add(this.pointer);
            this.Controls.Add(this.pointer1);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.nameText3);
            this.Controls.Add(this.nameText2);
            this.Controls.Add(this.nameText1);
            this.Controls.Add(this.pointsOutput);
            this.Controls.Add(this.gameOverLabel);
            this.Name = "LoseScreen";
            this.Size = new System.Drawing.Size(1000, 600);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.LoseScreen_KeyUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.LoseScreen_PreviewKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pointer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointer)).EndInit();
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
        private System.Windows.Forms.Label menuButton;
        private System.Windows.Forms.PictureBox pointer1;
        private System.Windows.Forms.PictureBox pointer;
        private System.Windows.Forms.PictureBox pointer2;
    }
}
