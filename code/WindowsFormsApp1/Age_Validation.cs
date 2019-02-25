using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Age_Validation : Form
    {
        public Age_Validation()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            DateTime bday = DateTime.Parse(txt_date.Text);
            DateTime today = DateTime.Today;
            int age = 0;
            age = today.Year - bday.Year;
           
            if (age < 18)
            {
                MessageBox.Show("Invalid Birth Day");
                txt_date.Text = "";
            }
        }

        private void BTN_7_Click(object sender, EventArgs e)
        {
            txt_date.Text += "7";
        }

        private void BTN_8_Click(object sender, EventArgs e)
        {
            txt_date.Text += "8";
        }

        private void BTN_9_Click(object sender, EventArgs e)
        {
            txt_date.Text += "9";
        }

        private void BTN_4_Click(object sender, EventArgs e)
        {
            txt_date.Text += "4";
        }

        private void BTN_5_Click(object sender, EventArgs e)
        {
            txt_date.Text += "5";
        }

        private void BTN_6_Click(object sender, EventArgs e)
        {
            txt_date.Text += "6";
        }

        private void BTN_1_Click(object sender, EventArgs e)
        {
            txt_date.Text += "1";
        }

        private void BTN_2_Click(object sender, EventArgs e)
        {
            txt_date.Text += "2";
        }

        private void BTN_3_Click(object sender, EventArgs e)
        {
            txt_date.Text += "3";
        }

        private void BTN_DASH_Click(object sender, EventArgs e)
        {
            txt_date.Text += "/";
        }

        private void BTN_0_Click(object sender, EventArgs e)
        {
            txt_date.Text += "0";
        }
    }
}
