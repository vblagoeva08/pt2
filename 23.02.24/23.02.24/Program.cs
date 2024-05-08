using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23._02._24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //zadelqne na danni
            string[] predmet = new string[3];
            double[] chas = new double[3];
            //vhod
            Console.WriteLine("vhod");
            for (int i = 0; i < 3 ; i++) 
            {
             Console.Write("Vuvedi predmet: ");  
              predmet[i] = Console.ReadLine();
             Console.Write("Vuvedi chas: " );
                chas[i]=double.Parse(Console.ReadLine());
            }
            //izhod 1
            Console.WriteLine("izhod 1");
            for (int i=0;i<3; i++) 
            {
            Console.WriteLine("Chas " + chas[i] + " predmet " + predmet[i]);
            }
            //izhod 2
            Console.WriteLine("izhod2 nad i 4");
            for (int i = 0;i<3 ;i++) 
            { 
                if (chas[i]>=4) 
                {
                Console.WriteLine("Chas " + chas[i]+" predmet " + predmet[i]);
                }
                
            }
            // izhod 3
            Console.WriteLine("izhod 3 sortirane ot malko kum golqmo");
            Array.Sort(chas);
             for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Chas " + chas[i] + " predmet " + predmet[i]);
            }
             //izhod 4
            Console.WriteLine("izhod 4 srot predmet");
            Array.Sort (predmet);
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Chas " + chas[i] + " predmet " + predmet[i]);
            }
            //izhod 5
            Console.WriteLine("izhod 5 reverse");
            Array.Reverse(predmet);
            Array.Sort(predmet);
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Chas " + chas[i] + " predmet " + predmet[i]);
            }
            //izhod 6
            Console.WriteLine("Izhod 6");
            string nov_predmet = "matematika";
            for (int i = 0; i < 3; i++)
            {
                if (predmet[i] == nov_predmet) 
                {
                    Console.WriteLine("Chas " + chas[i] + " predmet " + predmet[i]);
                }
                
            }
            //izhod 7
            Console.WriteLine("izhod 7");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Chas " + chas[1] + " predmet " + predmet[1]);
            }
        }
    }
}
