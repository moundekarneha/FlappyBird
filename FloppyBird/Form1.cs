using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;


namespace FloppyBird
{
    public partial class Form1 : Form
    {
        private SoundPlayer soundPlayer;
        int pipeSpeed = 8;
        int gravity = 15;
        int score = 0;
        public Form1()
        { 
            InitializeComponent();
            string folder = Application.StartupPath;
            folder = folder + "\\sounds\\frontSound.wav";
            soundPlayer = new SoundPlayer(folder);
            //soundPlayer.SoundLocation = folder;
        }
        private void gameKeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Space)
            { 
                gravity = 15;
            }
        }

        private void gameKeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Space)
            {
                gravity = -15;
            }
        }
        private void EndGame()
          {
            timer1.Stop();
            timer1.Enabled = false;
            StartPage startPage = new StartPage();
            MessageBoxPage messageBoxPage = new MessageBoxPage();
            soundPlayer.Stop();// stopping music on showing msg box
            messageBoxPage.ShowDialog(); //showing form in dialog box
            this.Close();//For preventing multiple window opening here
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            button1.Enabled = true;
            picFlappyBird.Top += gravity;
            picRightBottom.Left -= pipeSpeed;//move buttom pipe left
            picRightButtom2.Left -= pipeSpeed;//move buttom2 pipe left
            picRightTop.Left -= pipeSpeed;//move top pipe left
            picRightTop2.Left -= pipeSpeed;//move top pipe2 left
            lblScore.Text = "Score : " + score.ToString();
            if (picRightBottom.Left < -150)
            {
                picRightBottom.Left = 800;
                score++;
            }
            if (picRightTop.Left < -100)
            {
                picRightTop.Left = 950;
                score++;
            }
            if (score < 10)
            {
                pipeSpeed = 25;
            }
            if (score < 20)
            {
                pipeSpeed = 50;
            }
            if(score==50)
            {

            }
            if (picFlappyBird.Bounds.IntersectsWith(picGround.Bounds)
                || picFlappyBird.Bounds.IntersectsWith(picRightBottom.Bounds)
                || picFlappyBird.Bounds.IntersectsWith(picRightButtom2.Bounds)
                || picFlappyBird.Top < 5
                || picFlappyBird.Bounds.IntersectsWith(picRightTop2.Bounds)
                || picFlappyBird.Bounds.IntersectsWith(picRightTop.Bounds))
            {
                EndGame();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
            soundPlayer.Play();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            if (timer1.Enabled)
            {
                timer1.Enabled = false;
                button1.BackColor = Color.Yellow;
                button1.Text = "Resume";
                soundPlayer.Stop();
            }
            else
            {
                button1.Enabled = false;
                timer1.Enabled = true;
                button1.Text = "Pasue";
                button1.BackColor = Color.Red;
                soundPlayer.Play();
            }
        }
    }
}
