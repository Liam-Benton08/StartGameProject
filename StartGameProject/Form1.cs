using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace StartGameProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void startganeButton_Click(object sender, EventArgs e)
        {
            SoundPlayer Soundcountdown = new SoundPlayer(Properties.Resources.Game_started_);
            SoundPlayer Soundgo = new SoundPlayer(Properties.Resources.Countdown1);

            progressBar.Minimum = 0;
            progressBar.Maximum = 100;

            //startgameButton.Location = new Point(1000, 1000);
            progressBar.Visible = true;
            startgameButton.Visible = false;
            progressBar.Value = 20;
            outputLabel.Location = new Point(180, 350);
            Soundgo.Play();
            Refresh();
            Thread.Sleep(1000);

            Soundgo.Stop();
            progressBar.Value = 60;
            outputLabel.Text = "Game starting in 2...";
            Soundgo.Play();
            Refresh();
            Thread.Sleep(1000);

            Soundgo.Stop();
            progressBar.Value = 100;
            outputLabel.Text = "Game starting in 1...";
            Soundgo.Play();
            Refresh();
            Thread.Sleep(1000);
            
            Soundgo.Stop();
            progressBar.Visible=false;
            outputLabel.Location = new Point(1000, 1000);
            this.BackColor = Color.LimeGreen;
            outputLabel2.Location = new Point(320, 155);
            Soundcountdown.Play();

            Refresh();
            Thread.Sleep(1000);

            this.BackColor = Color.White;
            outputLabel2.ForeColor = Color.LimeGreen;
            outputLabel2.BackColor = Color.White;

            Refresh();
            Thread.Sleep(1000);

            this.BackColor = Color.LimeGreen;
            outputLabel2.ForeColor= Color.White;
            outputLabel2.BackColor= Color.LimeGreen;

        }

        private void outputLabel2_Click(object sender, EventArgs e)
        {

        }
    }
}
