using System;

namespace LoR
{
    class Battaglione : IBattaglione
    {
        public int VitaTotale { get; set; }
        public int MediaVita { get; set; }
        public int ForzaTotale { get; set; }
        public int EsperienzaTotale { get; set; }
        public int DannoTotale { get; set; }
        public string Razza { get; set; }
        public int NCombattenti { get; set; }
        public void CalcolaVita(List<Combattente> listaSoldati)
        {
            VitaTotale = 0;
            foreach (var s in listaSoldati)
            {
                VitaTotale += s.Vita;
            }
        }

        public void CalcolaMedia(List<Combattente> listaSoldati)
        {
            if (listaSoldati.Count != 0)
            {
                MediaVita = VitaTotale / listaSoldati.Count;
                NCombattenti = listaSoldati.Count();
            }
            else
            {
                MediaVita = 0;
                NCombattenti = 0;
                VitaTotale = 0;
            }
        }
        public void CalcolaForza(List<Combattente> listaSoldati)
        {
            ForzaTotale = 0;
            foreach (var s in listaSoldati)
            {
                ForzaTotale += s.Forza;
            }
        }
        public void CalcolaEsperienza(List<Combattente> listaSoldati)
        {
            EsperienzaTotale = 0;
            foreach (var s in listaSoldati)
            {
                EsperienzaTotale += s.Esperienza;
            }
        }
        public void CalcolaDanno(List<Combattente> listaSoldati)
        {
            DannoTotale = 0;
            foreach (var s in listaSoldati)
            {
                DannoTotale += (s.Danno / 2);
            }
        }
        public void Stampa()
        {
            Console.WriteLine("Statistiche battaglione {0}:", Razza);
            Console.WriteLine($"Vita: {VitaTotale}, Forza: {ForzaTotale}, Esperienza: {EsperienzaTotale}, Danno: {DannoTotale}, Razza: {Razza}, Combattenti rimasti: {NCombattenti}");
        }
    }
}