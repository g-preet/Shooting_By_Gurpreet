using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shooting_By_Gurpreet
{
    public partial class Form1 : Form
    {
        ShootClass sc = new ShootClass();//instance of GameClass
        Random rdNumbers = new Random();
        int gptotalShoot = 6;//value for totalshots
        int gpgunTry = 2;//value for gun
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Shooting_By_Gurpreet.Properties.Resources.load_gun;//adding the image on the picturebox
            System.Media.SoundPlayer soundPlayer = new System.Media.SoundPlayer(Shooting_By_Gurpreet.Properties.Resources.gun_load);//code for sound
            soundPlayer.Play();//play sound

            button1.Enabled = false;
            sc.gpLoad = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Shooting_By_Gurpreet.Properties.Resources.spin_gun_chamber;//adding the image on the picturebox
            System.Media.SoundPlayer soundPlayer = new System.Media.SoundPlayer(Shooting_By_Gurpreet.Properties.Resources.spin_chamber);//Add sound here
            soundPlayer.Play();//play sound

            button2.Enabled = false;

            sc.gpSpin = rdNumbers.Next(1, 6);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Shooting_By_Gurpreet.Properties.Resources.gun_to_head;//add the image on the picturebox
            System.Media.SoundPlayer soundPlayer = new System.Media.SoundPlayer(Shooting_By_Gurpreet.Properties.Resources.bullet1);//sound here
            soundPlayer.Play();//play sound

            if (gptotalShoot > 0 && sc.gpSpin == 1)
            {
                MessageBox.Show("Shoot You loose");
                button4.Enabled = false;
                button3.Enabled = false;
            }
            else if (gptotalShoot > 0 && sc.gpSpin != 1)
            {
                MessageBox.Show("Blank Fire");
                gptotalShoot = gptotalShoot - 1;//minus one from total
                sc.gpSpin = sc.ShootgpLoop(sc.gpSpin);

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Shooting_By_Gurpreet.Properties.Resources.gun_in_air;//Here i add the image on the picturebox
            System.Media.SoundPlayer soundPlayer = new System.Media.SoundPlayer(Shooting_By_Gurpreet.Properties.Resources.empty_gun_shot);//Add sound here
            soundPlayer.Play();//play sound

            if (gptotalShoot > 0 && sc.gpSpin == 1 && gpgunTry == 2)
            {
                MessageBox.Show("you win you score is 200");
                button4.Enabled = false;
                button3.Enabled = false;
            }
            if (gptotalShoot > 0 && sc.gpSpin == 1 && gpgunTry == 1)
            {
                MessageBox.Show("you win you score is 100");
                button4.Enabled = false;
                button3.Enabled = false;
            }
            else if (gptotalShoot > 0 && sc.gpSpin != 1)
            {
                MessageBox.Show("Blank Fire");
                gptotalShoot = gptotalShoot - 1;//minus one from total
                sc.gpSpin = sc.ShootgpLoop(sc.gpSpin);

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            (new Form1()).Show();
            this.Hide();
        }
    }
}
