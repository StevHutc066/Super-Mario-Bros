using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Super_Mario_Bros.Screens
{
    public partial class MenuScreen : UserControl
    {
        public MenuScreen()
        {
            InitializeComponent();
        }
        public static SoundPlayer buttonSoundPlayer = new SoundPlayer(Sounds.Button);

        #region Button Events
        private void playButton_Click(object sender, EventArgs e)
        {
            buttonSoundPlayer.PlaySync();

            // Goes to the game screen
            Level1 l1 = new Level1();
            Form form = this.FindForm();

            l1.Location = new Point((form.Width - l1.Width) / 2, (form.Height - l1.Height) / 2);

            form.Controls.Add(l1);
            form.Controls.Remove(this);
            Form1.enterLevelSound.Play();

            
        }

        private void scoresButton_Click(object sender, EventArgs e)
        {
            buttonSoundPlayer.PlaySync();

            // Goes to the score screen
            ScoreScreen ss = new ScoreScreen();
            Form form = this.FindForm();

            ss.Location = new Point((form.Width - ss.Width) / 2, (form.Height - ss.Height) / 2);

            form.Controls.Add(ss);
            form.Controls.Remove(this);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            buttonSoundPlayer.PlaySync();

            // Exits the game
            Application.Exit();
        }

        private void playButton_Enter(object sender, EventArgs e)
        {
            // Makes selected button clear
            playButton.ForeColor = Color.Red;
            scoresButton.ForeColor = exitButton.ForeColor = Color.Blue;
        }

        private void scoresButton_Enter(object sender, EventArgs e)
        {
            // Makes selected button clear
            scoresButton.ForeColor = Color.Red;
            exitButton.ForeColor = playButton.ForeColor = Color.Blue;
        }

        private void exitButton_Enter(object sender, EventArgs e)
        {
            // Makes selected button clear
            exitButton.ForeColor = Color.Red;
            playButton.ForeColor = scoresButton.ForeColor = Color.Blue;
        }
        #endregion
    }
}
