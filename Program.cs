using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Zad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Napišite program koji će zatražiti od korisnika da unese dva stringa, te će ih ispisati po 
            abecedi u uzlaznom redoslijedu.*/

            Console.WriteLine("Upisi te 2 stringa:");
            string prvi = Console.ReadLine(), drugi = Console.ReadLine();
            char prvi_char = Convert.ToChar(prvi.Remove(1)), drugi_char = Convert.ToChar(drugi.Remove(1));
            if (prvi_char < drugi_char)
            {
                Console.WriteLine("{0} \n{1}", prvi, drugi);
            }
            else
            {
                Console.WriteLine("{0} \n{1}", drugi, prvi);
            }
            
            Console.ReadKey();

        }
    }
}
