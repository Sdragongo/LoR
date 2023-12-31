﻿using System;

namespace LoR
{
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

            GeneraEserciti(Comandante, rispostaSchieramento, rispostaRazza);
        }

        public void GeneraEserciti(object Comandante, int schieramentoComandante, int razzaComandante)
        {
            Random random = new Random();


            for (int i = 0; i < 100; i++)
            {
                Combattente combattente;
                int razza = random.Next(1, 5);

                switch (razza)
                {
                    case 1:
                        combattente = new Umano();
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
            battaglioneUmani.CalcolaMedia(listaUmani);
            battaglioneUmani.Razza = "umani";

            battaglioneElfi.CalcolaVita(listaElfi);
            battaglioneElfi.CalcolaForza(listaElfi);
            battaglioneElfi.CalcolaEsperienza(listaElfi);
            battaglioneElfi.CalcolaDanno(listaElfi);
            battaglioneElfi.CalcolaMedia(listaElfi);
            battaglioneElfi.Razza = "elfi";

            battaglioneNani.CalcolaVita(listaNani);
            battaglioneNani.CalcolaForza(listaNani);
            battaglioneNani.CalcolaEsperienza(listaNani);
            battaglioneNani.CalcolaDanno(listaNani);
            battaglioneNani.CalcolaMedia(listaNani);
            battaglioneNani.Razza = "nani";

            battaglioneHobbit.CalcolaVita(listaHobbit);
            battaglioneHobbit.CalcolaForza(listaHobbit);
            battaglioneHobbit.CalcolaEsperienza(listaHobbit);
            battaglioneHobbit.CalcolaDanno(listaHobbit);
            battaglioneHobbit.CalcolaMedia(listaHobbit);
            battaglioneHobbit.Razza = "hobbit";

            battaglioneOrchi.CalcolaVita(listaOrchi);
            battaglioneOrchi.CalcolaForza(listaOrchi);
            battaglioneOrchi.CalcolaEsperienza(listaOrchi);
            battaglioneOrchi.CalcolaDanno(listaOrchi);
            battaglioneOrchi.CalcolaMedia(listaOrchi);
            battaglioneOrchi.Razza = "orchi";

            battaglioneUrukHai.CalcolaVita(listaUrukHai);
            battaglioneUrukHai.CalcolaForza(listaUrukHai);
            battaglioneUrukHai.CalcolaEsperienza(listaUrukHai);
            battaglioneUrukHai.CalcolaDanno(listaUrukHai);
            battaglioneUrukHai.CalcolaMedia(listaUrukHai);
            battaglioneUrukHai.Razza = "urukHai";

            battaglioneSudroni.CalcolaVita(listaSudroni);
            battaglioneSudroni.CalcolaForza(listaSudroni);
            battaglioneSudroni.CalcolaEsperienza(listaSudroni);
            battaglioneSudroni.CalcolaDanno(listaSudroni);
            battaglioneSudroni.CalcolaMedia(listaSudroni);
            battaglioneSudroni.Razza = "sudroni";

            Console.WriteLine("È tempo di far trionfare le truppe del Bene! Portale alla vittoria Comandante!");

            MenuGuerra(schieramentoComandante, razzaComandante);
        }

        public void MenuGuerra(int schieramentoComandante, int razzaComandante)
        {
            Battaglione battaglioneComandante = new Battaglione();
            Random random = new Random();
            Battaglione bene = new Battaglione();
            Battaglione male = new Battaglione();
            List<Combattente> listaBene = new List<Combattente>();
            List<Combattente> listaMale = new List<Combattente>();
            if (schieramentoComandante == 1)
            {
                switch (razzaComandante)
                {
                    case 1:
                        battaglioneComandante = battaglioneUmani;
                        break;
                    case 2:
                        battaglioneComandante = battaglioneElfi;
                        break;
                    case 3:
                        battaglioneComandante = battaglioneNani;
                        break;
                    case 4:
                        battaglioneComandante = battaglioneHobbit;
                        break;
                }
            }
            else
            {
                switch (razzaComandante)
                {
                    case 1:
                        battaglioneComandante = battaglioneOrchi;
                        break;
                    case 2:
                        battaglioneComandante = battaglioneUrukHai;
                        break;
                    case 3:
                        battaglioneComandante = battaglioneSudroni;
                        break;
                }
            }


            if (battaglioneSudroni.VitaTotale <= 0 || battaglioneOrchi.VitaTotale <= 0 || battaglioneUrukHai.VitaTotale <= 0)
            {
                Console.WriteLine("Hai vinto!");
            }
            else if (battaglioneComandante.VitaTotale <= 0)
            {
                Console.WriteLine("il tuo battaglione è stato sconfitto e sei perito in battaglia, hai perso.");
            }
            else
            {
                int attaccoComandante;
                int attaccoNemico;
                if (schieramentoComandante == 1)
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

                    switch (attaccoNemico)
                    {
                        case 1:
                            male = battaglioneOrchi;
                            listaMale = listaOrchi;
                            break;
                        case 2:
                            male = battaglioneUrukHai;
                            listaMale = listaUrukHai;
                            break;
                        case 3:
                            male = battaglioneSudroni;
                            listaMale = listaSudroni;
                            break;
                    }

                    bool bene_male = true;
                    Console.WriteLine("STATISTICHE PRE-BATTAGLIA");
                    bene.Stampa();
                    male.Stampa();
                    Scontro(bene, male, listaBene, listaMale, schieramentoComandante, razzaComandante, bene_male);
                }
            }
        }

        public void Scontro(Battaglione attaccanti, Battaglione difensori, List<Combattente> listaAttaccanti, List<Combattente> listaDifensori, int SC, int RC, bool bene_male)
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

            if ((attaccanti.Razza == "elfi" && difensori.Razza == "urukHai") || (attaccanti.Razza == "nani" && difensori.Razza == "sudroni") || (attaccanti.Razza == "umani" && difensori.Razza == "orchi"))
            {
                moltiplicatoreAttacco += 50;
                Console.WriteLine("Vantaggio Razza Bene");
            }
            else if ((attaccanti.Razza == "orchi" && difensori.Razza == "nani") || (attaccanti.Razza == "urukHai" && difensori.Razza == "umani") || (attaccanti.Razza == "sudroni" && difensori.Razza == "elfi"))
            {
                moltiplicatoreAttacco += 50;
                Console.WriteLine("Vantaggio Razza Male");
            }

            //calcolo danni
            Console.WriteLine("Moltiplicatore Attacco:" + moltiplicatoreAttacco);
            dannoInflitto = Convert.ToInt32(attaccanti.DannoTotale * (moltiplicatoreAttacco / 100));
            dannoInflitto = attaccanti.DannoTotale + Convert.ToInt32(dannoInflitto);
            Console.WriteLine("Danni inflitti:" + dannoInflitto);

            //sottraggo i danni alla vita
            difensori.VitaTotale -= dannoInflitto;

            if (difensori.VitaTotale > 0)
            {
                //ricalcolo statistiche dei difensori
                Console.WriteLine(mediaPre);
                int soldatiSconfitti = dannoInflitto / mediaPre;
                for (int i = 0; i < soldatiSconfitti; i++)
                {
                    listaDifensori.RemoveAt(listaDifensori.Count - 1);
                }
                difensori.CalcolaMedia(listaDifensori);
                difensori.CalcolaForza(listaDifensori);
                difensori.CalcolaEsperienza(listaDifensori);
                difensori.CalcolaDanno(listaDifensori);



                //controllo se devono e possono attaccare i difensori
                if (bene_male && difensori.VitaTotale > 0)
                {
                    bene_male = false;
                    Scontro(difensori, attaccanti, listaDifensori, listaAttaccanti, SC, RC, bene_male);
                }
            }
            else
            {
                listaDifensori.Clear();
                difensori.CalcolaMedia(listaDifensori);
                difensori.CalcolaForza(listaDifensori);
                difensori.CalcolaEsperienza(listaDifensori);
                difensori.CalcolaDanno(listaDifensori);
            }
            //stampo i risultati e ritorno al menu
            Console.WriteLine("STATISTICHE POST-BATTAGLIA");
            difensori.Stampa();
            attaccanti.Stampa();
            MenuGuerra(SC, RC);
        }
    }
}