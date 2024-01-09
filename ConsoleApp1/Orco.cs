using System;

namespace LoR
{
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
}