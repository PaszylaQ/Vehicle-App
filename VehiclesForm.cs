using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehicleApp
{
    public partial class VehiclesForm : Form
    {
        private Document document { get; set; }
        private List<Vehicle> selectedVehicles;
        private SpeedFilter filter;

        public VehiclesForm(Document document)
        {
            InitializeComponent();
            this.document = document;
            selectedVehicles = document.vehicles;
            filter = SpeedFilter.All;
        }

        private void EditVehicleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (vehicelsListView.SelectedItems.Count == 1)
            {
                Vehicle vehicle = (Vehicle)vehicelsListView.SelectedItems[0].Tag;
                VehicleForm vehicleForm = new VehicleForm(vehicle, document.vehicles);
                if (vehicleForm.ShowDialog() == DialogResult.OK)
                {
                    vehicle.brand = vehicleForm.vehicleBrand;
                    vehicle.maxSpeed = vehicleForm.vehicleMaxSpeed;
                    vehicle.dateOfProduction = vehicleForm.vehicleDateOfProductionValue;
                    vehicle.type = vehicleForm.vehicleType;
                    
                    document.UpdateVehicle(vehicle);
                }
            }
        }

        private void AddVehicleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VehicleForm vehicleForm = new VehicleForm(null, document.vehicles);
            if (vehicleForm.ShowDialog() == DialogResult.OK)
            {
                Vehicle newVehicle = new Vehicle(vehicleForm.vehicleBrand, vehicleForm.vehicleMaxSpeed, vehicleForm.vehicleDateOfProductionValue, vehicleForm.vehicleType);

                document.AddVehicle(newVehicle);
            }
        }

        private void UpdateItem(ListViewItem item)
        {
            Vehicle vehicle = (Vehicle)item.Tag;
            while (item.SubItems.Count < 4)
                item.SubItems.Add(new ListViewItem.ListViewSubItem());
            item.SubItems[0].Text = vehicle.brand;
            item.SubItems[1].Text = vehicle.maxSpeed.ToString();
            item.SubItems[2].Text = vehicle.dateOfProduction.Year.ToString();
            item.SubItems[3].Text = vehicle.typeToString();
        }

        private void UpdateItems()
        {
            vehicelsListView.Items.Clear();
            foreach (Vehicle vehicle in document.vehicles)
            {
                if(IsFittingToFilters(vehicle))
                {
                    ListViewItem item = new ListViewItem();
                    item.Tag = vehicle;
                    UpdateItem(item);
                    vehicelsListView.Items.Add(item);
                }
            }
            SetNumberOfVehicles();
        }

        private void UpdateVehicle(Vehicle vehicle)
        {
            foreach (ListViewItem item in vehicelsListView.Items)
            {
                if (ReferenceEquals(vehicle, item.Tag))
                {
                    if (IsFittingToFilters(vehicle))
                    {
                        UpdateItem(item);
                    }
                    else
                    {
                        DeleteVehicle(vehicle);
                        SetNumberOfVehicles();
                    }
                    return;
                }
            }

            if (IsFittingToFilters(vehicle))
            {
                AddVehicle(vehicle);
                SetNumberOfVehicles();
            }
        }

        private void DeleteVehicle(Vehicle vehicle)
        {
            foreach (ListViewItem item in vehicelsListView.Items)
            {
                if (item.Tag.Equals(vehicle))
                {
                    vehicelsListView.Items.Remove(item);
                    SetNumberOfVehicles();
                    return;
                }
            }
        }

        private void RemoveVehicleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (vehicelsListView.SelectedItems.Count == 1)
            {
                Vehicle vehicle = (Vehicle)vehicelsListView.SelectedItems[0].Tag;
                document.DeleteVehicle(vehicle);
            }
        }

        private void VehiclesForm_Load(object sender, EventArgs e)
        {
            UpdateItems();
            document.addVehicleEvent += Document_AddVehicleEvent;
            document.deleteVehicleEvent += Document_DeleteVehicleEvent;
            document.editVehicleEvent += Document_EditVehicleEvent;
        }


        private void Document_AddVehicleEvent(Vehicle vehicle)
        {
            AddVehicle(vehicle);
        }

        private void AddVehicle(Vehicle vehicle)
        {
            if (IsFittingToFilters(vehicle))
            {
                ListViewItem item = new ListViewItem();
                item.Tag = vehicle;
                UpdateItem(item);
                vehicelsListView.Items.Add(item);
                SetNumberOfVehicles();
            }
        }

        private void Document_DeleteVehicleEvent(Vehicle vehicle)
        {
            DeleteVehicle(vehicle);
        }

        private void Document_EditVehicleEvent(Vehicle vehicle)
        {
            UpdateVehicle(vehicle);
        }

        private Boolean IsFittingToFilters(Vehicle vehicle)
        {
            switch (filter)
            {
                case SpeedFilter.All:
                    return true;
                case SpeedFilter.LessThen100:
                    return vehicle.maxSpeed < 100.0;
                case SpeedFilter.NotLessThen100:
                    return !(vehicle.maxSpeed < 100.0);
                default:
                    return true;
            }
        }

        private void VehiclesForm_Activated(object sender, EventArgs e)
        {
            ToolStripManager.Merge(status, ((MainForm)this.MdiParent).numberOfVehicles);
        }

        private void SetNumberOfVehicles()
        {
            toolStripStatusLabel.Text = "NumberOfVehicles: " + vehicelsListView.Items.Count;
        }

        private void VehiclesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!((MainForm)this.MdiParent).TryRemoveForm(this))
                e.Cancel = true;
        }

        private void AllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filter = SpeedFilter.All;
            UpdateItems();
        }

        private void MaxSpeedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filter = SpeedFilter.NotLessThen100;
            UpdateItems();
        }

        private void MaxSpeed100kmhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filter = SpeedFilter.LessThen100;
            UpdateItems();
        }

        private void VehiclesForm_Deactivate(object sender, EventArgs e)
        {
            ToolStripManager.RevertMerge(((MainForm)this.MdiParent).numberOfVehicles, status);
        }
    }
}
