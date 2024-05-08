using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kolko chisla shte vuvejdash: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Kolko puti shte zavurta: ");
            int k=int.Parse(Console.ReadLine());
            int[] chisla = new int[k];
            int[] sum=new int[n];
            for (int i=0; i<5; i++) 
            {
               Console.WriteLine("Kolko chisla shte vuvejdash: ");
                chisla[i]=int.Parse(Console.ReadLine());
                sum[i] = 0;
            }
            //for (int r=0; r<k; r++) 
            //{
               // for (int i=0; i<n;i++) 
                //{
                  //  sum[i] = 0;
                    //sum[i]=(i + r) % n;
                    //Console.WriteLine(sum[i]);
                //}
            //}
           // for (int i=0; i<k;i++) 
            //{
              //  Console.WriteLine(sum[i]);
                //sum[i]=int.Parse(Console.ReadLine()) ;
            //}
            //vhod
            int[] chisla2 = new int[5];
            for (int i=0; i<5; i++) 
            {
                Console.Write("Vuvedi chisla: ");
                chisla2[i] = int.Parse(Console.ReadLine());
            }
            // izhod 
            for (int i=0; i < 5; i++) 
            {
                Console.WriteLine(chisla2[i]);
            }
            Console.WriteLine("izhod bez posleden element:");
            for (int i = 0; i < 4; i++)
            {
                Console.Write(chisla[i]);
               
            }
            for (int i=0;i<1+4; i++) 
            {
                Console.WriteLine(chisla[i]);
                
            }
        }
    }
}
