using System;

namespace LoR
{
    interface IBattaglione
    {
        int VitaTotale { get; set; }
        int MediaVita { get; set; }
        int ForzaTotale { get; set; }
        int EsperienzaTotale { get; set; }
        int DannoTotale { get; set; }
        string Razza { get; set; }

        void CalcolaVita(List<Combattente> listaSoldati);
        void CalcolaForza(List<Combattente> listaSoldati);
        void CalcolaEsperienza(List<Combattente> listaSoldati);
        void CalcolaDanno(List<Combattente> listaSoldati);
        void CalcolaMedia(List<Combattente> listaSoldati);
        void Stampa();
    }
}