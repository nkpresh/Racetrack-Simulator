using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaceTrack_Simulator
{
    public partial class Form1 : Form
    {
        Random MyRandomizer = new Random();

        Guy[] GuyArray = new Guy[3];
        Grehound[] GreyhoundArray = new Grehound[4];


        public Form1()
        {
            InitializeComponent();


            GreyhoundArray[0] = new Grehound()
            {
                MyPictureBox = pictureBox1,
                StartingPosition = pictureBox1.Left,
                RacetrackLenght = racetrackPictureBox.Width - pictureBox1.Width,
                Randomizer = MyRandomizer
            };
            GreyhoundArray[1] = new Grehound()
            {
                MyPictureBox = pictureBox2,
                StartingPosition = pictureBox2.Left,
                RacetrackLenght = racetrackPictureBox.Width - pictureBox2.Width,
                Randomizer = MyRandomizer
            };
            GreyhoundArray[2] = new Grehound()
            {
                MyPictureBox = pictureBox3,
                StartingPosition = pictureBox3.Left,
                RacetrackLenght = racetrackPictureBox.Width - pictureBox3.Width,
                Randomizer = MyRandomizer
            };
            GreyhoundArray[3] = new Grehound()
            {
                MyPictureBox = pictureBox4,
                StartingPosition = pictureBox4.Left,
                RacetrackLenght = racetrackPictureBox.Width - pictureBox4.Width,
                Randomizer = MyRandomizer
            };


            GuyArray[0] = new Guy()
            {
                Name = "Joe",
                Cash = 50,
                MyRadioButton = radioButton1,
                MyLabel = label1,
                MyBet = null
            };
            GuyArray[1] = new Guy()
            {
                Name = "Bob",
                Cash = 75,
                MyRadioButton = radioButton2,
                MyLabel = label2,
                MyBet = null
            };
            GuyArray[2] = new Guy()
            {
                Name = "Al",
                Cash = 45,
                MyRadioButton = radioButton3,
                MyLabel = label3,
                MyBet = null
            };
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label4.Text = GuyArray[0].Name;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label4.Text = GuyArray[1].Name;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label4.Text = GuyArray[2].Name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                GuyArray[0].placeBet((int)numericUpDown1.Value, (int)numericUpDown2.Value);
                GuyArray[0].UpdateLabels();
            }
            if (radioButton2.Checked)
            {
                GuyArray[1].placeBet((int)numericUpDown1.Value, (int)numericUpDown2.Value);
                GuyArray[1].UpdateLabels();
            }
            if (radioButton3.Checked)
            {
                GuyArray[2].placeBet((int)numericUpDown1.Value, (int)numericUpDown2.Value);
                GuyArray[2].UpdateLabels();
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {

                int Winner = i + 1;
                if (GreyhoundArray[i].Run())
                {
                    timer1.Stop();
                    label5.Text = "Salude jamigo!!";

                    MessageBox.Show("the winner is dog " + Winner + GuyArray[i].Name + " must have enough cash for next bet");
                    GuyArray[0].Collect(Winner);
                    GuyArray[0].UpdateLabels();
                    GuyArray[1].Collect(Winner);
                    GuyArray[1].UpdateLabels();
                    GuyArray[2].Collect(Winner);
                    GuyArray[2].UpdateLabels();

                    GreyhoundArray[0].TakeStartingPosition();
                    GreyhoundArray[1].TakeStartingPosition();
                    GreyhoundArray[2].TakeStartingPosition();
                    GreyhoundArray[3].TakeStartingPosition();
                    Application.DoEvents();
                }

            }
        }
    }
}

