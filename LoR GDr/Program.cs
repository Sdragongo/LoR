using System;

namespace LoR
{
    class Program
    {
        static void Main(string[] args)
        {
            CampiDelPellennor campoDiBattaglia = new CampiDelPellennor();
            campoDiBattaglia.MenuCreazione();
        }
    }

    class CampiDelPellennor
    {
        public void MenuCreazione()
        {
            // Your implementation for MenuCreazione goes here
        }
    }

    interface ICombattente
    {
        int Vita { get; set; }
        int Forza { get; set; }
        int Esperienza { get; set; }
        int Danno { get; set; }

        void CalcolaVita()
        {}
        void CalcolaForza()
        {}
        void CalcolaEsperienza()
        {}
        void CalcolaDanno()
        {}
    }

    interface IBattaglione
    {
        int VitaTotale { get; set; }
        int ForzaTotale { get; set; }
        int EsperienzaTotale { get; set; }
        int DannoTotale { get; set; }

        void   CalcolaVita()
        {
        }
        void CalcolaForza()
        {
        }
        void CalcolaEsperienza()
        {
        }
        void CalcolaDanno()
        {
        }
    }

    }
