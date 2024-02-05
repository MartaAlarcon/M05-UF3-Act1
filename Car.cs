using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M05_UF3_Act1
{
    internal class Car : Vehicle
    {
        private int doors;
        private string color;

        
        public Car(string _brand, string _model, string _licensePlate, int _wheels, int _year, float _kms, int _doors, string _color) : base(_brand, _model, _licensePlate, _wheels, _year, _kms)
        {
            this.doors = _doors;
            this.color = _color;
        }
        public int Doors
        {
            get { return doors; }
            set { doors = value; }
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public bool isBig(int year)
        {
            return 2024 - year > 15;
        }
    }
}
