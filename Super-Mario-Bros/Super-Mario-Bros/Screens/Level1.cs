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
    public partial class Level1 : UserControl
    {
        Boolean leftArrowDown, downArrowDown, rightArrowDown, upArrowDown, spaceDown, escapeDown;
        Mario Mario;

        public Level1()
        {
            InitializeComponent();
        }

        private void Level1_Load(object sender, EventArgs e)
        {
            OnStart();
        }

        public static void OnStart()
        {
            Mario = new Mario(3, 390, 2, 2, "big");
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            if (rightArrowDown)
                marioBox.Location = new Point(20,20);
        }

        private void Level1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(Properties.Resources.Mario, 1, 390, 81, 117);
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
