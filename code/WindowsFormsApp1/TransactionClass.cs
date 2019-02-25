using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class TransactionClass : IComparable
    {
            //veriables for transactions
            public string transaction_id;
            public DateTime date_time;
            public string staff_id;
            public string staff_name;
            public decimal total_amount;
            public string method;
            public decimal change;
            public decimal discount;


        public TransactionClass(string transaction_id, DateTime date_time, string staff_id, string staff_name, decimal total_amount, string method, decimal change, decimal discount)
            {
                this.transaction_id = transaction_id;
                this.date_time = date_time;
                this.staff_id = staff_id;
                this.staff_name = staff_name;
                this.total_amount = total_amount;
                this.method = method;
                this.change = change;
                this.discount = discount;
        }

        //getters and setters for the different variables
        public string Transaction_ID
        {
            get { return transaction_id; }
            set { transaction_id = value; }
        }
        public DateTime Date_Time
        {
            get { return date_time; }
            set { date_time = value; }
        }
        public string Staff_ID
        {
            get { return staff_id; }
            set { staff_id = value; }
        }
        public string Staff_Name
        {
            get { return staff_name; }
            set { staff_name = value; }
        }
        public decimal Total_Amount
        {
            get { return total_amount; }
            set { total_amount = value; }
        }
        public string Method
        {
            get { return method; }
            set { method = value; }
        }
        public decimal Change
        {
            get { return change; }
            set { change = value; }
        }
        public decimal Discount
        {
            get { return discount; }
            set { discount = value; }
        }

        //setting my compare method
        public int CompareTo(object obj)
        {
            TransactionClass temp = (TransactionClass)obj;
            return transaction_id.CompareTo(temp.transaction_id);
        }
    }
}

