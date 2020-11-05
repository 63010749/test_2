using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_2
{
    public partial class over : Form
    {
        public over()
        {
            InitializeComponent();
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.restart_hover;
            System.Media.SoundPlayer sound = new System.Media.SoundPlayer(@"C:\Users\Tang\Desktop\program_fun\second_game\test_2\test_2\Resources\button_sound.wav");
            sound.Play();
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            pictureBox3.Image = Properties.Resources.backtomenu_hover;
            System.Media.SoundPlayer sound = new System.Media.SoundPlayer(@"C:\Users\Tang\Desktop\program_fun\second_game\test_2\test_2\Resources\button_sound.wav");
            sound.Play();
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            pictureBox4.Image = Properties.Resources.quit_hover;
            System.Media.SoundPlayer sound = new System.Media.SoundPlayer(@"C:\Users\Tang\Desktop\program_fun\second_game\test_2\test_2\Resources\button_sound.wav");
            sound.Play();
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.restart_normal ;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.Image = Properties.Resources.backtomenu_normal;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.Image = Properties.Resources.quit_normal;
        }

        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            Form2 option = new Form2();
            option.Show();
            Visible = false;
        }

        private void pictureBox3_MouseClick(object sender, MouseEventArgs e)
        {
            Form1 option = new Form1();
            option.Show();
            Visible = false;
        }

        private void pictureBox4_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void over_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            MinimizeBox = false;
            ControlBox = false;
        }
    }
}
