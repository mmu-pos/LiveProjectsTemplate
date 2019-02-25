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
    public partial class ChangeScreen : Form
    {
        public ChangeScreen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //opens the email form in order to send the reciept
            new EmailForm().Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //closes the change screen
            this.Close();
        }
    }
}
