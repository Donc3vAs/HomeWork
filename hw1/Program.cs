using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw1
{
    class Program
    {
        static void Main(string[] args)
        {
            Klase clasyte = new Klase(5, 'c', 6, new DateTime(year: 2005, month: 12, day: 15),
                new List<string>() { "Aras", "Marius", "Jonas", "Juozas", "Jaronimas", "Arvydas" },
                new int[6] { 9, 8, 7, 5, 8, 9 }); 
                
            Console.WriteLine(clasyte.KaipIlgaiMokos()); 
        }
    }
}
