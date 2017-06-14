using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Super_Mario_Bros.Classes
{
    public class Highscores
    {
        public string name, score;

        public Highscores(string _name, string _score)
        {
            name = _name;
            score = _score;
        }

        public void save(Highscores hs)
        {
            bool scoreAdded = false;

            for (int i = 0; i < Convert.ToInt16(Form1.highscoreList.Count); i++)
            {
                if (Form1.currentScore > Convert.ToInt16(Form1.highscoreList[i].score))
                {
                    Form1.highscoreList.Insert(i, hs);

                    scoreAdded = true;
                    i = Form1.highscoreList.Count;
                }
            }

            if (scoreAdded == false)
                Form1.highscoreList.Add(hs);

        }

        public void saveScores(List<Highscores> _scoreList)
        {
            // Only saves the top 10 highscores
            if (_scoreList.Count > 10)
            {
                for (int i = _scoreList.Count; i > 10; i--)
                    _scoreList.RemoveAt(i - 1);
            }
            // Creates the xml file where highscores are saved
            XmlTextWriter writer = new XmlTextWriter("highscoreDB.xml", null);

            writer.WriteStartElement("highscoreList");

            foreach (Highscores hs in _scoreList)
            {
                // Start "highscore" element
                writer.WriteStartElement("highscores");

                // Write sub-elements
                writer.WriteElementString("name", hs.name);
                writer.WriteElementString("score", hs.score);

                // End the "highscore" element
                writer.WriteEndElement();
            }

            writer.WriteEndElement();

            writer.Close();
        }
    }
}
