using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Reperto
{
    public partial class MediaPlayer : Form
    {
        public MediaPlayer(string url, int debutSequence)
        {
            InitializeComponent();
            axWindowsMediaPlayer1.URL = url;
            axWindowsMediaPlayer1.Ctlcontrols.currentPosition = debutSequence;
        }

        private void MediaPlayer_FormClosing(object sender, FormClosingEventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }
    }
}
