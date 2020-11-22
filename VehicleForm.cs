using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehicleApp
{
    public partial class VehicleForm : Form
    {

        private Vehicle vehicle;
        private List<Vehicle> vehicles;
        private VehicleTypeControl control = new VehicleTypeControl();

        public VehicleForm(Vehicle vehicle, List<Vehicle> vehicles)
        {
            InitializeComponent();
            this.vehicle = vehicle;
            this.vehicles = vehicles;
            if (vehicle != null)
            {
                this.vehicleBrandTextBox.Text = vehicle.brand;
                this.maxSpeedTextBox.Text = vehicle.maxSpeed.ToString();
                this.vehicleDateOfProduction.Value = vehicle.dateOfProduction;
                this.vehicleTypeControl.CurrentType = vehicle.type;
            }
        }

        public string vehicleBrand
        {
            get { return vehicleBrandTextBox.Text; }
        }

        public double vehicleMaxSpeed
        {
            get { return double.Parse(maxSpeedTextBox.Text); }
        }

        public DateTime vehicleDateOfProductionValue
        {
            get { return vehicleDateOfProduction.Value; }
        }

        public TypeOfVehicle vehicleType
        {
            get { return vehicleTypeControl.CurrentType; }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void maxSpeedTextBox_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                float maxSpeed = float.Parse(maxSpeedTextBox.Text);
            }
            catch (Exception exception)
            {
                e.Cancel = true;
                maxSpeedErrorProvider.SetError(maxSpeedTextBox, exception.Message);
            }
        }

        private void maxSpeedTextBox_Validated(object sender, EventArgs e)
        {
            maxSpeedErrorProvider.SetError(maxSpeedTextBox, "");
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                if (ValidateVehicleExists())
                    DialogResult = DialogResult.OK;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void vehicleBrandTextBox_Validated(object sender, EventArgs e)
        {
            brandErrorProvider.SetError(vehicleBrandTextBox, "");
        }

        private void vehicleBrandTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (vehicleBrandTextBox.Text == "")
            {
                e.Cancel = true;
                brandErrorProvider.SetError(vehicleBrandTextBox, "No brand typed!");
            }
        }

        private bool ValidateVehicleExists()
        {
            try
            {
                Vehicle newVehicle = new Vehicle(vehicleBrand, vehicleMaxSpeed, vehicleDateOfProductionValue, vehicleType);
                foreach (Vehicle v in vehicles)
                    if (v.Equals(newVehicle) && !ReferenceEquals(v, vehicle))
                    {
                        throw new Exception("Vehicle already exists!");
                    }
                vehicleExistErrorProvider.SetError(okButton, "");
                return true;
            }
            catch (Exception exception)
            {
                vehicleExistErrorProvider.SetError(okButton, exception.Message);
                return false;
            }
        }

        private void VehicleForm_Load(object sender, EventArgs e)
        {
        }

        private void vehicleTypeControl_Click(object sender, EventArgs e)
        {

        }
    }
}
