using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25._03._24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] pitie = new string[n];
            int[] kol=new int[n];
            int[] br=new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Kakvo pitie piesh: ");
                pitie[i] = Console.ReadLine();
                Console.Write("Kakvo kolichestvo: ");
                kol[i] = int.Parse(Console.ReadLine());
                Console.Write("Kolko broq: ");
                br[i] = int.Parse(Console.ReadLine());
            }    
            
            for(int i=0; i < n; i++) 
            {
                Console.WriteLine("Ti piesh "+ pitie[i] + " samo " + br[i] +" broiki ");
                int.Parse(Console.ReadLine());
            }
        }
    }
}
