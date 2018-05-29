using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw2
{
    interface IGyvunas
    {
        string Vardas { get; set; }
        void GyvunoInfo();
    }
    class Zuvys : IGyvunas
    {
        public string Vardas { get; set; }

        public Zuvys()
        {

        }

        public Zuvys (string Vardas)
        {
            this.Vardas = Vardas;
        }

        public void GyvunoInfo()
        {
            Console.WriteLine("{0} yra vandens gyvunas", Vardas);
        }
    }
    class Kates : IGyvunas
    {
        public string Vardas { get; set; }

        public Kates()
        {

        }

        public Kates(string Vardas)
        {
            this.Vardas = Vardas;
        }

        public void GyvunoInfo()
        {
            Console.WriteLine("{0} yra mielas", Vardas);
        }
    }
    class Pauksciai : IGyvunas
    {
        public string Vardas { get; set; }

        public Pauksciai()
        {

        }

        public Pauksciai(string Vardas)
        {
            this.Vardas = Vardas;
        }

        public void GyvunoInfo()
        {
            Console.WriteLine("{0} yra skraidantis gyvenas", Vardas);
        }
    }
}
