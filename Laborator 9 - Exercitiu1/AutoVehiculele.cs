using System;
using System.Collections.Generic;
using System.Text;

namespace Laborator_9___Exercitiu1
{
    // Autovehiculele vor avea:

    // • Producator si model.
    // • motor electric, hibrid sau cu diesel.
    // • o metoda Porneste la apelul careia autovehiculul va porni motorul.
    class AutoVehiculele : MotorAutoVehicule
    {
        public string Model { get; private set; }
        public string Producator { get; private set; }

        public string Motor { get; private set; }
        public AutoVehiculele(string model, string producator, string motor) :base("Motor: Electric", "Motor: Hibrid", "Motor: Diesel")
        {
            this.Model = model;
            this.Producator = producator;
            this.Motor = motor;
        }
        public override void Porneste()
        {
            base.Porneste();
        }
        
        public void Tipareste()
        {
            Console.WriteLine($"Autovehicul {this.Producator} {this.Model} cu motor {this.Motor} are un rulaj de 175000km si costa 12500 euro.");
        }
    }
}
