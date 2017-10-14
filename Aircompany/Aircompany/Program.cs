using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aircompany
{
    class Program
    {
        static void Main(string[] args)
        {
            Airplane.MaxAltitudeAuto = 10000;
            Airplane.MinAltitudeAuto = 2000;
            Airplane Plane1 = new Airplane(150, 200, 5);
            Plane1.SetAltitude(15000);
            Console.WriteLine(Plane1.Altitude);
        }
    }
}
