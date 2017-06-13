using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Super_Mario_Bros
{
    public partial class Level1 : UserControl
    {
        #region Declarations
        Boolean leftArrowDown, downArrowDown, rightArrowDown, upArrowDown, spaceDown, escapeDown;
        static int lives;
        public static Mario mario;
        #endregion


        private void Level1_KeyUp(object sender, KeyEventArgs e)
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
                case Keys.Escape:
                    escapeDown = false;
                    break;
                default:
                    break;
            }
        }

        public Level1()
        {
            InitializeComponent();
            OnStart();
        }


        public void OnStart()
        {     
            mario = new Mario(3, 415, 2, 2, "big");

            // start the game engine loop
            gameTimer.Enabled = true;
            
            //set life counter
            lives = 3;

        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            if (rightArrowDown && mario.x <= this.Width)
            {
                mario.Move("right");
            }
            else if (leftArrowDown && mario.x >= 0)
            {
                mario.Move("left");
            }
            //if (rightArrowDown)
                //mario.x++;
            Refresh();
        }

        private void Level1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(Mario.image, mario.x, mario.y, mario.width, mario.height);
        }

        private void Level1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
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
                case Keys.Escape:
                    escapeDown = true;
                    break;
                default:
                    break;
            }
        }

    }
}