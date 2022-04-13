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
        Worker worker;
        public Form3()
        {
            InitializeComponent();
        }
        public Form3(Worker obj) : this()
        {
            this.worker = obj;
            label9.Text = worker.getFirstName() +" "+ worker.getLastName();
            label10.Text = worker.getId();
            label11.Text =  worker.getPhoneNum();
            label12.Text = worker.getEmail();
            label13.Text = worker.getAddress();
            label14.Text = worker.getSalary();
            label15.Text = (Double.Parse(worker.getSalary()) - Double.Parse(worker.getNetSalary())).ToString();
            label16.Text = worker.getNetSalary();
        }
    }
}
