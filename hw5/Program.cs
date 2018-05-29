using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw5
{
    class Adresatai
    {
        public delegate void DovanuParinkimoDelegate();

        public List<string> AdresatuSarasas { get; set; }

        public Adresatai(List<string> AdresatuSarasas)
        {
            this.AdresatuSarasas = AdresatuSarasas;
        }

        public Adresatai() { }

        //Dovanos priskirimas adresatams
        public void PridetiDovana(DovanuParinkimoDelegate dovana)
        {
            foreach (var item in AdresatuSarasas)
            {
                Console.Write("{0} dovanosime ", item);
                dovana();
            }
        }
    }

    class Dovanos
    {
        public void Puodelis()
        {
            Console.WriteLine("puodeli");
        }
        public void Zenkliukas()
        {
            Console.WriteLine("zenkliuka");
        }
        public void Tusinukas()
        {
            Console.WriteLine("tusinuka");
        }
    }
   

    class Program
    {
        

        static void Main(string[] args)
        {
            //biudžeto ivedimas
            Console.WriteLine("Iveskite koks biudzetas");
            int biudzetas = int.Parse(Console.ReadLine()); 
            
            //Is failo paima adresatus
            Adresatai adresatai = new Adresatai(System.IO.File.ReadAllLines("Adresatai.txt").ToList<string>());
            Dovanos dovana = new Dovanos();

            //Dovanos parinkimas pagal biudžiata.
            if (biudzetas - 10 * adresatai.AdresatuSarasas.Count > 2000)
            {
                adresatai.PridetiDovana(dovana.Puodelis);
            }
            else if (biudzetas - 10 * adresatai.AdresatuSarasas.Count < 2000 && biudzetas - 10 * adresatai.AdresatuSarasas.Count > 1500)
            {
                adresatai.PridetiDovana(dovana.Zenkliukas);
            }
            else
                adresatai.PridetiDovana(dovana.Tusinukas);




        }
    }
}
