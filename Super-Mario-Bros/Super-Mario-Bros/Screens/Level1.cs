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
        Boolean leftArrowDown, downArrowDown, rightArrowDown, upArrowDown, spaceDown, escapeDown, jump, gameOn, lastDirRight;
        static int lives, gravity, force, fallSpeed;
        public static Mario mario;
        public static Enemy enemy;
        List<Enemy> enemies = new List<Enemy>();
        List<Image> images = new List<Image>();
        #endregion


        public Level1()
        {
            InitializeComponent();
            OnStart();
        }


        public void OnStart()
        {
            mario = new Mario(3, 415, 3, 3, "big");

            // start the game engine loop
            gameTimer.Enabled = true;

            //set life counter
            lives = 3;

            //Gravity
            gravity = 20;

            //force
            force = 0;

            jump = false;

            fallSpeed = 3;

            gameOn = true;

        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            if (rightArrowDown && (mario.x + mario.width) <= this.Width)
            {
                mario.Move("right");
            }
            else if (leftArrowDown && mario.x >= 0)
            {
                mario.Move("left");
            }
            if (jump)
            {
                mario.y -= force;
                force--;
            }
            if (mario.y + mario.height >= this.Height - 100)
            {
                jump = false;

                if (lastDirRight)
                    mario.image = Sprites.RightStand;
                else
                    mario.image = Sprites.LeftStand;
            }

            //else
            //mario.Fall();
            //Form1.scoreLabel.Text = "Score: 0";
            Refresh();
        }

        private void Level1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(mario.image, mario.x, mario.y, mario.width, mario.height);
        }

        private void Level1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = true;
                    lastDirRight = false;
                    if (!jump)
                        mario.image = Sprites.LeftStand;
                    break;
                case Keys.Down:
                    downArrowDown = true;
                    break;
                case Keys.Right:
                    rightArrowDown = true;
                    lastDirRight = true;
                    if (!jump)
                        mario.image = Sprites.RightStand;
                    break;
                case Keys.Space:
                    spaceDown = true;
                    gameTimer.Enabled = false;

                    Screens.LoseScreen ms = new Screens.LoseScreen();
                    Form form = this.FindForm();

                    ms.Location = new Point((form.Width - ms.Width) / 2, (form.Height - ms.Height) / 2);

                    form.Controls.Add(ms);
                    form.Controls.Remove(this);
                    break;
                case Keys.Escape:
                    escapeDown = true;
                    gameTimer.Enabled = false;
                    break;
                case Keys.P:
                    if (gameOn)
                    {
                        gameOn = false;
                        pauseLabel.Text = "Paused";
                        pauseLabel.Visible = true;
                    }
                    else
                    {
                        gameOn = true;
                        pauseLabel.Visible = false;
                    }
                    break;

            }

            if (e.KeyCode == Keys.Up)
            {
                upArrowDown = true;
                if (!jump)
                {
                    if (lastDirRight)       //Checks direction, changes jump image
                    {
                        mario.image = Sprites.RightJump;
                    }
                    else
                    {
                        mario.image = Sprites.LeftJump;
                    }
                    jump = true;     // Mairo is jumping
                    force = gravity;        //Force to be moved up changes
                }
            }
        }

        private void Level1_KeyUp(object sender, KeyEventArgs e)
        {

            if (gameOn)
            {
                switch (e.KeyCode)
                {
                    case Keys.Left:                             
                        mario.image = Sprites.LeftStand;   
                        lastDirRight = false;                   
                        leftArrowDown = false;             
                        break;
                    case Keys.Right:
                        mario.image = Sprites.RightStand;
                        lastDirRight = true;
                        rightArrowDown = false;
                        break;
                }
            }

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

        //public Boolean NoCollision(Mario mario)
        //{
        //    foreach (Enemy enmy in enemies)

        //        if (enmy != null)
        //        {
        //            Rectangle rect = mario.Bounds();
        //            //if (rect.IntersectsWith(enmy.Bounds))
        //            //{
        //            //    return true;
        //            //}
        //        }
        //    return false;
        //}
    }
}