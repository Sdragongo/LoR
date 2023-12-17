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

        List<Umano> listaUmani = new List<Umano>();
        List<Elfo> listaElfi = new List<Elfo>();
        List<Nano> listaNani = new List<Nano>();
        List<Hobbit> listaHobbit = new List<Hobbit>();

        List<Orco> listaOrchi = new List<Orco>();
        List<Uruk_Hai> listaUrukHai = new List<Uruk_Hai>();
        List<Sudrone> listaSudroni = new List<Sudrone>();
        public void MenuCreazione()
        {
            int rispostaSchieramento;
            int rispostaRazza;
            Combattente Comandante = null; // Initialize Comandante to avoid compilation error
            do
            {
                Console.WriteLine("Benvenuto nel menù di creazione, decidi a quale Schieramento appartenere: (1) per il Bene, (2) per il Male.");
                rispostaSchieramento = Convert.ToInt32(Console.ReadLine());
            } while (rispostaSchieramento != 1 && rispostaSchieramento != 2);

            if (rispostaSchieramento == 1)
            {
                do
                {
                    Console.WriteLine("Ottimo, ora decidi a quale Razza appartenere: (1) per gli Umani, (2) per gli Elfi, (3) per i Nani, (4) per gli Hobbit.");
                    rispostaRazza = Convert.ToInt32(Console.ReadLine());
                } while (rispostaRazza < 1 || rispostaRazza > 4);

                switch (rispostaRazza)
                {
                    case 1:
                        Comandante = new Umano();
                        break;
                    case 2:
                        Comandante = new Elfo();
                        break;
                    case 3:
                        Comandante = new Nano();
                        break;
                    case 4:
                        Comandante = new Hobbit();
                        break;
                }
            }
            else
            {
                do
                {
                    Console.WriteLine("Ottimo, ora decidi a quale Razza appartenere: (1) per gli Orchi, (2) per gli Uruk Hai, (3) per i Sudroni.");
                    rispostaRazza = Convert.ToInt32(Console.ReadLine());
                } while (rispostaRazza < 1 || rispostaRazza > 3);

                switch (rispostaRazza)
                {
                    case 1:
                        Comandante = new Orco();
                        break;
                    case 2:
                        Comandante = new Uruk_Hai();
                        break;
                    case 3:
                        Comandante = new Sudrone();
                        break;
                }
            }

            if (Comandante != null)
            {
                Comandante.GeneraVita();
                Comandante.GeneraForza();
                Comandante.GeneraDanno();

                Comandante.Vita *= 3;
                Comandante.Forza *= 3;
                Comandante.Danno *= 3;
                Comandante.Esperienza = 5;

                Console.WriteLine("Statistiche Comandante:");
                Comandante.Stampa();
            }

            GeneraEserciti(Comandante, rispostaSchieramento);
        }

        public void GeneraEserciti(object Comandante, int schieramentoComandante)
        {
            Random random= new Random();

            
                for(int i=0;i<100; i++)
                {
                    Combattente combattente;
                    int razza=random.Next(1,5);

                    switch(razza)
                    {
                        case 1:
                            combattente= new Umano();
                            combattente.GeneraVita();
                            combattente.GeneraDanno();
                            combattente.GeneraForza();

                            listaUmani.Add((Umano)combattente);
                            break;
                        case 2:
                            combattente = new Elfo();
                            combattente.GeneraVita();
                            combattente.GeneraDanno();
                            combattente.GeneraForza();
                            listaElfi.Add((Elfo)combattente);

                            break;
                        case 3:
                            combattente = new Nano();
                            combattente.GeneraVita();
                            combattente.GeneraDanno();
                            combattente.GeneraForza();
                            listaNani.Add((Nano)combattente);

                            break;
                        case 4:
                            combattente = new Hobbit();
                            combattente.GeneraVita();
                            combattente.GeneraDanno();
                            combattente.GeneraForza();
                            listaHobbit.Add((Hobbit)combattente);

                            break;
                    }
                }

            for (int i = 0; i < 100; i++)
            {
                Combattente combattente;
                int razza = random.Next(1, 4);

                switch (razza)
                {
                    case 1:
                        combattente = new Orco();
                        combattente.GeneraVita();
                        combattente.GeneraDanno();
                        combattente.GeneraForza();

                        listaOrchi.Add((Orco)combattente);
                        break;
                    case 2:
                        combattente = new Uruk_Hai();
                        combattente.GeneraVita();
                        combattente.GeneraDanno();
                        combattente.GeneraForza();
                        listaUrukHai.Add((Uruk_Hai)combattente);

                        break;
                    case 3:
                        combattente = new Sudrone();
                        combattente.GeneraVita();
                        combattente.GeneraDanno();
                        combattente.GeneraForza();
                        listaSudroni.Add((Sudrone)combattente);

                        break;
                }
            }

        }
    }


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

    class Umano : Combattente
    {
        Random random = new Random();
        public override void GeneraVita()
        {
            Vita = random.Next(1, 16);
        }
        public override void GeneraForza()
        {
            Forza = random.Next(1, 11);
        }
        public override void AumentaEsperienza()
        {
            Esperienza++;
        }
        public override void GeneraDanno()
        {
            Danno = random.Next(1, 11);
        }
        public void Stampa()
        {
            base.Stampa();
        }
    }

    class Elfo : Combattente
    {
        Random random = new Random();
        public override void GeneraVita()
        {
            Vita = random.Next(1, 11);
        }
        public override void GeneraForza()
        {
            Forza = random.Next(1, 7);
        }
        public override void AumentaEsperienza()
        {
            Esperienza++;
        }
        public override void GeneraDanno()
        {
            Danno = random.Next(1, 21);
        }
        public void Stampa()
        {
            base.Stampa();
        }
    }

    class Nano : Combattente
    {
        Random random = new Random();
        public override void GeneraVita()
        {
            Vita = random.Next(1, 21);
        }
        public override void GeneraForza()
        {
            Forza = random.Next(1, 11);
        }
        public override void AumentaEsperienza()
        {
            Esperienza++;
        }
        public override void GeneraDanno()
        {
            Danno = random.Next(1, 6);
        }
        public void Stampa()
        {
            base.Stampa();
        }
    }

    class Hobbit : Combattente
    {
        Random random = new Random();
        public override void GeneraVita()
        {
            Vita = random.Next(1, 11);
        }
        public override void GeneraForza()
        {
            Forza = random.Next(1, 11);
        }
        public override void AumentaEsperienza()
        {
            Esperienza++;
        }
        public override void GeneraDanno()
        {
            Danno = random.Next(1, 11);
        }
        public void Stampa()
        {
            base.Stampa();
        }
    }

    class Uruk_Hai : Combattente
    {
        Random random = new Random();
        public override void GeneraVita()
        {
            Vita = random.Next(1, 21);
        }
        public override void GeneraForza()
        {
            Forza = random.Next(1, 11);
        }
        public override void AumentaEsperienza()
        {
            Esperienza++;
        }
        public override void GeneraDanno()
        {
            Danno = random.Next(1, 6);
        }
        public void Stampa()
        {
            base.Stampa();
        }
    }

    class Sudrone : Combattente
    {
        Random random = new Random();
        public override void GeneraVita()
        {
            Vita = random.Next(1, 16);
        }
        public override void GeneraForza()
        {
            Forza = random.Next(1, 11);
        }
        public override void AumentaEsperienza()
        {
            Esperienza++;
        }
        public override void GeneraDanno()
        {
            Danno = random.Next(1, 11);
        }
        public void Stampa()
        {
            base.Stampa();
        }
    }

    class Orco : Combattente
    {
        Random random = new Random();
        public override void GeneraVita()
        {
            Vita = random.Next(1, 11);
        }
        public override void GeneraForza()
        {
            Forza = random.Next(1, 7);
        }
        public override void AumentaEsperienza()
        {
            Esperienza++;
        }
        public override void GeneraDanno()
        {
            Danno = random.Next(1, 21);
        }
        public void Stampa()
        {
            base.Stampa();
        }
    }

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

    interface IBattaglione
    {
        int VitaTotale { get; set; }
        int ForzaTotale { get; set; }
        int EsperienzaTotale { get; set; }
        int DannoTotale { get; set; }

        void CalcolaVita();
        void CalcolaForza();
        void CalcolaEsperienza();
        void CalcolaDanno();
        void Stampa();
    }
}