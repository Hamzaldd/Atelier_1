using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier_1
{
    class Compte
    {
        private static int cpt = 0;
        private readonly int num;
        private Client C;
        private MAD solde;

        public Compte()
        {
            num = cpt++;
        }
        public Compte(Client c,MAD s)
        {
            num = cpt++;
            C = c;
            solde = s;
        }
        public void Affiche()
        {
            Console.WriteLine(num);
            C.affiche_c();
            solde.affiche_s();
        }
        public void Credite(MAD s)
        {
            this.solde = s + this.solde;
        }
        public void Debiter(MAD s,MAD plafond)
        {
            if (s <= plafond)
            this.solde =  this.solde - s;
        }
        public void virement(MAD s, MAD plafond, Compte V)
        {
            this.Debiter(s, plafond);
            V.Credite(s);
        }
    }
}
