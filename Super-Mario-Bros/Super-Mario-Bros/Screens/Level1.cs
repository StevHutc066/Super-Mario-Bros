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
using System.IO;
using System.Threading;
using System.Windows.Media;

namespace Super_Mario_Bros
{
    public partial class Level1 : UserControl
    {
        #region Variables
        Boolean leftArrowDown, downArrowDown, rightArrowDown, upArrowDown, spaceDown, escapeDown, jump, gameOn, lastDirRight, leftMove = true;
        static int lives, gravity, force, fallSpeed, enemyIndex;
        public long gameTime = 0;
        public static Mario mario;
        public static Enemy enemy;
        Graphics g;
        Animation walkRightAnimation, walkLeftAnimation;
        List<Enemy> enemies = new List<Enemy>();
        List<Image> images = new List<Image>();
        SoundPlayer startSound = new SoundPlayer(Sounds.Battle);
        #endregion

        public Level1()
        {
            InitializeComponent();
            OnStart();
        }

        public void OnStart()
        {
            //Clears the enemy list
            enemies.Clear();

            // Creates a new Mario character at start
            mario = new Mario(3, 415, 3, 3, "big");

            // Creates a gumba
            Enemy goomba = new Enemy(800, 430, 67, 80, 3, 3, Sprites.Goomba);

            // Adds enemies into list
            enemies.Add(goomba);

            // Creates new animation
            walkRightAnimation = new Animation(new Bitmap[] { Sprites.StandRight, Sprites.FirstWalkRight });

            // Starts the game logic
            gameTimer.Enabled = true;

            // Resets lives
            lives = 3;

            // Gravity of player
            gravity = 20;

            // Sets the force
            force = 0;

            // Playing isn't jumping at the start
            jump = false;

            // Sets the speed of falling
            fallSpeed = 3;

            // The game is running
            gameOn = true;

            // Resets game time
            gameTime = 0;

            // Sets visibility for Form1 labels
            Form1.scoreLabel.Visible = true;
            Form1.timeLabel.Visible = true;

            // Graphics object
            g = this.CreateGraphics();

            // Resets current score
            Form1.currentScore = 0;

            #region Sounds
            // Soudnds
            //Form1.kickingSound = new System.Windows.Media.MediaPlayer();
            //Form1.kickingSound.Open(new Uri(Application.StartupPath + "/Resources/KickingSound.wav"));

            Form1.enterLevelSound = MakePlayer(Form1.enterLevelSound, "EnterLevel.wav");
            Form1.jumpSound = MakePlayer(Form1.jumpSound, "Jump.wav");
            Form1.levelClearSound = MakePlayer(Form1.levelClearSound, "LevelClear.wav");
            Form1.lifeLossSound = MakePlayer(Form1.lifeLossSound, "LifeLoss.wav");
            Form1.oneUpSound = MakePlayer(Form1.oneUpSound, "OneUp.wav");
            Form1.pauseSound = MakePlayer(Form1.pauseSound, "Pause.wav");
            Form1.powerUpSound = MakePlayer(Form1.powerUpSound, "PowerUp.wav");
            Form1.runningOutOfTimeSound = MakePlayer(Form1.runningOutOfTimeSound, "RunningOutOfTime.wav");
            //Form1.buttonSound = MakePlayer(Form1.enterLevelSound, "Stomp.wav");
            Form1.kickingSound = MakePlayer(Form1.kickingSound, "KickingSound.wav");
            Form1.battleSound = MakePlayer(Form1.battleSound, "Battle.wav");
            startSound.PlaySync();
        #endregion
    }

        public void OnLose()
        {
            gameTimer.Enabled = false;
            timeTimer.Enabled = false;
            Form1.scoreLabel.Visible = false;
            Form1.timeLabel.Visible = false;
            Screens.LoseScreen ms = new Screens.LoseScreen();
            Form form = this.FindForm();

            ms.Location = new Point((form.Width - ms.Width) / 2, (form.Height - ms.Height) / 2);

            form.Controls.Add(ms);
            form.Controls.Remove(this);
        }

        public void AddEnemy()
        {
            Enemy goomba = new Enemy(800, 430, 67, 80, 3, 3, Sprites.Goomba);
            Thread.Sleep(300);
            enemies.Add(goomba);
        }

        #region Timer Ticks
        private void gameTimer_Tick(object sender, EventArgs e)
        {
            Form1.currentScore++;
            Form1.scoreLabel.Text = "Score: " + Convert.ToString(Form1.currentScore);

            #region Mario Movement
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
                    mario.image = Sprites.StandRight;
                else
                    mario.image = Sprites.StandLeft;
            }
            #endregion

            #region Enemy Movement
            for (int i = 0; i < enemies.Count; i++)
            {
                if (enemies[i] != null)
                    if (enemies[i].x <= 0)
                        leftMove = false;

                if (enemies[i].x >= this.Width - enemies[i].width)
                    leftMove = true;

                if (leftMove == true)
                    enemies[i].Move("left");
                else
                    enemies[i].Move("right");

                if (mario.enemyCollision(enemies[i]))
                {
                    if (!enemies[i].TopCollision(mario))
                    {
                        OnLose();
                        Form1.lifeLossSound.Play();
                    }
                    else 
                    {
                        Form1.kickingSound.Stop();
                        Form1.kickingSound.Play();
                        enemies.Remove(enemies[i]);
                        AddEnemy();
                    }                     
                }
            }       
            #endregion

            if (Form1.currentScore % 250 == 0)
                enemies[0].xSpeed += 1;

            Refresh();
        }

        private void timeTimer_Tick(object sender, EventArgs e)
        {
            gameTime++;
            Form1.timeLabel.Text = "Time: " + Convert.ToString(gameTime);
        }
        #endregion

        #region Key Presses
        private void Level1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = true;
                    lastDirRight = false;
                    if (!jump)
                        mario.image = Sprites.StandLeft;
                    break;
                case Keys.Down:
                    downArrowDown = true;
                    break;
                case Keys.Right:
                    rightArrowDown = true;
                    lastDirRight = true;
                    if (!jump)
                        mario.image = Sprites.StandRight;
                    break;
                case Keys.Space:
                    spaceDown = true;
                    break;
                case Keys.Escape:
                    escapeDown = true;
                    gameTimer.Enabled = false;
                    break;
                case Keys.P:
                    Form1.pauseSound.Stop();
                    Form1.pauseSound.Play();
                    if (gameOn)
                    {              
                        gameOn = false;
                        gameTimer.Stop();
                        timeTimer.Stop();
                        pauseLabel.Text = "Paused";
                        pauseLabel.Visible = true;
                    }
                    else
                    {
                        gameOn = true;
                        gameTimer.Start();
                        timeTimer.Start();
                        pauseLabel.Visible = false;
                        Thread.Sleep(500);
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
                        mario.image = Sprites.JumpRight;
                    }
                    else
                    {
                        mario.image = Sprites.JumpLeft;
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
                        mario.image = Sprites.StandLeft;
                        lastDirRight = false;
                        leftArrowDown = false;
                        break;
                    case Keys.Right:
                        mario.image = Sprites.StandRight;
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
        #endregion

        /// <summary>
        /// Takes a null MediaPlayer and gives it a sound directory link
        /// </summary>
        /// <param name="mp"></param>
        /// <param name="soundName"></param>
        /// <returns>Full initiated media player</returns>
        public static MediaPlayer MakePlayer(MediaPlayer mp, string soundName)
        {
            mp = new MediaPlayer();
            mp.Open(new Uri(Application.StartupPath + "/Resources/" + soundName));
            mp.Volume = 1;
            return mp;
        }

        private void Level1_Paint(object sender, PaintEventArgs e)
        {
            // Draws Mario
            e.Graphics.DrawImage(mario.image, mario.x, mario.y, mario.width, mario.height);

            // Draws enemies
            foreach (Enemy en in enemies)
            {
                e.Graphics.DrawImage(enemies[0].image, enemies[0].x, enemies[0].y, enemies[0].width, enemies[0].height);
            }

        }
    }

}