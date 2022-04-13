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
using System.Globalization;

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
            int prevWorkerListCount = workerList.Count;
            Form2 workerDialog = new Form2();
            workerDialog.ShowDialog();
            if (workerList.Count != prevWorkerListCount)
            {
                InitializeTable();
            }
        }

        private void Add_Multi_NewWorker_StripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10000; i++)
            {
                workerList.Add(new Worker());
            }
            InitializeTable();
        }

        public void InitializeTable()
        {
            
            ListViewItem item;
            ListView_1.Items.Clear();
            progressBar1.Maximum = workerList.Count();
            progressBar1.Show();
            label1.Visible = true;
            this.Update();
            for (int i = 0; i < workerList.Count; i++)
            {
                item = new ListViewItem();
                item.Text = (i+1).ToString();
                item.SubItems.Add(workerList[i].GetFirstName() + " " + workerList[i].GetLastName());
                item.SubItems.Add(workerList[i].GetId());
                item.SubItems.Add(workerList[i].GetSalary());
                item.SubItems.Add(Utility.CalculateTaxPercent(Double.Parse(workerList[i].GetSalary()), Double.Parse(workerList[i].GetNetSalary())).ToString());
                item.SubItems.Add(Utility.CalculateIncomeTax(Double.Parse(workerList[i].GetSalary())).ToString());
                item.SubItems.Add(workerList[i].GetNetSalary().ToString());
                ListView_1.Items.Add(item);
                progressBar1.PerformStep();
            }
            progressBar1.Hide();
            progressBar1.Value = 0;
            label1.Visible = false;
        }

        private void SortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(workerList.Count == 0)
            {
                MessageBox.Show("אין עובדים למיין");
            }
            else
            {
                label1.Visible = true;
                this.Update();
                Stopwatch sw = new Stopwatch();
                sw.Start();
                Utility.Sort(workerList, 0, workerList.Count() - 1);
                sw.Stop();
                InitializeTable();
                label1.Visible = false;
                this.Update();
                MessageBox.Show("המיון לקח " + sw.Elapsed.TotalSeconds.ToString() + " שניות");
            }
        }

        private void ListView1_ItemActivate(object sender, EventArgs e)
        {
            ListViewItem item = ListView_1.SelectedItems[0];
            Worker worker = workerList[item.Index];
            Form3 workerDialog = new Form3(worker);
            workerDialog.ShowDialog();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
                if (MessageBox.Show("פעולה זו תסגור את האפליקציה והמידע ימחק", "יציאה", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    e.Cancel = true;
                }
        }
    }
}
