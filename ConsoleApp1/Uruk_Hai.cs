using System;

namespace LoR
{
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
}