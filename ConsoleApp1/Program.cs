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

        List<Combattente> listaUmani = new List<Combattente>();
        List<Combattente> listaElfi = new List<Combattente>();
        List<Combattente> listaNani = new List<Combattente>();
        List<Combattente> listaHobbit = new List<Combattente>();

        List<Combattente> listaOrchi = new List<Combattente>();
        List<Combattente> listaUrukHai = new List<Combattente>();
        List<Combattente> listaSudroni = new List<Combattente>();

        Battaglione battaglioneUmani = new Battaglione();
        Battaglione battaglioneElfi = new Battaglione();
        Battaglione battaglioneNani = new Battaglione();

        Battaglione battaglioneHobbit = new Battaglione();

        Battaglione battaglioneOrchi = new Battaglione();
        Battaglione battaglioneUrukHai = new Battaglione();
        Battaglione battaglioneSudroni = new Battaglione();
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
                        listaUmani.Add(Comandante);
                        break;
                    case 2:
                        Comandante = new Elfo();
                        listaElfi.Add(Comandante);
                        break;
                    case 3:
                        Comandante = new Nano();
                        listaNani.Add(Comandante);
                        break;
                    case 4:
                        Comandante = new Hobbit();
                        listaHobbit.Add(Comandante);
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
                        listaOrchi.Add(Comandante);
                        break;
                    case 2:
                        Comandante = new Uruk_Hai();
                        listaUrukHai.Add(Comandante);
                        break;
                    case 3:
                        Comandante = new Sudrone();
                        listaSudroni.Add(Comandante);
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

           

            battaglioneUmani.CalcolaVita(listaUmani);
            battaglioneUmani.CalcolaForza(listaUmani);
            battaglioneUmani.CalcolaEsperienza(listaUmani);
            battaglioneUmani.CalcolaDanno(listaUmani);
            battaglioneUmani.Razza = "umani";

            battaglioneElfi.CalcolaVita(listaElfi);
            battaglioneElfi.CalcolaForza(listaElfi);
            battaglioneElfi.CalcolaEsperienza(listaElfi);
            battaglioneElfi.CalcolaDanno(listaElfi);
            battaglioneElfi.Razza = "elfi";
            
            battaglioneNani.CalcolaVita(listaNani);
            battaglioneNani.CalcolaForza(listaNani);
            battaglioneNani.CalcolaEsperienza(listaNani);
            battaglioneNani.CalcolaDanno(listaNani);
            battaglioneNani.Razza = "nani";
            
            battaglioneHobbit.CalcolaVita(listaHobbit);
            battaglioneHobbit.CalcolaForza(listaHobbit);
            battaglioneHobbit.CalcolaEsperienza(listaHobbit);
            battaglioneHobbit.CalcolaDanno(listaHobbit);
            battaglioneHobbit.Razza = "hobbit";

            battaglioneOrchi.CalcolaVita(listaOrchi);
            battaglioneOrchi.CalcolaForza(listaOrchi);
            battaglioneOrchi.CalcolaEsperienza(listaOrchi);
            battaglioneOrchi.CalcolaDanno(listaOrchi);
            battaglioneOrchi.Razza = "orchi";

            battaglioneUrukHai.CalcolaVita(listaUrukHai);
            battaglioneUrukHai.CalcolaForza(listaUrukHai);
            battaglioneUrukHai.CalcolaEsperienza(listaUrukHai);
            battaglioneUrukHai.CalcolaDanno(listaUrukHai);
            battaglioneUrukHai.Razza = "urukHai";

            battaglioneSudroni.CalcolaVita(listaSudroni);
            battaglioneSudroni.CalcolaForza(listaSudroni);
            battaglioneSudroni.CalcolaEsperienza(listaSudroni);
            battaglioneSudroni.CalcolaDanno(listaSudroni);
            battaglioneSudroni.Razza = "sudroni";

            Console.WriteLine("È tempo di far trionfare le truppe del Bene! Portale alla vittoria Comandante!");

            MenuGuerra(schieramentoComandante);
        }

        public void MenuGuerra(int schieramentoComandante)
        {
            Random random = new Random();
            Battaglione bene = new Battaglione();
            Battaglione male = new Battaglione();
            List<Combattente> listaBene = new List<Combattente>();
            List<Combattente> listaMale = new List<Combattente>();

            int attaccoComandante;
            int attaccoNemico;
            if(schieramentoComandante== 1) 
            {

                do
                {
                    Console.WriteLine("Decidi con quale Battaglione attaccare: (1) per gli Umani, (2) per gli Elfi, (3) per i Nani, (4) per gli Hobbit.");
                    attaccoComandante = Convert.ToInt32(Console.ReadLine());
                } while (attaccoComandante < 1 || attaccoComandante > 4);

                switch (attaccoComandante)
                {
                    case 1:
                        bene = battaglioneUmani;
                        listaBene = listaUmani;
                        break;
                    case 2:
                        bene = battaglioneElfi;
                        listaBene = listaElfi;
                        break;
                    case 3:
                        bene = battaglioneNani;
                        listaBene = listaNani;
                        break;
                    case 4:
                        bene = battaglioneHobbit;
                        listaBene = listaHobbit;
                        break;
                }

                attaccoNemico = random.Next(1, 4);

                switch(attaccoNemico)
                {
                    case 1:
                        male = battaglioneOrchi;
                        listaMale= listaOrchi;
                        break;
                    case 2:
                        male = battaglioneUrukHai;
                        listaMale= listaUrukHai;
                        break;
                    case 3:
                        male = battaglioneSudroni;
                        listaMale= listaSudroni;
                        break;
                }

                bool bene_male = true;
                Console.WriteLine("STATISTICHE PRE-BATTAGLIA");
                bene.Stampa();
                male.Stampa();
                Scontro(bene, male, listaBene, listaMale, schieramentoComandante,bene_male);
            }
        }

        public void Scontro(Battaglione attaccanti, Battaglione difensori,List<Combattente>listaAttaccanti,List<Combattente> listaDifensori, int SC, bool bene_male)
        {
            int dannoInflitto;
            double moltiplicatoreAttacco = 0;
            int mediaPre = difensori.MediaVita;
            //calcolo moltiplicatore
            if (attaccanti.ForzaTotale > difensori.ForzaTotale)
            {
                moltiplicatoreAttacco += 50;
            }

            if (attaccanti.EsperienzaTotale > difensori.EsperienzaTotale)
            {
                moltiplicatoreAttacco += 25;
            }

            if((attaccanti.Razza=="elfi" && difensori.Razza=="urukHai") || (attaccanti.Razza == "nani" && difensori.Razza == "sudroni") || (attaccanti.Razza == "umani" && difensori.Razza == "orchi"))
            {
                moltiplicatoreAttacco += 50;
                Console.WriteLine("Vantaggio Razza Bene");
            }else if((attaccanti.Razza == "orchi" && difensori.Razza == "nani") || (attaccanti.Razza == "urukHai" && difensori.Razza == "umani") || (attaccanti.Razza == "sudroni" && difensori.Razza == "elfi"))
            {
                moltiplicatoreAttacco += 50;
                Console.WriteLine("Vantaggio Razza Male");
            }

            //calcolo danni
            Console.WriteLine("Moltiplicatore Attacco:"+ moltiplicatoreAttacco);
            dannoInflitto = Convert.ToInt32(attaccanti.DannoTotale * (moltiplicatoreAttacco / 100));
            dannoInflitto=attaccanti.DannoTotale + Convert.ToInt32(dannoInflitto);
            Console.WriteLine("Danni inflitti:" + dannoInflitto);

            //sottraggo i danni alla vita
            difensori.VitaTotale -= dannoInflitto;

            ////ricalcolo statistiche dei difensori
            //Console.WriteLine(listaDifensori.Count);
            //while (difensori.VitaTotale / listaDifensori.Count < mediaPre)
            //{
            //    Console.WriteLine("Ricalcolo Statistiche...");
            //    listaDifensori.RemoveAt(listaDifensori.Count - 1);
            //    difensori.CalcolaMedia(listaDifensori);
            //    difensori.CalcolaForza(listaDifensori);
            //    difensori.CalcolaEsperienza(listaDifensori);
            //    difensori.CalcolaDanno(listaDifensori);
            //}
            //Console.WriteLine(listaDifensori.Count);

            

            //controllo se devono e possono attaccare i difensori
            if (bene_male && difensori.VitaTotale>0)
            {
                bene_male= false;
                Scontro(difensori,attaccanti,listaDifensori,listaAttaccanti, SC, bene_male);
            }
            //stampo i risultati e ritorno al menu
            Console.WriteLine("STATISTICHE POST-BATTAGLIA");
            difensori.Stampa();
            attaccanti.Stampa();
            MenuGuerra(SC);
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

    class Battaglione : IBattaglione 
    {
        public int VitaTotale { get; set; }
        public int MediaVita { get; set; }
        public int ForzaTotale { get; set; }
        public int EsperienzaTotale { get; set; }
        public int DannoTotale { get; set; }
        public string Razza { get; set; }


        public void CalcolaVita(List<Combattente> listaSoldati)
        {
            VitaTotale = 0;
            foreach(var s in listaSoldati)
            {
                VitaTotale += s.Vita;
            }
        }

        public void CalcolaMedia(List<Combattente> listaSoldati)
        {
            MediaVita = VitaTotale / listaSoldati.Count;
        }
        public void CalcolaForza(List<Combattente> listaSoldati)
        {
            ForzaTotale= 0;
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
                DannoTotale += (s.Danno/2);
            }
        }
        public void Stampa()
        {
            Console.WriteLine("Statistiche battaglione {0}:",Razza);
            Console.WriteLine($"Vita: {VitaTotale}, Forza: {ForzaTotale}, Esperienza: {EsperienzaTotale}, Danno: {DannoTotale}, Razza: {Razza}");
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
        int MediaVita { get; set; }
        int ForzaTotale { get; set; }
        int EsperienzaTotale { get; set; }
        int DannoTotale { get; set; }
        string Razza { get;set; }

        void CalcolaVita(List<Combattente> listaSoldati);
        void CalcolaForza(List<Combattente> listaSoldati);
        void CalcolaEsperienza(List<Combattente> listaSoldati);
        void CalcolaDanno(List<Combattente> listaSoldati);
        void CalcolaMedia(List<Combattente> listaSoldati);
        void Stampa();
    }
}