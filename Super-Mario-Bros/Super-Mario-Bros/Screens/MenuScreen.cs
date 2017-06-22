using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Super_Mario_Bros.Screens
{
    public partial class MenuScreen : UserControl
    {
        Boolean lastArrowDown, leftArrowDown, rightArrowDown, upArrowDown, DownArrowDown, spaceDown;
        int selected, lastSelected;
        public delegate void EnterEventHandler(object source, EventArgs args);

        public event EnterEventHandler ButtonEntered;

        private void MenuScreen_Load(object sender, EventArgs e)
        {
            //playButton.Focus();
        }

        #region Button Events
        private void playButton_Click(object sender, EventArgs e)
        {
            // Goes to the game screen
            Level1 l1 = new Level1();
            Form form = this.FindForm();

            l1.Location = new Point((form.Width - l1.Width) / 2, (form.Height - l1.Height) / 2);

            form.Controls.Add(l1);
            form.Controls.Remove(this);
        }

        private void scoresButton_Click(object sender, EventArgs e)
        {
            // Goes to the score screen
            ScoreScreen ss = new ScoreScreen();
            Form form = this.FindForm();

            ss.Location = new Point((form.Width - ss.Width) / 2, (form.Height - ss.Height) / 2);

            form.Controls.Add(ss);
            form.Controls.Remove(this);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void playButton_Enter(object sender, EventArgs e)
        {
            playButton.ForeColor = Color.Red;
            scoresButton.ForeColor = exitButton.ForeColor = Color.Blue;
        }


        private void scoresButton_Enter(object sender, EventArgs e)
        {
            scoresButton.ForeColor = Color.Red;
            exitButton.ForeColor = playButton.ForeColor = Color.Blue;
        }

        private void exitButton_Enter(object sender, EventArgs e)
        {
            exitButton.ForeColor = Color.Red;
            playButton.ForeColor = scoresButton.ForeColor = Color.Blue;
        }
        #endregion


        public MenuScreen()
        {
            InitializeComponent();
        }

        private void MenuScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            // Get the last selected
            lastSelected = selected;


            if (leftArrowDown || rightArrowDown)
                lastArrowDown = true;
            else
                lastArrowDown = false;


            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = true;
                    break;
                case Keys.Right:
                    rightArrowDown = true;
                    break;
                case Keys.Up:
                    upArrowDown = true;
                    break;
                case Keys.Down:
                    DownArrowDown = true;
                    break;
                case Keys.Space:
                    spaceDown = true;
                    break;
                default:
                    break;
            }

            if (lastArrowDown == false)
            {
                if (rightArrowDown == true)
                {
                    if (selected == 2)
                    {
                        selected = 0;
                    }
                    else
                    {
                        selected++;
                    }
                }

                if (leftArrowDown == true)
                {
                    if (selected == 0)
                    {
                        selected = 2;
                    }
                    else
                    {
                        selected--;
                    }
                }

                switch (selected)
                {
                    case 0:
                        playLabel.ForeColor = Color.Red;
                        pointer.Location = new Point(152, 403);

                        if (spaceDown == true)
                        {
                            // Goes to the game screen
                            Level1 l1 = new Level1();
                            Form form = this.FindForm();

                            l1.Location = new Point((form.Width - l1.Width) / 2, (form.Height - l1.Height) / 2);

                            form.Controls.Add(l1);
                            form.Controls.Remove(this);
                        }

                        break;

                    case 1:
                        scoresLabel.ForeColor = Color.Red;
                        pointer.Location = new Point(362, 301);

                        if (spaceDown == true)
                        {
                            // Goes to the score screen
                            ScoreScreen ss = new ScoreScreen();
                            Form form = this.FindForm();

                            ss.Location = new Point((form.Width - ss.Width) / 2, (form.Height - ss.Height) / 2);

                            form.Controls.Add(ss);
                            form.Controls.Remove(this);
                        }

                        break;

                    case 2:
                        exitLabel.ForeColor = Color.Red;
                        pointer.Location = new Point(615, 403);

                        if (spaceDown == true)
                            Application.Exit();

                        break;
                }

                if (selected != lastSelected)
                {
                    switch (lastSelected)
                    {
                        case 0:
                            playLabel.ForeColor = Color.Blue;
                            break;

                        case 1:
                            scoresLabel.ForeColor = Color.Blue;
                            break;

                        case 2:
                            exitLabel.ForeColor = Color.Blue;
                            break;
                    }
                }
            }
        }

        private void MenuScreen_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = false;
                    break;
                case Keys.Right:
                    rightArrowDown = false;
                    break;
                case Keys.Space:
                    spaceDown = false;
                    break;
                default:
                    break;
            }
        }
    }
}
