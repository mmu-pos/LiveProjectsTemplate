using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        AVLTree<TransactionClass> TransList = new AVLTree<TransactionClass>();
        
        bool isConnected = false;
        String[] ports;
        SerialPort port;
        public Form1()
        {
            InitializeComponent();
           
            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "ID";
            dataGridView1.Columns[1].Name = "POS";
            dataGridView1.Columns[2].Name = "ITEM";
            dataGridView1.Columns[3].Name = "PRICE";

            getAvailableComPorts();

           


            string transaction_id = "";
            var date_time = DateTime.Now;
            string staff_id = "";
            string staff_name = "";
            int total_amount = Int32.Parse("0");
            string method = "";
            int change = Int32.Parse("0");
            int discount = Int32.Parse("0");

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void BTN_7_Click(object sender, EventArgs e)
        {
            TXT_USER_INPUT.Text += "7";
        }

        private void BTN_8_Click(object sender, EventArgs e)
        {
            TXT_USER_INPUT.Text += "8";
        }

        private void BTN_9_Click(object sender, EventArgs e)
        {
            TXT_USER_INPUT.Text += "9";
        }

        private void BTN_4_Click(object sender, EventArgs e)
        {
            TXT_USER_INPUT.Text += "4";
        }

        private void BTN_5_Click(object sender, EventArgs e)
        {
            TXT_USER_INPUT.Text += "5";
        }

        private void BTN_6_Click(object sender, EventArgs e)
        {
            TXT_USER_INPUT.Text += "6";
        }

        private void BTN_1_Click(object sender, EventArgs e)
        {
            TXT_USER_INPUT.Text += "1";
        }

        private void BTN_2_Click(object sender, EventArgs e)
        {
            TXT_USER_INPUT.Text += "2";
        }

        private void BTN_3_Click(object sender, EventArgs e)
        {
            TXT_USER_INPUT.Text += "3";
        }

        private void BTN_0_Click(object sender, EventArgs e)
        {
            TXT_USER_INPUT.Text += "0";
        }

        private void BTN_00_Click(object sender, EventArgs e)
        {
            TXT_USER_INPUT.Text += "00";
        }

        private void BTN_DOT_Click(object sender, EventArgs e)
        {
            TXT_USER_INPUT.Text += ".";

        }

        private void button13_Click(object sender, EventArgs e)
        {
            //add veriables to insert record into the database

            string transaction_id = "TRANSACTION ID NULL";
            var date_time = DateTime.Now;
            string staff_id = "UNKNOWN STAFF ID";
            string staff_name = "UNKNOWN STAFF NAME";
            int total_amount = Int32.Parse("0");
            string method = "CASH";
            int change = Int32.Parse("0");
            int discount = Int32.Parse("0");


            //call statment that inserts a new company into the AVL Tree
            TransList.InsertItem(new TransactionClass(transaction_id, date_time, staff_id, staff_name, total_amount, method, change, discount));
            Console.WriteLine("");
            Console.Read();
            TXT_USER_INPUT.Text = "CASH";
        }

        private void button43_Click(object sender, EventArgs e)
        {
            addData("ID", "999", "LUCKY DIP", "2");
            new Age_Validation().Show();
        }

        private void addData(string ID, string POS, string ITEM, string PRICE)
            //add data to datagrid
        {
            String[] row = { ID, POS, ITEM, PRICE };
            dataGridView1.Rows.Add(row);
            TXT_USER_INPUT.Text = ITEM + "   £" + PRICE;
            TotalBar();
            poledisplay();

        }
        private void TotalBar()
        {
            //total text box method
            int sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value);
            }
            TXT_TOTAL.Text = "£" + sum.ToString();
        }

        private void button52_Click(object sender, EventArgs e)
        {
            addData("ID", "658", "SCRATCH CARD", "1");
        }

        private void button42_Click(object sender, EventArgs e)
        {
            addData("ID", "254", "LOTTO HOT PICKS", "2");
        }

        private void button51_Click(object sender, EventArgs e)
        {
            addData("ID", "658", "THUNDERBALL", "1");
        }

        private void button41_Click(object sender, EventArgs e)
        {
            addData("ID", "654", "EURO MILLIONS", "2");
        }

        private void button50_Click(object sender, EventArgs e)
        {
            addData("ID", "458", "**REFUND** CLAIM PRIZE", "10");
        }

        private void button61_Click(object sender, EventArgs e)
        {
            addData("ID", "254", "CAN OF COKE", "1");
        }

        private void button70_Click(object sender, EventArgs e)
        {
            addData("ID", "274", "CAN OF 7 UP", "1");
        }

        private void button60_Click(object sender, EventArgs e)
        {
            addData("ID", "214", "CAN OF FANTA", "1");
        }

        private void button69_Click(object sender, EventArgs e)
        {
            addData("ID", "492", "CAN OF DR PEPPER", "1");
        }

        private void button59_Click(object sender, EventArgs e)
        {
            addData("ID", "978", "CAN OF LILT", "1");
        }

        private void button68_Click(object sender, EventArgs e)
        {
            addData("ID", "204", "CAN OF PEPSI", "1");
        }

        private void button58_Click(object sender, EventArgs e)
        {
            addData("ID", "294", "CAN OF RUBICON", "1");
        }

        private void button67_Click(object sender, EventArgs e)
        {
            addData("ID", "244", "CAN OF SPRITE", "1");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            //line void command button
            int row = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(row);
            TXT_USER_INPUT.Text = "LINE VOID = ITEM REMOVED";
            TotalBar();
        }

        private void BTN_DISCOUNT10_Click(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {
            
            email();
        }

        private void email()
            //email method
        {
            var fromAddress = new MailAddress("lb16046091@gmail.com", "From Liam");
            var toAddress = new MailAddress("liamblackburn99@icloud.com", "liam");
            const string fromPassword = "R0bert99";
            const string subject = "Subject";
            const string body = "Body";

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            };
            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body
            })
            {
                smtp.Send(message);
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            //shows the change screen
            new ChangeScreen().Show();
            
        }

        private void button19_Click(object sender, EventArgs e)
        {
            
        }

        private void TXT_USER_INPUT_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void toolStripDropDownButton2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        void getAvailableComPorts()
        {
            ports = SerialPort.GetPortNames();
        }

        private void connectToArduino()
        {
            isConnected = true;
            port = new SerialPort("COM5", 9600, Parity.None, 8, StopBits.One);
            port.Open();
            port.Write("#STAR\n");      
        }

        private void cONNECTTOPOLEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            connectToArduino();
        }

        private void dISCONNECTPOLEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isConnected = false;
            port.Write("#STOP\n");
            port.Close();
        }

        public void poledisplay()
        {
            if (isConnected)
            {
                port.Write("#TEXT" + TXT_USER_INPUT.Text + "#\n");
            }
        }

        private void button34_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }


}

   
