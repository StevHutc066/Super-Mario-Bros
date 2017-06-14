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

namespace Super_Mario_Bros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            XmlTextWriter writer = new XmlTextWriter("highscoreDB.xml", null);
        }

        public static List<Classes.Highscores> highscoreList = new List<Classes.Highscores>();
        public static int currentScore;

        private void Form1_Load(object sender, EventArgs e)
        {
            Screens.LoseScreen ms = new Screens.LoseScreen();

            this.Controls.Add(ms);

            ms.Location = new Point((this.Width - ms.Width) / 2, (this.Height - ms.Height) / 2);     
        }
    }
}
