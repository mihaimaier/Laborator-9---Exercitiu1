using System;
using System.Collections.Generic;
using System.Text;

namespace Laborator_9___Exercitiu1
{
    // Autoturismele

    // • vor avea un numar de locuri.
    // • vor avea motoare electrice sau hibride.
    // • la pornirea autoturismelor, dupa pornirea motorului, acestea vor inchide usile afisand acest lucru pe ecran.
    class Autoturismele : MotorAutoturisme
    {
        public int NumarLocuri { get; set; }
        public string Motor { get; private set; }
        public Autoturismele(int numarLocuri, string motor) :base("Motor: Electric", "Motor: Hibrid")
        {
            NumarLocuri = numarLocuri;
            this.Motor = motor;
        }
        public override void Porneste()
        {
            base.Porneste();
            Console.WriteLine("Usile au fost inchise!");
        }
        public void Tipareste()
        {
            Console.WriteLine($"Autoturismele au {NumarLocuri} locuri iar motorul este {this.Motor}.");
        }
    }

}
