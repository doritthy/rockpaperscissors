using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label2.Text = string.Empty;
            
            str[0] = "Rock";
            str[1] = "Paper";
            str[2] = "Scissors";
        }
        string[] str = new string[3];
        Random r = new Random();

        int playerScore;
        int CompScore;

        private void checkBox1_CheckedChanged(object sender, EventArgs e) // отключаем остальные кнопки
        {
            if (checkBox1.Checked == true)  // игрок выбрал камень
            {
                checkBox2.Enabled = false;
                checkBox3.Enabled = false; // другие варианты не выбираются
            }
            else
            {
                checkBox2.Enabled = true;
                checkBox3.Enabled = true;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e) //отключаем остальные кнопки
        {
            if (checkBox2.Checked == true)  // игрок выбрал бумагу
            {
                checkBox1.Enabled = false;
                checkBox3.Enabled = false;
            }
            else
            {
                checkBox1.Enabled = true;
                checkBox3.Enabled = true;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e) //отключаем остальные кнопки
        {
            if (checkBox3.Checked == true)  // игрок выбрал ножницы
            {
                checkBox2.Enabled = false;
                checkBox1.Enabled = false;
            }
            else
            {
                checkBox2.Enabled = true;
                checkBox1.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e) 
        {
            if (checkBox1.Checked == true)
            {
                if (str[r.Next(0, 3)].Equals(str[0]))
                {
                    label2.Text = "Draw";
                    CPUim.Image = Properties.Resources.rock;
                }
                if (str[r.Next(0, 3)].Equals(str[1]))
                {
                    
                    label2.Text = "Computer Wins";
                    CPUim.Image = Properties.Resources.paper;
                    CompScore += 1;
                }
                if (str[r.Next(0, 3)].Equals(str[2]))
                {
                    label2.Text = "Player Wins";
                    CPUim.Image = Properties.Resources.sciss;
                    playerScore += 1;
                }
            }
            if (checkBox2.Checked == true)
            {
                if (str[r.Next(0, 3)].Equals(str[0]))
                {
                    label2.Text = "Player Wins";
                    CPUim.Image = Properties.Resources.rock;
                    playerScore += 1;
                }
                if (str[r.Next(0, 3)].Equals(str[1]))
                {
                    label2.Text = "Draw";
                    CPUim.Image = Properties.Resources.paper;
                }
                if (str[r.Next(0, 3)].Equals(str[2]))
                {
                    
                    label2.Text = "Computer Wins";
                    CPUim.Image = Properties.Resources.sciss;
                    CompScore += 1;
                }
            }
            if (checkBox3.Checked == true)
            {
                if (str[r.Next(0, 3)].Equals(str[0]))
                {
                    label2.Text = "Computer Wins";
                    CPUim.Image = Properties.Resources.rock;
                    CompScore += 1;
                }
                if (str[r.Next(0, 3)].Equals(str[1]))
                {
                    label2.Text = "Player Wins";
                    CPUim.Image = Properties.Resources.paper;
                    playerScore += 1;
                }
                if (str[r.Next(0, 3)].Equals(str[2]))
                {
                    label2.Text = "Draw";
                    CPUim.Image = Properties.Resources.sciss;
                }
            }

            else if(checkBox1.Checked == false && checkBox2.Checked == false && checkBox3.Checked == false)
            {
                MessageBox.Show("Please make a choice!");
            }
            label1.Text = "Player: " + playerScore + " - " + "Comp: " + CompScore;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            playerScore = 0;
            CompScore = 0;
            label1.Text = "Player: " + playerScore + " - " + "Comp: " + CompScore;
        }
    }
}
