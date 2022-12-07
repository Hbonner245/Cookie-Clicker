using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CookieClicker1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // creating LemonCount variable, givingit the data type integer,  then castig it to an integer
            int LemonCount = Convert.ToInt32(textBox1.Text);
            //creating AddLemons variable, givingit the data type integer,  then castig it to an integer
            int AddLemons = Convert.ToInt32(textBox2.Text);
            LemonCount = LemonCount + 1 + AddLemons;
            textBox1.Text = Convert.ToString(LemonCount);
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int AddLemon = Convert.ToInt32(textBox2.Text);
            int CurrentLemons = Convert.ToInt32(textBox1.Text);
            if (CurrentLemons >= 10)
            {
                AddLemon++;
                textBox2.Text = Convert.ToString(AddLemon);
                CurrentLemons -= 10;
                textBox1.Text = Convert.ToString(CurrentLemons);
            } // End of If
            else 
            {
                MessageBox.Show("You need at least 10 - you mug");
            }
        }// end of button one click 

        private void button2_Click(object sender, EventArgs e)
        {
            // creating an instence of form 3
            Form3 form3 = new Form3();
            form3.Show();
        }// end of button2_click

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }// end of class
}// End of name space
