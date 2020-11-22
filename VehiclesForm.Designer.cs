namespace VehicleApp
{
    partial class VehiclesForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VehiclesForm));
            this.vehicelsListView = new System.Windows.Forms.ListView();
            this.brand = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.maxSpeed = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.productionDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ListViewMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addVehicleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editVehicleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeVehicleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.editionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maxSpeedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maxSpeed100kmhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.status = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ListViewMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.toolStripContainer1.BottomToolStripPanel.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.status.SuspendLayout();
            this.SuspendLayout();
            // 
            // vehicelsListView
            // 
            this.vehicelsListView.AllowColumnReorder = true;
            this.vehicelsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.brand,
            this.maxSpeed,
            this.productionDate,
            this.type});
            this.vehicelsListView.ContextMenuStrip = this.ListViewMenuStrip1;
            this.vehicelsListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vehicelsListView.FullRowSelect = true;
            this.vehicelsListView.HideSelection = false;
            this.vehicelsListView.Location = new System.Drawing.Point(0, 0);
            this.vehicelsListView.Margin = new System.Windows.Forms.Padding(2);
            this.vehicelsListView.Name = "vehicelsListView";
            this.vehicelsListView.Size = new System.Drawing.Size(674, 433);
            this.vehicelsListView.TabIndex = 3;
            this.vehicelsListView.UseCompatibleStateImageBehavior = false;
            this.vehicelsListView.View = System.Windows.Forms.View.Details;
            // 
            // brand
            // 
            this.brand.Text = "Brand";
            // 
            // maxSpeed
            // 
            this.maxSpeed.Text = "maxSpeed";
            this.maxSpeed.Width = 100;
            // 
            // productionDate
            // 
            this.productionDate.Text = "Date of production";
            this.productionDate.Width = 131;
            // 
            // type
            // 
            this.type.Text = "Type";
            this.type.Width = 105;
            // 
            // ListViewMenuStrip1
            // 
            this.ListViewMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ListViewMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addVehicleToolStripMenuItem,
            this.editVehicleToolStripMenuItem,
            this.removeVehicleToolStripMenuItem});
            this.ListViewMenuStrip1.Name = "ListViewMenuStrip1";
            this.ListViewMenuStrip1.Size = new System.Drawing.Size(108, 70);
            // 
            // addVehicleToolStripMenuItem
            // 
            this.addVehicleToolStripMenuItem.Name = "addVehicleToolStripMenuItem";
            this.addVehicleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addVehicleToolStripMenuItem.Text = "Add";
            this.addVehicleToolStripMenuItem.Click += new System.EventHandler(this.AddVehicleToolStripMenuItem_Click);
            // 
            // editVehicleToolStripMenuItem
            // 
            this.editVehicleToolStripMenuItem.Name = "editVehicleToolStripMenuItem";
            this.editVehicleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editVehicleToolStripMenuItem.Text = "Edit";
            this.editVehicleToolStripMenuItem.Click += new System.EventHandler(this.EditVehicleToolStripMenuItem_Click);
            // 
            // removeVehicleToolStripMenuItem
            // 
            this.removeVehicleToolStripMenuItem.Name = "removeVehicleToolStripMenuItem";
            this.removeVehicleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.removeVehicleToolStripMenuItem.Text = "Delete";
            this.removeVehicleToolStripMenuItem.Click += new System.EventHandler(this.RemoveVehicleToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editionToolStripMenuItem,
            this.filterToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(674, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // editionToolStripMenuItem
            // 
            this.editionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.editToolStripMenuItem});
            this.editionToolStripMenuItem.Name = "editionToolStripMenuItem";
            this.editionToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.editionToolStripMenuItem.Text = "File";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.AddVehicleToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteToolStripMenuItem.Text = "Edit";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.EditVehicleToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editToolStripMenuItem.Text = "Delete";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.RemoveVehicleToolStripMenuItem_Click);
            // 
            // filterToolStripMenuItem
            // 
            this.filterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allToolStripMenuItem,
            this.maxSpeedToolStripMenuItem,
            this.maxSpeed100kmhToolStripMenuItem});
            this.filterToolStripMenuItem.Name = "filterToolStripMenuItem";
            this.filterToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.filterToolStripMenuItem.Text = "Filter";
            // 
            // allToolStripMenuItem
            // 
            this.allToolStripMenuItem.Name = "allToolStripMenuItem";
            this.allToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.allToolStripMenuItem.Text = "All";
            this.allToolStripMenuItem.Click += new System.EventHandler(this.AllToolStripMenuItem_Click);
            // 
            // maxSpeedToolStripMenuItem
            // 
            this.maxSpeedToolStripMenuItem.Name = "maxSpeedToolStripMenuItem";
            this.maxSpeedToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.maxSpeedToolStripMenuItem.Text = "maxSpeed >= 100 km/h";
            this.maxSpeedToolStripMenuItem.Click += new System.EventHandler(this.MaxSpeedToolStripMenuItem_Click);
            // 
            // maxSpeed100kmhToolStripMenuItem
            // 
            this.maxSpeed100kmhToolStripMenuItem.Name = "maxSpeed100kmhToolStripMenuItem";
            this.maxSpeed100kmhToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.maxSpeed100kmhToolStripMenuItem.Text = "maxSpeed < 100km/h";
            this.maxSpeed100kmhToolStripMenuItem.Click += new System.EventHandler(this.MaxSpeed100kmhToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3});
            this.toolStrip1.Location = new System.Drawing.Point(3, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(151, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.Visible = false;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(33, 22);
            this.toolStripButton1.Text = "Add";
            this.toolStripButton1.Click += new System.EventHandler(this.AddVehicleToolStripMenuItem_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(31, 22);
            this.toolStripButton2.Text = "Edit";
            this.toolStripButton2.Click += new System.EventHandler(this.EditVehicleToolStripMenuItem_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(44, 22);
            this.toolStripButton3.Text = "Delete";
            this.toolStripButton3.Click += new System.EventHandler(this.RemoveVehicleToolStripMenuItem_Click);
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.BottomToolStripPanel
            // 
            this.toolStripContainer1.BottomToolStripPanel.Controls.Add(this.status);
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.vehicelsListView);
            this.toolStripContainer1.ContentPanel.Margin = new System.Windows.Forms.Padding(2);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(674, 433);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(674, 457);
            this.toolStripContainer1.TabIndex = 6;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.menuStrip1);
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // status
            // 
            this.status.Dock = System.Windows.Forms.DockStyle.None;
            this.status.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.status.Location = new System.Drawing.Point(0, 0);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(135, 22);
            this.status.TabIndex = 0;
            this.status.Visible = false;
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel.Text = "toolStripStatusLabel1";
            // 
            // VehiclesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(674, 457);
            this.Controls.Add(this.toolStripContainer1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "VehiclesForm";
            this.Text = "VehiclesForm";
            this.Activated += new System.EventHandler(this.VehiclesForm_Activated);
            this.Deactivate += new System.EventHandler(this.VehiclesForm_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VehiclesForm_FormClosing);
            this.Load += new System.EventHandler(this.VehiclesForm_Load);
            this.ListViewMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.BottomToolStripPanel.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.status.ResumeLayout(false);
            this.status.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView vehicelsListView;
        private System.Windows.Forms.ContextMenuStrip ListViewMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addVehicleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editVehicleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeVehicleToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader brand;
        private System.Windows.Forms.ColumnHeader maxSpeed;
        private System.Windows.Forms.ColumnHeader productionDate;
        private System.Windows.Forms.ColumnHeader type;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        public System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripMenuItem filterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maxSpeedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maxSpeed100kmhToolStripMenuItem;
        private System.Windows.Forms.StatusStrip status;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
    }
}