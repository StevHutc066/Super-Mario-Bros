namespace Super_Mario_Bros.Screens
{
    partial class ScoreScreen
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
            this.output = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // output
            // 
            this.output.BackColor = System.Drawing.Color.Transparent;
            this.output.Font = new System.Drawing.Font("Segoe Print", 75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Document, ((byte)(0)));
            this.output.ForeColor = System.Drawing.Color.White;
            this.output.Location = new System.Drawing.Point(258, 111);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(582, 424);
            this.output.TabIndex = 0;
            this.output.Text = "AAA, 12345\r\nBBB, 12344\r\nCCC, 12343\r\nDDD, 12342\r\nEEE, 12341\r\nFFF, 12340\r\nGGG, 1233" +
    "9\r\nHHH, 12338\r\nIII, 12337\r\nJJJ, 12336";
            // 
            // ScoreScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Super_Mario_Bros.Properties.Resources.TheHighscoreScreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.output);
            this.Name = "ScoreScreen";
            this.Size = new System.Drawing.Size(1000, 600);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ScoreScreen_KeyUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.ScoreScreen_PreviewKeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label output;
    }
}
