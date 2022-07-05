using System;
using System.Collections.Generic;
using System.Text;

namespace Laborator_9___Exercitiu1
{
    //- Parcul auto va contine autovehicule care vor putea fi autoturisme sau autoutilitare.
    abstract class ParcAuto
    {
        public string AutoVehicul { get; private set; }
        public ParcAuto(string autovehicul)
        {
            AutoVehicul = autovehicul;
        }
    }
    class Autoturisme : ParcAuto
    {
        public Autoturisme() :base("Autoturisme")
        {
        }
    }
    class AutoUtilitare : ParcAuto 
    {
        public AutoUtilitare() :base("AutoUtilitare")
        {
        }
    }
}
