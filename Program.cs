using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace pripremaZaIspitZadatak7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("unesite neku rijec: ");
            string rijec = Console.ReadLine();
            if(rijec.Length < 5)
            {
                Console.WriteLine(rijec);

            }
            else
            {
                Console.WriteLine(rijec.Substring(2, rijec.Length - 4));
            }
            Console.ReadKey();
        }
    }
}
