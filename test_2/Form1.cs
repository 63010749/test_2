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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            wplayer.URL = (@"C:\Users\Tang\Desktop\program_fun\second_game\test_2\test_2\Resources\background_sound.wav");
            wplayer.controls.play();
            axWindowsMediaPlayer1.Hide();
        }

        public static WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();

        private void btn_start_MouseHover(object sender, EventArgs e)
        {
            btn_start.Image = Properties.Resources.start_hover;
            System.Media.SoundPlayer sound = new System.Media.SoundPlayer(@"C:\Users\Tang\Desktop\program_fun\second_game\test_2\test_2\Resources\button_sound.wav");
            sound.Play();
        }

        private void btn_option_MouseHover(object sender, EventArgs e)
        {
            btn_option.Image = Properties.Resources.option_hover;
            System.Media.SoundPlayer sound = new System.Media.SoundPlayer(@"C:\Users\Tang\Desktop\program_fun\second_game\test_2\test_2\Resources\button_sound.wav");
            sound.Play();
        }

        private void btn_exit_MouseHover(object sender, EventArgs e)
        {
            btn_exit.Image = Properties.Resources.exit_hover;
            System.Media.SoundPlayer sound = new System.Media.SoundPlayer(@"C:\Users\Tang\Desktop\program_fun\second_game\test_2\test_2\Resources\button_sound.wav");
            sound.Play();
        }

        private void btn_start_MouseLeave(object sender, EventArgs e)
        {
            btn_start.Image = Properties.Resources.start_normal;
        }

        private void btn_option_MouseLeave(object sender, EventArgs e)
        {
            btn_option.Image = Properties.Resources.option_normal;
        }

        private void btn_exit_MouseLeave(object sender, EventArgs e)
        {
            btn_exit.Image = Properties.Resources.exit_normal;
        }

        private void btn_start_MouseClick(object sender, MouseEventArgs e)
        {
            Form2 option = new Form2();
            option.Show();
            wplayer.controls.stop();
            Visible = false;
  
        }

        private void btn_option_Click(object sender, EventArgs e)
        {
            option_page option = new option_page();
            option.Show();
            Visible = false;

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
