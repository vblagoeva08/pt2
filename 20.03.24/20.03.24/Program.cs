using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20._03._24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> a =Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            for (int index = 0;index< a.Count;index++) 
            {
                a.Add(int.Parse(Console.ReadLine()));
                if (a[index]%2==0)
                    Console.WriteLine("a= "+a[index]);
            }
            for (int index = 0; index< a.Count;index++) 
            {
                a.Add(int.Parse(Console.ReadLine()));
                if (a[index]%2==1) 
                    Console.WriteLine("a= "+a[index]);
            }
        }
    }
}
