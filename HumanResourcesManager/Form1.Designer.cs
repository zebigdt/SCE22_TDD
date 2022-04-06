namespace HumanResourcesManager
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.WorkerName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.WorkerID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.WorkerSalary = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView1 = new System.Windows.Forms.ListView();
            this.WorkerTax = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.WorkerNetSalary = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.monthFee = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.AddWorker_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Add_Single_NewWorker_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Add_Multi_NewWorker_StripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // WorkerName
            // 
            this.WorkerName.Text = "שם";
            this.WorkerName.Width = 172;
            // 
            // WorkerID
            // 
            this.WorkerID.Text = "מספר זהות";
            this.WorkerID.Width = 143;
            // 
            // WorkerSalary
            // 
            this.WorkerSalary.Text = "משכורת ברוטו";
            this.WorkerSalary.Width = 137;
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.WorkerName,
            this.WorkerID,
            this.WorkerSalary,
            this.WorkerTax,
            this.WorkerNetSalary,
            this.monthFee});
            this.listView1.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 37);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView1.Name = "listView1";
            this.listView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listView1.RightToLeftLayout = true;
            this.listView1.Size = new System.Drawing.Size(1175, 400);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // WorkerTax
            // 
            this.WorkerTax.Text = "אחוז מס";
            this.WorkerTax.Width = 99;
            // 
            // WorkerNetSalary
            // 
            this.WorkerNetSalary.DisplayIndex = 5;
            this.WorkerNetSalary.Text = "משכורת נטו";
            this.WorkerNetSalary.Width = 126;
            // 
            // monthFee
            // 
            this.monthFee.DisplayIndex = 4;
            this.monthFee.Text = "מס הכנסה חודשי";
            this.monthFee.Width = 159;
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.progressBar1.Location = new System.Drawing.Point(11, 441);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.progressBar1.Maximum = 10000;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.progressBar1.Size = new System.Drawing.Size(1177, 26);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 5;
            this.progressBar1.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddWorker_ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1200, 28);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // AddWorker_ToolStripMenuItem
            // 
            this.AddWorker_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Add_Single_NewWorker_ToolStripMenuItem,
            this.Add_Multi_NewWorker_StripMenuItem});
            this.AddWorker_ToolStripMenuItem.Image = global::HumanResourcesManager.Properties.Resources.enemy;
            this.AddWorker_ToolStripMenuItem.Name = "AddWorker_ToolStripMenuItem";
            this.AddWorker_ToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.AddWorker_ToolStripMenuItem.Text = "הוסף";
            // 
            // Add_Single_NewWorker_ToolStripMenuItem
            // 
            this.Add_Single_NewWorker_ToolStripMenuItem.Name = "Add_Single_NewWorker_ToolStripMenuItem";
            this.Add_Single_NewWorker_ToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.Add_Single_NewWorker_ToolStripMenuItem.Text = "עובד חדש";
            this.Add_Single_NewWorker_ToolStripMenuItem.Click += new System.EventHandler(this.Add_Single_NewWorker_ToolStripMenuItem_Click);
            // 
            // Add_Multi_NewWorker_StripMenuItem
            // 
            this.Add_Multi_NewWorker_StripMenuItem.Name = "Add_Multi_NewWorker_StripMenuItem";
            this.Add_Multi_NewWorker_StripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.Add_Multi_NewWorker_StripMenuItem.Text = "10,000 עובדים חדשים";
            this.Add_Multi_NewWorker_StripMenuItem.Click += new System.EventHandler(this.Add_Multi_NewWorker_StripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 478);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ColumnHeader WorkerName;
        private System.Windows.Forms.ColumnHeader WorkerID;
        private System.Windows.Forms.ColumnHeader WorkerSalary;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ColumnHeader WorkerTax;
        private System.Windows.Forms.ColumnHeader WorkerNetSalary;
        private System.Windows.Forms.ColumnHeader monthFee;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem AddWorker_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Add_Single_NewWorker_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Add_Multi_NewWorker_StripMenuItem;
    }
}

