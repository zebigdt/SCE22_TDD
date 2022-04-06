using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace HumanResourcesManager
{
    public partial class Form1 : Form
    {
        public static List<Worker> workerList = new List<Worker>();
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
            Form2 workerDialog = new Form2();
            workerDialog.ShowDialog();
            initializeTable();
        }

        private void toolStripTextBox2_Click(object sender, EventArgs e)
        {
            progressBar1.Show();
            for(int i = 0; i < 10000; i++)
            {
                Worker worker = new Worker();
                workerList.Add(worker);
                progressBar1.PerformStep();
            }
            initializeTable();
            progressBar1.Hide();
        }
        
        private void initializeTable()
        {
            for(int i=0; i < workerList.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                item.Text = workerList[i].getFirstName() + " " + workerList[i].getLastName();
                item.SubItems.Add(workerList[i].getId());
                item.SubItems.Add(workerList[i].getSalary());
                item.SubItems.Add(Utility.tax(workerList[i].getSalary()).ToString()+"%");
                item.SubItems.Add(workerList[i].getNetSalary());
                item.SubItems.Add(Utility.monthtax(workerList[i].getSalary(), Utility.tax(workerList[i].getSalary())).ToString()); 
                item.SubItems.Add(workerList[i].getEmail());
                listView1.Items.Add(item);
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
