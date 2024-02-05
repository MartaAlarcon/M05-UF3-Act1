using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M05_UF3_Act1
{
    internal class Motorbike : Vehicle
    {
        private int cubicCentimeters;
        private bool sidecar;

       public Motorbike (string _brand, string _model, string _licensePlate, int _wheels, int _year, float _kms, int _cubicCentimeters, bool _sidecar) : base(_brand, _model, _licensePlate, _wheels, _year, _kms)
        {
            this.cubicCentimeters = _cubicCentimeters;
            this.sidecar = _sidecar;
        }
        public int CubicCentimeters
        {
            get { return cubicCentimeters; }
            set { cubicCentimeters = value; }
        }
        public bool Sidecar
        {
            get { return sidecar; }
            set { sidecar = value; }
        }

        public bool isSidecar(int wheels)
        {
            return wheels > 3;
        }


    }
}
