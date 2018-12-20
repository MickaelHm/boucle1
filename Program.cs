using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boucle1
{
    class Program
    {
        static void Main(string[] args)
        {
            int loop = 0;
            while (loop < 10)//on continue la boucle tant qu'elle n'a pas atteint 10 révolutions.
            {
                Console.WriteLine("Bonjour, je ne suis qu'un simple message.");
                loop++;//on incrémente la boucle à chaque révolution.
            }
            /*Deuxieme méthode:
            int count = 0;
            do
            {
                Console.WriteLine("Bonjour, je ne suis qu'un simple message.");
                count++;//on incrémente la boucle à chaque révolution.
            }
            while (count < 10); 
            ici l'instruction sera effectuée au moins une fois même si le count part de 10+*/
        }
    }
}
