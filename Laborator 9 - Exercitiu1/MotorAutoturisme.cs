using System;
using System.Collections.Generic;
using System.Text;

namespace Laborator_9___Exercitiu1
{
    // Motoarele

    // • La pornirea acestora vor emite un zgomot caracteristic, afisandu-l ca mesaj in consola.
    class MotorAutoturisme
    {
        public string MotorElectric { get; set; }
        public string MotorHibrid { get; set; }
        public MotorAutoturisme(string motorElectric, string motorHibrid)
        {
            MotorElectric = motorElectric;
            MotorHibrid = motorHibrid;
        }

        public virtual void Porneste()
        {
            Console.WriteLine("Motorul a fost pornit! Vrooom");
        }
    }
}
