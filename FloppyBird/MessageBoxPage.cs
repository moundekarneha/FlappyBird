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
    public partial class MessageBoxPage : Form
    {
        SoundPlayer soundPlayer;
        public MessageBoxPage()
        {
            InitializeComponent();
            string path = Application.StartupPath;
            path = path + "\\sounds\\GameOver.wav";
            soundPlayer = new SoundPlayer(path);
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            Application.Exit();  
        }
        private void MessageBoxPage_Load_1(object sender, EventArgs e)
        {
            soundPlayer.Play();
        }
    }
}
