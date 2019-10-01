using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShopMain
{
    class CarObject
    {
        public string model { get; set; }
        public int horsePower { get; set; }
        public int maxSpeed { get; set; }
        public string number { get; set; }
        public int prise { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1} {2}", model, number, prise); ;
        }
    }
}
