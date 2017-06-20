using System;
using System.Media;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using System.IO;
using System.Windows.Media;


namespace Super_Mario_Bros
{
    class Functions
    {
        public static System.Windows.Media.MediaPlayer powerUp;

        public void ChangeScreen(Form fm)
        {
            /*fm = this.FindForm();
            MenuScreen ms = new MenuScreen();

            ms.Location = new Point((this.Width - ms.Width) / 2, (this.Height - ms.Height) / 2);

            form.Controls.Add(ms);
            form.Controls.Remove(this);*/
        }

        public MediaPlayer Sound(string _fileName)
        {
            MediaPlayer mp = new MediaPlayer();
            try
            {
                mp.Open(new Uri(Application.StartupPath + String.Format("/Resources/{0}.wav", _fileName)));
                //powerUp.Open(new Uri(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "Resources/Select_A.wav")));
                mp.Volume = 1;
            }
            catch (Exception)
            {

                throw;
            }

            return mp;
        }
    }
}
