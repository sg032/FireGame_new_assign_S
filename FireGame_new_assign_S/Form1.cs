using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FireGame_new_assign_S
{
    public partial class Form1 : Form
    {
        //this code is used to set the workiing of the system 
        int []set= { 1, 2, 3, 4, 5 };
        
        int stage = 0, firecount = 0,fire=0;
        
        fireSetting FireSetting = new fireSetting();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //here we need to use this code to set the working of the system
            load_gun.Enabled = false;
            spin_gin.Enabled = false;
            Fire_gun.Enabled = false;
            fire_away_gun.Enabled = false;
            play_exit.Enabled = false;
            btnExit.Enabled = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //this code is used to close the game 
            Application.Exit();
        }

        private void play_exit_Click(object sender, EventArgs e)
        {
            //this code is used to restrt the process gin so thus we can play again 
            Application.Restart();
        }

        private void start_game_Button_Click(object sender, EventArgs e)
        {
            stage++;
            if (stage==set[0]) {
                start_game_Button.Enabled = false;
                load_gun.Enabled = true;
                pictureBox1.Image = FireGame_new_assign_S.Properties.Resources.start_game_pic;
            }
        }

        // load button working defined here

        private void load_gun_Click(object sender, EventArgs e)
        {
            stage++;
            if (stage == set[1])
            {
                load_gun.Enabled = false;
                spin_gin.Enabled = true;
                pictureBox1.Image = FireGame_new_assign_S.Properties.Resources.load_gun_pic;
            }
        }

        // fire away button working with if condition 

        private void fire_away_gun_Click(object sender, EventArgs e)
        {

            fire++;
            if (fire == 1)
            {
                stage++;
            }
            if (stage == set[4])
            {
                System.Media.SoundPlayer sund = new System.Media.SoundPlayer(FireGame_new_assign_S.Properties.Resources.Shot);
                sund.Play();


                if (fire <= 2)
                {

                    if (fire == FireSetting.setup())
                    {
                        MessageBox.Show("You are dead");
                        Fire_gun.Enabled = false;
                        fire_away_gun.Enabled = false;
                        play_exit.Enabled = true;
                        btnExit.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("You are alive ");
                    }
                }
                else
                {
                    Fire_gun.Enabled = false;
                    fire_away_gun.Enabled = false;
                    play_exit.Enabled = true;
                    btnExit.Enabled = true;
                }

                pictureBox1.Image = FireGame_new_assign_S.Properties.Resources.fireAway_pic;


            }
        }

        // spin gun button working that enabling next buttons and disabling previous buttons and chaning picture

            private void spin_gin_Click(object sender, EventArgs e)
        {
            stage++;
            if (stage == set[2])
            {
                fire_away_gun.Enabled = true;
                Fire_gun.Enabled = true;

                spin_gin.Enabled = false;
                pictureBox1.Image = FireGame_new_assign_S.Properties.Resources.spin_gun_pic;
            }
        }

        // clicking on fire gun button genrating sound of gun

        private void Fire_gun_Click(object sender, EventArgs e)
        {
            
            firecount++;
            if (firecount == 1) {
                stage++;
            }
            if (stage == set[3])
            {
                System.Media.SoundPlayer sund = new System.Media.SoundPlayer(FireGame_new_assign_S.Properties.Resources.Shot);
                sund.Play();


                if (firecount <= 4)
                {

                    if (firecount == FireSetting.set())
                    {
                        MessageBox.Show("You are dead");
                        Fire_gun.Enabled = false;
                        play_exit.Enabled = true;
                        btnExit.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("You are alive ");
                    }
                }
                else {

                    Fire_gun.Enabled = false;
                    play_exit.Enabled = true;
                    btnExit.Enabled = true;

                }
                
                pictureBox1.Image = FireGame_new_assign_S.Properties.Resources.fire_gun_pic;

            }
        }
    }
}
