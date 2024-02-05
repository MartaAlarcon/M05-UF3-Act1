using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M05_UF3_Act1.concecionari
{
    internal class Truck : Vehicle
    {
        private string type;
        private int tones;

        public Truck(string _brand, string _model, string _licensePlate, int _wheels, int _year, float _kms, string _type, int _tones) : base(_brand, _model, _licensePlate, _wheels, _year, _kms)
        {
            type = _type;
            tones = _tones;
        }
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        public int Tones
        {
            get { return tones; }
            set { tones = value; }
        }

        public bool isHeavy(int tones)
        {
            return tones > 15;
        }

    }
}
