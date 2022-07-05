using System;
using System.Collections.Generic;
using System.Text;

namespace Laborator_9___Exercitiu1
{
    // Autoutilitarele

    // • vor avea doar motoare diesel.
    // • vor putea transporta combustibil si materiale de constructie.
    // • vor avea capacitati maxime prestabilite:

    // o 10000 mc pentru combustibil pentru cisterne.
    // o 40t pentru camioane.

    // • vor avea o metoda de incarcaMarfa care va incarca o cantitate primita ca parametru asigurand incarcarea sub capacitatea maxima.
    class AutoUtilitarele : MotorAutoUtilitara
    {
        public string TipUtilitara { get; set; }
        public string TipTransport { get; set; }

        public string Motor { get; private set; }
        public AutoUtilitarele(string tipUtilitara, string transport,string motor) : base("Motor: Diesel")
        {
            TipUtilitara = tipUtilitara;
            TipTransport = transport;
            this.Motor = motor;
        }

        public void IncarcaMarfa()
        {
            string tipUtilitara = "Cisterna";
            string transport = "Combustibil";
            int capacitateMaxima = 10000;
            int cantitate;

            Console.WriteLine("Introduceti o cantitate de incarcare ");
            cantitate = int.Parse(Console.ReadLine());
            if (cantitate <= capacitateMaxima)
            {
                Console.WriteLine($"{tipUtilitara} cu {transport} a fost incarcata cu o cantitate de {cantitate} mc si nu a depasit capacitatea maxima de {capacitateMaxima} mc.");
            }
            else
            {
                Console.WriteLine($"{tipUtilitara} cu {transport} nu poate fi incarcata cu cantitatea specificata {cantitate} din cauza ca a depasit capacitatea maxima de {capacitateMaxima} mc");
            }
        }
        public void IncarcaMarfa1()
        {
            string tipUtilitara = "Camion";
            string transport = "Materiale de Constructii";
            int capacitateMaxima = 40;
            int cantitate;

            Console.WriteLine("Introduceti o cantitate de incarcare ");
            cantitate = int.Parse(Console.ReadLine());
            if (cantitate <= capacitateMaxima)
            {
                Console.WriteLine($"{tipUtilitara} cu {transport} a fost incarcata cu O {cantitate} mc si nu a depasit capacitatea maxima de {capacitateMaxima} mc.");
            }
            else
            {
                Console.WriteLine($"{tipUtilitara} cu {transport} nu poate fi incarcata cu cantitatea specificata {cantitate} din cauza ca a depasit capacitatea maxima de {capacitateMaxima} mc.");
            }
        }
    }
}