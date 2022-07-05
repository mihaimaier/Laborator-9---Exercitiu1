using System;
using System.Collections.Generic;
using System.Text;

namespace Laborator_9___Exercitiu1
{
    class MotorAutoVehicule
    {
        public string MotorElectric { get; set; }
        public string MotorHibrid { get; set; }
        public string MotorDiesel { get; set; }
        public MotorAutoVehicule(string motorElectric, string motorHibrid, string motorDiesel)
        {
            MotorElectric = motorElectric;
            MotorHibrid = motorHibrid;
            MotorDiesel = motorDiesel;
        }

        public virtual void Porneste()
        {
            Console.WriteLine("Motorul a fost pornit! Vrooom");
        }
    }
}
