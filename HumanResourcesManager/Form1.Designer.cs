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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.AddWorker_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Add_Single_NewWorker_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Add_Multi_NewWorker_StripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.rowIndex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.WorkerName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.WorkerID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.WorkerSalary = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.WorkerTaxPercent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.WorkerIncomeTax = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.WorkerNetSalary = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.progressBar1.Location = new System.Drawing.Point(0, 507);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.progressBar1.Maximum = 10;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.progressBar1.Size = new System.Drawing.Size(1250, 28);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 5;
            this.progressBar1.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddWorker_ToolStripMenuItem,
            this.SortToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1250, 31);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // AddWorker_ToolStripMenuItem
            // 
            this.AddWorker_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Add_Single_NewWorker_ToolStripMenuItem,
            this.Add_Multi_NewWorker_StripMenuItem});
            this.AddWorker_ToolStripMenuItem.Image = global::HumanResourcesManager.Properties.Resources.green_plus;
            this.AddWorker_ToolStripMenuItem.Name = "AddWorker_ToolStripMenuItem";
            this.AddWorker_ToolStripMenuItem.Size = new System.Drawing.Size(83, 27);
            this.AddWorker_ToolStripMenuItem.Text = "הוסף";
            this.AddWorker_ToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Add_Single_NewWorker_ToolStripMenuItem
            // 
            this.Add_Single_NewWorker_ToolStripMenuItem.Name = "Add_Single_NewWorker_ToolStripMenuItem";
            this.Add_Single_NewWorker_ToolStripMenuItem.Size = new System.Drawing.Size(266, 28);
            this.Add_Single_NewWorker_ToolStripMenuItem.Text = "עובד חדש";
            this.Add_Single_NewWorker_ToolStripMenuItem.Click += new System.EventHandler(this.Add_Single_NewWorker_ToolStripMenuItem_Click);
            // 
            // Add_Multi_NewWorker_StripMenuItem
            // 
            this.Add_Multi_NewWorker_StripMenuItem.Name = "Add_Multi_NewWorker_StripMenuItem";
            this.Add_Multi_NewWorker_StripMenuItem.Size = new System.Drawing.Size(266, 28);
            this.Add_Multi_NewWorker_StripMenuItem.Text = "10,000 עובדים אקראיים";
            this.Add_Multi_NewWorker_StripMenuItem.Click += new System.EventHandler(this.Add_Multi_NewWorker_StripMenuItem_Click);
            // 
            // SortToolStripMenuItem
            // 
            this.SortToolStripMenuItem.Image = global::HumanResourcesManager.Properties.Resources.sort;
            this.SortToolStripMenuItem.Name = "SortToolStripMenuItem";
            this.SortToolStripMenuItem.Size = new System.Drawing.Size(71, 27);
            this.SortToolStripMenuItem.Text = "מיין";
            this.SortToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SortToolStripMenuItem.Click += new System.EventHandler(this.SortToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(496, 267);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 38);
            this.label1.TabIndex = 25;
            this.label1.Text = "אנא המתן ...";
            this.label1.Visible = false;
            // 
            // listView1
            // 
            this.listView1.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.listView1.BackgroundImageTiled = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.rowIndex,
            this.WorkerName,
            this.WorkerID,
            this.WorkerSalary,
            this.WorkerTaxPercent,
            this.WorkerIncomeTax,
            this.WorkerNetSalary});
            this.listView1.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.FullRowSelect = true;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.HideSelection = false;
            this.listView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.listView1.Location = new System.Drawing.Point(0, 24);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listView1.RightToLeftLayout = true;
            this.listView1.Size = new System.Drawing.Size(1250, 511);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ItemActivate += new System.EventHandler(this.listView1_ItemActivate);
            // 
            // rowIndex
            // 
            this.rowIndex.Text = "";
            // 
            // WorkerName
            // 
            this.WorkerName.Text = "שם";
            this.WorkerName.Width = 160;
            // 
            // WorkerID
            // 
            this.WorkerID.Text = "מספר זהות";
            this.WorkerID.Width = 140;
            // 
            // WorkerSalary
            // 
            this.WorkerSalary.Text = "משכורת ברוטו";
            this.WorkerSalary.Width = 143;
            // 
            // WorkerTaxPercent
            // 
            this.WorkerTaxPercent.Text = "אחוז מס";
            this.WorkerTaxPercent.Width = 99;
            // 
            // WorkerIncomeTax
            // 
            this.WorkerIncomeTax.Text = "מס הכנסה חודשי";
            this.WorkerIncomeTax.Width = 159;
            // 
            // WorkerNetSalary
            // 
            this.WorkerNetSalary.Text = "משכורת נטו";
            this.WorkerNetSalary.Width = 126;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 535);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.listView1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "מעקב משכורת";
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
        private System.Windows.Forms.ColumnHeader WorkerTaxPercent;
        private System.Windows.Forms.ColumnHeader WorkerNetSalary;
        private System.Windows.Forms.ColumnHeader WorkerIncomeTax;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem AddWorker_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Add_Single_NewWorker_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Add_Multi_NewWorker_StripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SortToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader rowIndex;
    }
}

