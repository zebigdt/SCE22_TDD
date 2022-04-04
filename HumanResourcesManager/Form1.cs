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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
            Form2 workerDialog = new Form2();
            workerDialog.ShowDialog();
        }

        private void toolStripTextBox2_Click(object sender, EventArgs e)
        {
                ListViewItem item = new ListViewItem();
                item.Text = Utility.generateName();
                item.SubItems.Add(Utility.generateID());
                item.SubItems.Add(Utility.generateSalary());
                listView1.Items.Add(item);
        }
    }
}
