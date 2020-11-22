using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleApp
{
    public class Document
    {
        public List<Vehicle> vehicles = new List<Vehicle>();

        public event Action<Vehicle> addVehicleEvent;
        public event Action<Vehicle> deleteVehicleEvent;
        public event Action<Vehicle> editVehicleEvent;

        public void AddVehicle(Vehicle vehicle)
        {
            vehicles.Add(vehicle);
            addVehicleEvent?.Invoke(vehicle);
        }

        public void UpdateVehicle(Vehicle vehicle)
        {
            editVehicleEvent?.Invoke(vehicle);
        }

        public void DeleteVehicle(Vehicle vehicle)
        {
            vehicles.Remove(vehicle);
            deleteVehicleEvent?.Invoke(vehicle);
        }
    }
}
