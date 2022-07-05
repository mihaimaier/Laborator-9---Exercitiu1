using System;

namespace Laborator_9___Exercitiu1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Laborator 9 - Exercitiu - Parc Auto

            // Scrieti un program care va modela un parc auto.

            // Autovehiculele vor avea:

            // • Producator si model.
            // • motor electric, hibrid sau cu diesel.
            // • o metoda Porneste la apelul careia autovehiculul va porni motorul.

            // Motoarele

            // • La pornirea acestora vor emite un zgomot caracteristic, afisandu-l ca mesaj in consola.
            // - Parcul auto va contine autovehicule care vor putea fi autoturisme sau autoutilitare.

            // Autoturismele

            // • vor avea un numar de locuri.
            // • vor avea motoare electrice sau hibride.
            // • la pornirea autoturismelor, dupa pornirea motorului, acestea vor inchide usile afisand acest lucru pe ecran.

            // Autoutilitarele

            // • vor avea doar motoare diesel.
            // • vor putea transporta combustibil si materiale de constructie.
            // • vor avea capacitati maxime prestabilite:

            // o 10000 mc pentru combustibil pentru cisterne.
            // o 40t pentru camioane.

            // • vor avea o metoda de incarcaMarfa care va incarca o cantitate primita ca parametru asigurand incarcarea sub capacitatea maxima.

            AutoVehiculele autovehiculele = new AutoVehiculele("3", "Mazda", "Diesel");
            autovehiculele.Tipareste();
            autovehiculele.Porneste();

            Console.WriteLine();

            Autoturismele autoturism = new Autoturismele(5, "Electric");
            autoturism.Tipareste();
            autoturism.Porneste();

            Console.WriteLine();

            AutoUtilitarele autoutilitara = new AutoUtilitarele("Cisterna", "Combustibil","Diesel");
            autoutilitara.IncarcaMarfa();
        }
    }
}
