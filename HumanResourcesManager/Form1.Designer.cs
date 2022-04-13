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
            this.label1 = new System.Windows.Forms.Label();
            this.ListView_1 = new System.Windows.Forms.ListView();
            this.rowIndex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.WorkerName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.WorkerID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.WorkerSalary = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.WorkerTaxPercent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.WorkerIncomeTax = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.WorkerNetSalary = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AddWorker_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Add_Single_NewWorker_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Add_Multi_NewWorker_StripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(508, 157);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 38);
            this.label1.TabIndex = 25;
            this.label1.Text = "אנא המתן ...";
            this.label1.Visible = false;
            // 
            // ListView_1
            // 
            this.ListView_1.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.ListView_1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListView_1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ListView_1.BackgroundImageTiled = true;
            this.ListView_1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.rowIndex,
            this.WorkerName,
            this.WorkerID,
            this.WorkerSalary,
            this.WorkerTaxPercent,
            this.WorkerIncomeTax,
            this.WorkerNetSalary});
            this.ListView_1.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListView_1.FullRowSelect = true;
            this.ListView_1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ListView_1.HideSelection = false;
            this.ListView_1.HoverSelection = true;
            this.ListView_1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ListView_1.Location = new System.Drawing.Point(0, 24);
            this.ListView_1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ListView_1.MultiSelect = false;
            this.ListView_1.Name = "ListView_1";
            this.ListView_1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ListView_1.RightToLeftLayout = true;
            this.ListView_1.Size = new System.Drawing.Size(1250, 511);
            this.ListView_1.TabIndex = 3;
            this.ListView_1.UseCompatibleStateImageBehavior = false;
            this.ListView_1.View = System.Windows.Forms.View.Details;
            this.ListView_1.ItemActivate += new System.EventHandler(this.ListView1_ItemActivate);
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
            // AddWorker_ToolStripMenuItem
            // 
            this.AddWorker_ToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
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
            this.SortToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.SortToolStripMenuItem.Image = global::HumanResourcesManager.Properties.Resources.sort;
            this.SortToolStripMenuItem.Name = "SortToolStripMenuItem";
            this.SortToolStripMenuItem.Size = new System.Drawing.Size(168, 27);
            this.SortToolStripMenuItem.Text = "מיין לפי משכורת";
            this.SortToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SortToolStripMenuItem.Click += new System.EventHandler(this.SortToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 535);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.ListView_1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "מעקב משכורות עובדים";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ColumnHeader WorkerName;
        private System.Windows.Forms.ColumnHeader WorkerID;
        private System.Windows.Forms.ColumnHeader WorkerSalary;
        private System.Windows.Forms.ListView ListView_1;
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

