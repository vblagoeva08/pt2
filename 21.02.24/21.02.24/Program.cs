using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21._02._24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //zadelqne na pamet
            string b=Console.ReadLine();
            string[] buk = new string[3];
            //vhod 
            for (int i=0; i<3; i++) 
            {
                buk[i] = Console.ReadLine();
            }
            //izhod
            for (int i=0; i<3;i--) 
            {
                Console.WriteLine(buk[i]);
            }

        }
    }
}
