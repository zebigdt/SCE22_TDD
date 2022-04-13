using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HumanResourcesManager
{
    public partial class Form3 : Form
    {
        private readonly Worker worker;
        public Form3()
        {
            InitializeComponent();
        }
        public Form3(Worker obj) : this()
        {
            this.worker = obj;
            label9.Text = worker.GetFirstName() +" "+ worker.GetLastName();
            label10.Text = worker.GetId();
            label11.Text =  worker.GetPhoneNum();
            label12.Text = worker.GetEmail();
            label13.Text = worker.GetAddress();
            label14.Text = worker.GetSalary();
            label15.Text = (Double.Parse(worker.GetSalary()) - Double.Parse(worker.GetNetSalary())).ToString();
            label16.Text = worker.GetNetSalary();
        }
    }
}
