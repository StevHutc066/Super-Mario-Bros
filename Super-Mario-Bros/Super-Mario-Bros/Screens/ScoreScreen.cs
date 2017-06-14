﻿using System;
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
    public partial class ScoreScreen : UserControl
    {
        Boolean spaceDown;

        public ScoreScreen()
        {
            InitializeComponent();


        }

        private void ScoreScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Space:
                    spaceDown = true;
                    break;
                default:
                    break;
            }

            if (spaceDown == true)
            {
                MenuScreen ms = new MenuScreen();
                Form form = this.FindForm();

                ms.Location = new Point((form.Width - ms.Width) / 2, (form.Height - ms.Height) / 2);

                form.Controls.Add(ms);
                form.Controls.Remove(this);
            }
        }

        private void ScoreScreen_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Space:
                    spaceDown = false;
                    break;
                default:
                    break;
            }
        }
    }
}
