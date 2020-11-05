using game4;
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
    public partial class Form2 : Form
    {
        bool goLeft, goRight, goUp, goDown, gameOver;
        string facing = "up";
        int playerHealth = 100;
        int speed = 10;
        int ammo = 10;
        int zombieSpeed = 3;
        Random randNum = new Random();
        int choose;
        int score;
        List<PictureBox> zombiesList = new List<PictureBox>();
        List<PictureBox> hpallList = new List<PictureBox>();
        List<PictureBox> ammoallList = new List<PictureBox>();

        public Form2()
        {
            InitializeComponent();
            wplayer.URL = (@"C:\Users\Tang\Desktop\program_fun\second_game\test_2\test_2\Resources\background_sound.wav");
            wplayer.controls.play();
            axWindowsMediaPlayer1.Hide();
            RestartGame();
        }

        public static WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }

            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }

            if (e.KeyCode == Keys.Up)
            {
                goUp = false;
            }

            if (e.KeyCode == Keys.Down)
            {
                goDown = false;
            }

            if (e.KeyCode == Keys.Space && ammo > 0 && gameOver == false)
            {
                ammo--;
                ShootBullet(facing);

                if (ammo < 1)
                {
                    DropAmmo();
                }

            }


        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (gameOver == true)
            {
                return;
            }

            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
                facing = "left";
                player.Image = Properties.Resources.left;
                choose = 2;
            }

            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
                facing = "right";
                player.Image = Properties.Resources.right;
                choose = 2;
            }

            if (e.KeyCode == Keys.Up)
            {
                goUp = true;
                facing = "up";
                player.Image = Properties.Resources.up;
                choose = 1;
            }

            if (e.KeyCode == Keys.Down)
            {
                goDown = true;
                facing = "down";
                player.Image = Properties.Resources.down;
                choose = 1;
            }
        }


       

        private void MainTimerEvent(object sender, EventArgs e)
        {
            if (playerHealth > 1)
            {
                healthBar.Value = playerHealth;
                if(playerHealth > 1 && playerHealth < 30)
                {
                    pictureBox3.Image = Properties.Resources.image5;
                }
                if(playerHealth > 29 && playerHealth < 60)
                {
                    pictureBox3.Image = Properties.Resources.image4;
                }
                if(playerHealth > 59 && playerHealth < 101)
                {
                    pictureBox3.Image = Properties.Resources.image3;
                }
            }

            else
            {
                gameOver = true;
                wplayer.controls.stop();
                player.Image = Properties.Resources.dead;
                GameTimer.Stop();
                over option = new over();
                option.Show();
                Visible = false;
            }

            txtAmmo.Text = " " + ammo;
            txtScore.Text = " " + score;


            if (goLeft == true && player.Left > 0)
            {
                player.Left -= speed;
            }

            if (goRight == true && player.Left + player.Width < this.ClientSize.Width)
            {
                player.Left += speed;
            }

            if (goUp == true && player.Top > 40)
            {
                player.Top -= speed;
            }

            if (goDown == true && player.Top + player.Height < this.ClientSize.Height)
            {
                player.Top += speed;
            }



            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "ammo")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        this.Controls.Remove(x);
                        ((PictureBox)x).Dispose();
                        ammo += 5;
                    }
                }

                if (x is PictureBox && (string)x.Tag == "zombie")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        playerHealth -= 1;

                    }
                    if (x.Left > player.Left)
                    {
                        x.Left -= zombieSpeed;
                        ((PictureBox)x).Image = Properties.Resources.zleft;
                    }
                    if (x.Left < player.Left)
                    {
                        x.Left += zombieSpeed;
                        ((PictureBox)x).Image = Properties.Resources.zright;
                    }
                    if (x.Top > player.Top)
                    {
                        x.Top -= zombieSpeed;
                        ((PictureBox)x).Image = Properties.Resources.zup;
                    }
                    if (x.Top < player.Top)
                    {
                        x.Top += zombieSpeed;
                        ((PictureBox)x).Image = Properties.Resources.zdown;
                    }

                    foreach (Control j in this.Controls)
                    {
                        if (j is PictureBox && (string)j.Tag == "bullet" && x is PictureBox && (string)x.Tag == "zombie")
                        {
                            if (x.Bounds.IntersectsWith(j.Bounds))
                            {
                                score++;
                                if (score % 10 == 0 && score != 0)
                                {
                                    DropHp();
                                }
                                this.Controls.Remove(j);
                                ((PictureBox)j).Dispose();
                                this.Controls.Remove(x);
                                ((PictureBox)x).Dispose();
                                zombiesList.Remove((PictureBox)x);
                                MakeZombies();
                            }
                        }
                    }
                }
                if (x is PictureBox && (string)x.Tag == "hp")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        this.Controls.Remove(x);
                        ((PictureBox)x).Dispose();
                        if (playerHealth < 90)
                        {
                            playerHealth += 10;
                        }

                    }
                }

            }



        }


        private void ShootBullet(string direction)
        {
            Bullet shootBullet = new Bullet();
            shootBullet.direction = direction;
            shootBullet.bulletLeft = player.Left + (player.Width / 2);
            shootBullet.bulletTop = player.Top + (player.Height / 2);
            if (choose == 1)
            {
                shootBullet.MakeBullet(this);
            }
            if (choose == 2)
            {
                shootBullet.MakeBullet1(this);
            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            MinimizeBox = false;
            ControlBox = false;
        }

        private void MakeZombies()
        {
            // when this function is called it will make zombies in the game

            PictureBox zombie = new PictureBox(); // create a new picture box called zombie
            zombie.Tag = "zombie"; // add a tag to it called zombie
            zombie.Image = Properties.Resources.zdown; // the default picture for the zombie is zdown
            zombie.Left = randNum.Next(0, 900); // generate a number between 0 and 900 and assignment that to the new zombies left 
            zombie.Top = randNum.Next(0, 800); // generate a number between 0 and 800 and assignment that to the new zombies top
            zombie.SizeMode = PictureBoxSizeMode.AutoSize; // set auto size for the new picture box
            zombiesList.Add(zombie);
            this.Controls.Add(zombie); // add the picture box to the screen
            player.BringToFront(); // bring the player to the front
        }

        private void DropHp()
        {
            PictureBox hp = new PictureBox(); // create a new instance of the picture box
            hp.Tag = "hp"; // set the tag to hp
            hp.Image = Properties.Resources.hp_Image; // assignment the ammo image to the picture box
            hp.Left = randNum.Next(10, this.ClientSize.Width - hp.Width); // set the location to a random left
            hp.Top = randNum.Next(40, this.ClientSize.Height - hp.Height); // set the location to a random top
            hp.SizeMode = PictureBoxSizeMode.AutoSize; // set the size to auto size
            hpallList.Add(hp);
            this.Controls.Add(hp); // add the ammo picture box to the screen
            hp.BringToFront(); // bring it to front
            player.BringToFront(); // bring the player t
        }

        private void DropAmmo()
        {

            // this function will make a ammo image for this game

            PictureBox ammo = new PictureBox(); // create a new instance of the picture box
            ammo.Image = Properties.Resources.ammo_Image; // assignment the ammo image to the picture box
            ammo.SizeMode = PictureBoxSizeMode.AutoSize; // set the size to auto size
            ammo.Left = randNum.Next(10, this.ClientSize.Width - ammo.Width); // set the location to a random left
            ammo.Top = randNum.Next(40, this.ClientSize.Height - ammo.Height); // set the location to a random top
            ammo.Tag = "ammo"; // set the tag to ammo
            ammoallList.Add(ammo);
            this.Controls.Add(ammo); // add the ammo picture box to the screen
            ammo.BringToFront(); // bring it to front
            player.BringToFront(); // bring the player to front
        }

        private void RestartGame()
        {

            player.Image = Properties.Resources.up;

            foreach (PictureBox i in zombiesList)
            {
                this.Controls.Remove(i);
            }
            foreach (PictureBox h in hpallList)
            {
                this.Controls.Remove(h);
            }

            foreach (PictureBox p in ammoallList)
            {
                this.Controls.Remove(p);
            }

            zombiesList.Clear();
            hpallList.Clear();
            ammoallList.Clear();

            for (int i = 0; i < 3; i++)
            {
                MakeZombies();
            }

            goUp = false;
            goDown = false;
            goLeft = false;
            goRight = false;
            gameOver = false;

            playerHealth = 100;
            score = 0;
            ammo = 10;

            GameTimer.Start();

        }
    }
}
