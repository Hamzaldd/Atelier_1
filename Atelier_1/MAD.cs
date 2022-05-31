using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier_1
{
    class MAD
    {
        private  double somme;
        public MAD()
        {
            somme = 0;
        }
        public MAD(double s)
        {
            somme = s;
        }
        public  static MAD operator-(MAD x1, MAD x2)
        {
            return new MAD(x1.somme -x2.somme) ;
        }
        public static MAD operator +(MAD x1, MAD x2)
        {
            return new MAD(x1.somme + x2.somme);
        }
        public static Boolean operator <=(MAD x1, MAD x2)
        {
            if (x1.somme <= x2.somme) { 
            return true;
            }
            return false;
        }
        public static Boolean operator >=(MAD x1, MAD x2)
        {
            if (x1.somme >= x2.somme)
            {
                return true;
            }
            return false;
        }
        public void affiche_s()
        {
            Console.WriteLine(somme);
   
        }
    }
}
