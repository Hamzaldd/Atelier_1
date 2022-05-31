using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Client Cl1 = new Client("client1","client1","add");
            Client Cl2 = new Client("client2","client2","add");
            MAD M = new MAD(1200);
            MAD r = new MAD(200);
            MAD plaf = new MAD(500);
            Compte C1 = new Compte(Cl1,M);
            Compte C2 = new Compte(Cl2,M);
            C1.Affiche();
            C2.Affiche();
            C1.virement(r,plaf,C2);
            C1.Affiche();
            C2.Affiche();
            Console.ReadLine();
        }
    }
}
