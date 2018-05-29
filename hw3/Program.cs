using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace hw3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rng = new Random();

            // failai su daugybe vardu ir pavardziu
            string[] Names = System.IO.File.ReadAllLines("Names.txt");
            string[] Surnames = System.IO.File.ReadAllLines("Surnames.txt");

            // papraso kiek norima kontaktu, kad butu telefono knygoje:
            Console.WriteLine("Iveskite kiek norite, kad butu kontaktu");
            int kontaktu_skaicius = int.Parse(Console.ReadLine());
            
            //Knygos sukurimas:
            var telefonuKnyga = new List<TelefonuKnyga>();
            string num = "+370";

            for (int i = 0; i < kontaktu_skaicius; i++)
            {
                //Telefono Nr.
                for (int k = 0; k < 6; k++)   
                {
                    num += rng.Next(0, 10);
                }

                telefonuKnyga.Add(new TelefonuKnyga(Names[rng.Next(Names.Length)], Surnames[rng.Next(Surnames.Length)], num));

                num = "+370";
            }

            //Knygos atvaizdavimas:
            for (int i = 0; i < telefonuKnyga.Count; i++)
            {
                Console.WriteLine("{0} {1} {2}", telefonuKnyga[i].Vardas, telefonuKnyga[i].Pavarde, telefonuKnyga[i].Numeris);
            }
        }

    }
}

