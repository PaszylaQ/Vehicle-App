using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleApp
{
    public enum TypeOfVehicle
    {
        Car,
        Truck,
        Motorcycle
    }
    public class Vehicle
    {
        public string brand
        {
            set;
            get;
        }

        public double maxSpeed
        {
            set;
            get;
        }

        public DateTime dateOfProduction
        {
            set;
            get;
        }

        public TypeOfVehicle type
        {
            set;
            get;
        }

        public string typeToString()
        {
            switch (type)
            {
                case TypeOfVehicle.Car:
                    return "Car";
                case TypeOfVehicle.Truck:
                    return "Truck";
                case TypeOfVehicle.Motorcycle:
                    return "Motorcycle";
                default:
                    return "";
                }
        }

        public Vehicle(string brand, double maxSpeed, DateTime dateOfProduction, TypeOfVehicle type)
        {
            this.brand = brand;
            this.maxSpeed = maxSpeed;
            this.dateOfProduction = dateOfProduction;
            this.type = type;
        }

        public override Boolean Equals(Object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Vehicle v = (Vehicle)obj;
                if (!brand.Equals(v.brand))
                    return false;
                if (!maxSpeed.Equals(v.maxSpeed))
                    return false;
                if (!dateOfProduction.Equals(v.dateOfProduction))
                    return false;
                if (!type.Equals(v.type))
                    return false;
                
                return true;
            }
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder(type.ToString() + ": brand = " + brand + ", maxSpeed = " + maxSpeed 
                + ", dateOfProduction = " + dateOfProduction.ToString());
            return stringBuilder.ToString();
        }
    }
}
