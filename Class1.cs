using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Training
{
    class Motorcycle
    {
        public static int driverIntensity;
        public string driverName;
        public Motorcycle(int intensity = 0, string name = "")
        {
            if (intensity > 10) { intensity = 10; };
            driverIntensity = intensity;
            driverName = name;
        }
        


    }
}
