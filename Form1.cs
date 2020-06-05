using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication7
{
    
    public partial class Form1 : Form
    {
        string [,] butt = new string[3,3];
        public bool lok;

        public Form1()
        {
            InitializeComponent();
        }

    

        private void button1_Click(object sender, EventArgs e)
        {

            if (lok)
            {
                butt[0, 0] = "X";
                button1.Text = "X";
            }
            else
            {
                butt[0, 0] = "0";
                button1.Text = "0";
            }
            lok = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (lok)
            {
                butt[0, 1] = "X";
                button2.Text = "X";
            }
            else
            {
                butt[0, 1] = "0";
                button2.Text = "0";
            }
            lok =false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(lok) 
            {
                butt[0, 2] = "X";
                button3.Text = "X";
            }
            else
            {
                butt[0, 2] = "0";
                button3.Text = "0";
            }
            lok = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (lok)
            {
                butt[1, 0] = "X";
                button4.Text = "X";
            }
            else
            {
                butt[1, 0] = "0";
                button4.Text = "0";
            }
            lok = false;
        }
            private void button5_Click(object sender, EventArgs e)
        {

            if (lok)
            {
                butt[1, 1] = "X";
                button5.Text = "X";
            }
            else
            {
                butt[1, 1] = "0";
                button5.Text = "0";
            }
            lok = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {

            if (lok)
            {
                butt[1, 2] = "X";
                button6.Text = "X";
            }
            else
            {
                butt[1, 2] = "0";
                button6.Text = "0";
            }
            lok = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {

            if (lok)
            {
                butt[2, 0] = "X";
                button7.Text = "X";
            }
            else
            {
                butt[2, 0] = "0";
                button7.Text = "0";
            }
            lok = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {

            if (lok)
            {
                butt[2, 1] = "X";
                button8.Text = "X";
            }
            else
            {
                butt[2, 1] = "0";
                button8.Text = "0";
            }
            lok = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {

            if (lok)
            {
                butt[2, 2] = "X";
                button9.Text = "X";
            }
            else
            {
                butt[2, 2] = "0";
                button9.Text = "0";
            }
            lok = true;
        }
    }
}
