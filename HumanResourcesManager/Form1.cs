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

        private void Add_Single_NewWorker_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 workerDialog = new Form2();
            workerDialog.ShowDialog();
            InitializeTable();
        }

        private void Add_Multi_NewWorker_StripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10000; i++)
            {
                Worker worker = new Worker();
                workerList.Add(worker);
            }
            InitializeTable();
        }

        public void InitializeTable()
        {
            ListViewItem item;
            listView1.Items.Clear();
            progressBar1.Maximum = workerList.Count();
            progressBar1.Show();
            for (int i = 0; i < workerList.Count; i++)
            {
                item = new ListViewItem();
                item.Text = workerList[i].getFirstName() + " " + workerList[i].getLastName();
                item.SubItems.Add(workerList[i].getId());
                item.SubItems.Add(workerList[i].getSalary());
                item.SubItems.Add(Utility.tax(workerList[i].getSalary()).ToString() + "%");
                item.SubItems.Add(workerList[i].getNetSalary());
                item.SubItems.Add(Utility.monthtax(workerList[i].getSalary(), Utility.tax(workerList[i].getSalary())).ToString());
                item.SubItems.Add(workerList[i].getPhoneNum());
                listView1.Items.Add(item);
                progressBar1.PerformStep();
            }
            progressBar1.Hide();
            progressBar1.Value = 0;
        }

        private void SortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stopwatch sw = new Stopwatch();
            label1.Visible = true;
            this.Update();
            sw.Start();
            Utility.Sort(workerList,0,workerList.Count() - 1);
            sw.Stop();
            InitializeTable();
            label1.Visible = false;
            this.Update();
            MessageBox.Show("המיון לקח " +sw.Elapsed.TotalSeconds.ToString()+" שניות");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
