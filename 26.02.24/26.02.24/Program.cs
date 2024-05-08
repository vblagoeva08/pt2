
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _26._02._24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kolko danni shte vuvejdash: ");
            int n = int.Parse(Console.ReadLine());
            string[] pitie = new string[n];
            double[]  num= new double[n];
            double[] cena= new double[n];
            
            for (int i = 0; i < n; i++) 
            {
                Console.Write("Ime na pitie: ");
                pitie[i] = Console.ReadLine();
                Console.Write("Kolko pitieta shte izpiesh?: ");
                num[i] = double.Parse(Console.ReadLine());
                Console.Write("Kolko struva?: ");
                cena[i]= double.Parse(Console.ReadLine());
            }
            //izhod1
            for (int i = 0;i < n; i++) 
            {
                Console.WriteLine(pitie[i] + "/" + num[i] + "/" + cena[i]);
            }
            //izhod2
            for(int i = 0; ; i++) 
            {
                if (num[n] > 2) 
                {
                    Console.WriteLine(pitie[i] + "/" + num[i] + "/" + cena[i]);
                }
            }
            //izhod3

            for (int i = 0; i < n; i++)
            {
                if (cena[i] > 2)
                {
                    Console.WriteLine(pitie[i] + "/" + num[i] + "/" + cena[i]);
                }
            }
            //izhod4
            Array.Sort(pitie);
            for(int i = 0; i < n;) 
            {
                Console.WriteLine(pitie[i] + "/" + num[i] + "/" + cena[i]);
            }
            //izhod6
            Console.WriteLine(pitie[0]);
            Console.WriteLine(num[1]);
            Console.WriteLine(cena[2]);
            //izhod7
            for(int i = 0;i< n; i++) 
            {
                Console.WriteLine(pitie[i]);
                Console.WriteLine(pitie[i] + "/" + num[i] + "/" + cena[i]);
            }
        }
    }
}
