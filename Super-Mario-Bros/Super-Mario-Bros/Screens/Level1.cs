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
        public static Mario mario;
        #endregion

        public Level1()
        {
            InitializeComponent();
            OnStart();
        }

        public static void OnStart()
        {     
            mario = new Mario(3, 390, 2, 2, "big");

            // start the game engine loop
            
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            if (rightArrowDown)
                mario.x++;
        }

        private void gameTimer_Tick_1(object sender, EventArgs e)
        {
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