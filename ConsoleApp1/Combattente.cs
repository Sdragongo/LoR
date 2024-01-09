using System;

namespace LoR
{
    abstract class Combattente : ICombattente
    {
        public int Vita { get; set; }
        public int Forza { get; set; }
        public int Esperienza { get; set; }
        public int Danno { get; set; }


        public abstract void GeneraVita();
        public abstract void GeneraForza();
        public abstract void AumentaEsperienza();
        public abstract void GeneraDanno();

        public void Stampa()
        {
            Console.WriteLine($"Vita: {Vita}, Forza: {Forza}, Esperienza: {Esperienza}, Danno: {Danno}");
        }
    }

}