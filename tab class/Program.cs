using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tab_class
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("donner le nombre de personne: ");
            int n = int.Parse(Console.ReadLine());
            string[] tab = new string[n];

           

            for (int i=0; i<n; i++)
            {
                tss p1 = new tss();
                Console.Write("donner le nom: ");
                tab[i] = p1.nom = Console.ReadLine();
                Console.Write("donner le prenom: ");
                tab[i] = p1.prenom = Console.ReadLine();
                Console.Write("donner le genre: ");
                tab[i] = p1.genre = Console.ReadLine();
                Console.Write("donner l'age: ");
                tab[i] = p1.age = Console.ReadLine();

                p1.affichage();
                
            }
            for (int i = 0; i < n - 1; i++)
            {
                Console.WriteLine("FIN !! " + tab[i]);

            }




            Console.ReadKey();

        }
    }
}
