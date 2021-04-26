using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// file input/output would be real nice
// also would like to use lists and collections
// enums for transmission, as it takes only discrete values 

namespace HW3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Creating array of transport
            Truck t = new Truck(750, "automatic", 120, true);
            FamilyCar fc = new FamilyCar(400, "manual", 200, new string[]{ "Mom", "Dad", "2nd dad" });
            Motorcycle m = new Motorcycle(350, "manual", 220, 4);
            Bus b = new Bus(1400, "automatic", 80, "Ryan Gosling");
            #endregion
            TransportEntity[] arr = { t, fc, m, b};
            TransportDepot Minsk1248 = new TransportDepot(arr);
            Minsk1248.DisplayInfo();
        }
    }
}
