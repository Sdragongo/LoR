using System;

namespace LoR
{
    interface ICombattente
    {
        int Vita { get; set; }
        int Forza { get; set; }
        int Esperienza { get; set; }
        int Danno { get; set; }

        void GeneraVita();
        void GeneraForza();
        void AumentaEsperienza();
        void GeneraDanno();
        void Stampa();
    }
}