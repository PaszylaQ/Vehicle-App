namespace VehicleApp
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addListViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.numberOfVehicles = new System.Windows.Forms.StatusStrip();
            this.vehiclesNumberLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.menuStrip1.SuspendLayout();
            this.numberOfVehicles.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.windowToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(600, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // windowToolStripMenuItem
            // 
            this.windowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addListViewToolStripMenuItem});
            this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            this.windowToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.windowToolStripMenuItem.Text = "Okno";
            // 
            // addListViewToolStripMenuItem
            // 
            this.addListViewToolStripMenuItem.Name = "addListViewToolStripMenuItem";
            this.addListViewToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addListViewToolStripMenuItem.Text = "Add ListView";
            this.addListViewToolStripMenuItem.Click += new System.EventHandler(this.addListViewToolStripMenuItem_Click);
            // 
            // numberOfVehicles
            // 
            this.numberOfVehicles.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.numberOfVehicles.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vehiclesNumberLabel});
            this.numberOfVehicles.Location = new System.Drawing.Point(0, 344);
            this.numberOfVehicles.Name = "numberOfVehicles";
            this.numberOfVehicles.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.numberOfVehicles.Size = new System.Drawing.Size(600, 22);
            this.numberOfVehicles.TabIndex = 1;
            this.numberOfVehicles.Text = "statusStrip1";
            // 
            // vehiclesNumberLabel
            // 
            this.vehiclesNumberLabel.Name = "vehiclesNumberLabel";
            this.vehiclesNumberLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStrip
            // 
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(600, 25);
            this.toolStrip.TabIndex = 2;
            this.toolStrip.Text = "toolStrip1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.numberOfVehicles);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.MdiChildActivate += new System.EventHandler(this.MainForm_MdiChildActivate);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.numberOfVehicles.ResumeLayout(false);
            this.numberOfVehicles.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem windowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addListViewToolStripMenuItem;
        public System.Windows.Forms.ToolStripStatusLabel vehiclesNumberLabel;
        private System.Windows.Forms.ToolStrip toolStrip;
        public System.Windows.Forms.StatusStrip numberOfVehicles;
    }
}