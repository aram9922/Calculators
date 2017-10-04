using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
/* https://codefights.com/ */
namespace FormPlayer
{
    public partial class Form1 : Form
    {
        string f = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Music (*.wav)|*.wav";
            DialogResult result = openFileDialog1.ShowDialog();
            if( result == DialogResult.OK)
            {
                f = openFileDialog1.FileName;
                label1.Text = f;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MediaPlayer mediaPlayer = new MediaPlayer();
            Uri u = new Uri(f);
            mediaPlayer.Open(u);
            mediaPlayer.Play();
            mediaPlayer.Close();
        }
    }
}
