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
        Boolean lastArrowDown, leftArrowDown, rightArrowDown, spaceDown;
        int selected, lastSelected;

        public MenuScreen()
        {
            InitializeComponent();
        }

        private void MenuScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
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
                        playButton.ForeColor = Color.Red;

                        if (spaceDown == true)
                        {
                            // Goes to the game screen
                            Level1 l1 = new Level1();
                            Form form = this.FindForm();

                            l1.Location = new Point((this.Width - l1.Width) / 2, (this.Height - l1.Height) / 2);

                            form.Controls.Add(l1);
                            form.Controls.Remove(this); 
                        }

                        break;

                    case 1:
                        scoresButton.ForeColor = Color.Red;

                        if (spaceDown == true)
                        {
                            // Goes to the score screen
                            Form form = this.FindForm();
                            ScoreScreen ss = new ScoreScreen();

                            ss.Location = new Point((this.Width - ss.Width) / 2, (this.Height - ss.Height) / 2);

                            form.Controls.Add(ss);
                            form.Controls.Remove(this);
                        }

                        break;

                    case 2:
                        exitButton.ForeColor = Color.Red;

                        if (spaceDown == true)
                        {
                            Application.Exit();
                        }

                        break;
                }

                if (selected != lastSelected)
                {
                    switch (lastSelected)
                    {
                        case 0:
                            playButton.ForeColor = Color.Blue;
                            break;

                        case 1:
                            scoresButton.ForeColor = Color.Blue;
                            break;

                        case 2:
                            exitButton.ForeColor = Color.Blue;
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
