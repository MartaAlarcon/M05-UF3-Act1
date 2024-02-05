using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M05_UF3_Act1
{
    internal class Vehicle
    {
        private string brand;
        private string model;
        private string licensePlate;
        private int wheels;
        private int year;
        private float kms;

       public Vehicle(string _brand, string _model, string _licensePlate, int _wheels, int _year, float _kms)
        {
            this.brand = _brand;
            this.model = _model;
            this.licensePlate = _licensePlate;
            this.wheels = _wheels;
            this.year = _year;
            this.kms = _kms;
        }

        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public string LicensePlate
        {
            get { return licensePlate; }
            set { licensePlate = value; }
        }
        public int Wheels
        {
            get { return wheels; }
            set { wheels = value; }
        }
        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        public float Kms
        {
            get { return kms; }
            set { kms = value; }
        }
        public bool IsOlder(int year)
        {
            return year < 2005;
        }
    }
}
