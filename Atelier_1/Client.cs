using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier_1
{
    class Client
    {
        private string nom;
        private string prenom;
        private string adress;

        public Client()
        {
            nom = "";
            prenom = "";
            adress = "";
        }
        public Client(string n,string p,string a)
        {
            nom = n;
            prenom = p;
            adress = a;
        }
        public void affiche_c()
        {
            Console.WriteLine(nom);
            Console.WriteLine(prenom);
            Console.WriteLine(adress);
        }
    }
}
