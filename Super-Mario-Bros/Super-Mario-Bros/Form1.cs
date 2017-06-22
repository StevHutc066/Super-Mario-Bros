using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using System.Media;

namespace Super_Mario_Bros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static List<Classes.Highscores> highscoreList = new List<Classes.Highscores>();
        public static int currentScore = 0;
        public static Label scoreLabel = new Label();
        public static Label timeLabel = new Label();

        //Sounds
        public static System.Windows.Media.MediaPlayer buttonSound;
        public static System.Windows.Media.MediaPlayer coinSound;
        public static System.Windows.Media.MediaPlayer enterLevelSound;
        public static System.Windows.Media.MediaPlayer jumpSound;
        public static System.Windows.Media.MediaPlayer levelClearSound;
        public static System.Windows.Media.MediaPlayer lifeLossSound;
        public static System.Windows.Media.MediaPlayer oneUpSound;
        public static System.Windows.Media.MediaPlayer pauseSound;
        public static System.Windows.Media.MediaPlayer powerUpSound;
        public static System.Windows.Media.MediaPlayer runningOutOfTimeSound;
        public static System.Windows.Media.MediaPlayer kickingSound;
        public static System.Windows.Media.MediaPlayer battleSound;

        


        private void Form1_Load(object sender, EventArgs e)
        {
            Level1.MakePlayer(buttonSound, "Button.wav");

            CreateLabel(scoreLabel, new Point(520, this.Height - scoreLabel.Height * 3));
            
            CreateLabel(timeLabel, new Point(330, this.Height - timeLabel.Height * 3));

            #region Screen Change to MenuScreen
            Screens.MenuScreen ms = new Screens.MenuScreen();
            this.Controls.Add(ms);
            ms.Location = new Point((this.Width - ms.Width) / 2, (this.Height - ms.Height) / 2);
            #endregion

            LoadHighscores();
        }

        private void CreateLabel(Label l, Point p)
        {
            Controls.Add(l);
            l.Font = new Font("Kozuka Gothic Pro", 20, FontStyle.Bold);
            l.AutoSize = true;
            l.BackColor = Color.Transparent;
            l.ForeColor = Color.White;
            l.Location = p;
        }

        private void LoadHighscores() // Method for loading any saved highscores in the highscoreDB XML file
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("highscoreDB.xml");

            XmlNode parent;
            parent = doc.DocumentElement;
            foreach (XmlNode child in parent.ChildNodes)
            {
                Classes.Highscores hs = new Classes.Highscores(null, null);
                foreach (XmlNode grandChild in child.ChildNodes)
                {
                    if (grandChild.Name == "name")
                    {
                        hs.name = grandChild.InnerText;
                    }
                    if (grandChild.Name == "score")
                    {
                        hs.score = grandChild.InnerText;
                    }
                }

                highscoreList.Add(hs);
            }
        }
    }
}
