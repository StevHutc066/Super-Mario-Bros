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
    public partial class LoseScreen : UserControl
    {
        Boolean lastArrowDown, leftArrowDown, downArrowDown, rightArrowDown, upArrowDown, spaceDown;
        int index1, index2, index3, selected, lastSelected;

        private void LoseScreen_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = false;
                    break;
                case Keys.Down:
                    downArrowDown = false;
                    break;
                case Keys.Right:
                    rightArrowDown = false;
                    break;
                case Keys.Up:
                    upArrowDown = false;
                    break;
                case Keys.Space:
                    spaceDown = false;
                    break;
                default:
                    break;
            }
        }

        private void LoseScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            lastSelected = selected;

            if (leftArrowDown || rightArrowDown)
            {
                lastArrowDown = true;
            }
            else
            {
                lastArrowDown = false;
            }

            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = true;
                    break;
                case Keys.Down:
                    downArrowDown = true;
                    break;
                case Keys.Right:
                    rightArrowDown = true;
                    break;
                case Keys.Up:
                    upArrowDown = true;
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
                    if (selected == 3)
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
                        selected = 3;
                    }
                    else
                    {
                        selected--;
                    }
                }
            }

            switch (selected)
            {
                case 0:
                    nameText1.ForeColor = Color.Red;
                    pointer1.Location = new Point(56, 222);
                    pointer2.Location = new Point(56, 379);

                    if (upArrowDown == true)
                    {
                        index1++;

                        if (index1 == 26)
                        {
                            index1 = 0;
                        }
                    }

                    if (downArrowDown == true)
                    {
                        index1--;

                        if (index1 == -1)
                        {
                            index1 = 25;
                        }
                    }
                    break;

                case 1:
                    nameText2.ForeColor = Color.Red;
                    pointer1.Location = new Point(157, 222);
                    pointer2.Location = new Point(157, 379);

                    if (upArrowDown == true)
                    {
                        index2++;

                        if (index2 == 26)
                        {
                            index2 = 0;
                        }
                    }

                    if (downArrowDown == true)
                    {
                        index2--;

                        if (index2 == -1)
                        {
                            index2 = 25;
                        }
                    }
                    break;

                case 2:
                    nameText3.ForeColor = Color.Red;
                    pointer1.Location = new Point(258, 222);
                    pointer2.Location = new Point(258, 379);                  

                    if (upArrowDown == true)
                    {
                        index3++;

                        if (index3 == 26)
                        {
                            index3 = 0;
                        }
                    }

                    if (downArrowDown == true)
                    {
                        index3--;

                        if (index3 == -1)
                        {
                            index3 = 25;
                        }
                    }
                    break;

                case 3:
                    menuButton.ForeColor = Color.Red;
                    pointer.Visible = true;
                    pointer1.Visible = pointer2.Visible = false;

                    if (spaceDown == true)
                    {
                        Classes.Highscores hs = new Classes.Highscores(nameText1.Text + nameText2.Text + nameText3.Text, Convert.ToString(Form1.currentScore));
                        hs.save(hs);
                        hs.saveScores(Form1.highscoreList);

                        MenuScreen ms = new MenuScreen();
                        Form form = this.FindForm();

                        ms.Location = new Point((form.Width - ms.Width) / 2, (form.Height - ms.Height) / 2);

                        form.Controls.Add(ms);
                        form.Controls.Remove(this);
                    }
                    break;
            }

            if (selected != lastSelected)
            {
                switch (lastSelected)
                {
                    case 0:
                        nameText1.ForeColor = Color.Blue;
                        break;

                    case 1:
                        nameText2.ForeColor = Color.Blue;
                        break;

                    case 2:
                        nameText3.ForeColor = Color.Blue;
                        break;

                    case 3:
                        menuButton.ForeColor = Color.Blue;
                        pointer.Visible = false;
                        pointer1.Visible = pointer2.Visible = true;
                        break;
                }
            }

            switch (index1)
            {
                case 0:
                    nameText1.Text = "A";
                    break;
                case 1:
                    nameText1.Text = "B";
                    break;
                case 2:
                    nameText1.Text = "C";
                    break;
                case 3:
                    nameText1.Text = "D";
                    break;
                case 4:
                    nameText1.Text = "E";
                    break;
                case 5:
                    nameText1.Text = "F";
                    break;
                case 6:
                    nameText1.Text = "G";
                    break;
                case 7:
                    nameText1.Text = "H";
                    break;
                case 8:
                    nameText1.Text = "I";
                    break;
                case 9:
                    nameText1.Text = "J";
                    break;
                case 10:
                    nameText1.Text = "K";
                    break;
                case 11:
                    nameText1.Text = "L";
                    break;
                case 12:
                    nameText1.Text = "M";
                    break;
                case 13:
                    nameText1.Text = "N";
                    break;
                case 14:
                    nameText1.Text = "O";
                    break;
                case 15:
                    nameText1.Text = "P";
                    break;
                case 16:
                    nameText1.Text = "Q";
                    break;
                case 17:
                    nameText1.Text = "R";
                    break;
                case 18:
                    nameText1.Text = "S";
                    break;
                case 19:
                    nameText1.Text = "T";
                    break;
                case 20:
                    nameText1.Text = "U";
                    break;
                case 21:
                    nameText1.Text = "V";
                    break;
                case 22:
                    nameText1.Text = "W";
                    break;
                case 23:
                    nameText1.Text = "X";
                    break;
                case 24:
                    nameText1.Text = "Y";
                    break;
                case 25:
                    nameText1.Text = "Z";
                    break;
            }

            switch (index2)
            {
                case 0:
                    nameText2.Text = "A";
                    break;
                case 1:
                    nameText2.Text = "B";
                    break;
                case 2:
                    nameText2.Text = "C";
                    break;
                case 3:
                    nameText2.Text = "D";
                    break;
                case 4:
                    nameText2.Text = "E";
                    break;
                case 5:
                    nameText2.Text = "F";
                    break;
                case 6:
                    nameText2.Text = "G";
                    break;
                case 7:
                    nameText2.Text = "H";
                    break;
                case 8:
                    nameText2.Text = "I";
                    break;
                case 9:
                    nameText2.Text = "J";
                    break;
                case 10:
                    nameText2.Text = "K";
                    break;
                case 11:
                    nameText2.Text = "L";
                    break;
                case 12:
                    nameText2.Text = "M";
                    break;
                case 13:
                    nameText2.Text = "N";
                    break;
                case 14:
                    nameText2.Text = "O";
                    break;
                case 15:
                    nameText2.Text = "P";
                    break;
                case 16:
                    nameText2.Text = "Q";
                    break;
                case 17:
                    nameText2.Text = "R";
                    break;
                case 18:
                    nameText2.Text = "S";
                    break;
                case 19:
                    nameText2.Text = "T";
                    break;
                case 20:
                    nameText2.Text = "U";
                    break;
                case 21:
                    nameText2.Text = "V";
                    break;
                case 22:
                    nameText2.Text = "W";
                    break;
                case 23:
                    nameText2.Text = "X";
                    break;
                case 24:
                    nameText2.Text = "Y";
                    break;
                case 25:
                    nameText2.Text = "Z";
                    break;
            }

            switch (index3)
            {
                case 0:
                    nameText3.Text = "A";
                    break;
                case 1:
                    nameText3.Text = "B";
                    break;
                case 2:
                    nameText3.Text = "C";
                    break;
                case 3:
                    nameText3.Text = "D";
                    break;
                case 4:
                    nameText3.Text = "E";
                    break;
                case 5:
                    nameText3.Text = "F";
                    break;
                case 6:
                    nameText3.Text = "G";
                    break;
                case 7:
                    nameText3.Text = "H";
                    break;
                case 8:
                    nameText3.Text = "I";
                    break;
                case 9:
                    nameText3.Text = "J";
                    break;
                case 10:
                    nameText3.Text = "K";
                    break;
                case 11:
                    nameText3.Text = "L";
                    break;
                case 12:
                    nameText3.Text = "M";
                    break;
                case 13:
                    nameText3.Text = "N";
                    break;
                case 14:
                    nameText3.Text = "O";
                    break;
                case 15:
                    nameText3.Text = "P";
                    break;
                case 16:
                    nameText3.Text = "Q";
                    break;
                case 17:
                    nameText3.Text = "R";
                    break;
                case 18:
                    nameText3.Text = "S";
                    break;
                case 19:
                    nameText3.Text = "T";
                    break;
                case 20:
                    nameText3.Text = "U";
                    break;
                case 21:
                    nameText3.Text = "V";
                    break;
                case 22:
                    nameText3.Text = "W";
                    break;
                case 23:
                    nameText3.Text = "X";
                    break;
                case 24:
                    nameText3.Text = "Y";
                    break;
                case 25:
                    nameText3.Text = "Z";
                    break;
            }
        }        

        public LoseScreen()
        {
            InitializeComponent();
        }
    }
}
