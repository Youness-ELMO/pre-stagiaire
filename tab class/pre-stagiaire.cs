using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tab_class
{
    class tss
    {
        public string nom;
        public string prenom;
        public string age;
        public string genre;

        public void affichage()
        {
            Console.WriteLine("\n\nnom {0}  \nprenom {1}  \nage {2}   \ngenre  {3}\n", nom, prenom, age, genre);
        }
    }
}
