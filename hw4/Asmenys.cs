using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw4
{
    public class Asmenys
    {
        public List<string> Vardas { get; set; }

        public Asmenys() { }

        public Asmenys(List<string> Vardas)
        {
            this.Vardas = Vardas;
        }
        
        public class VaikasException : Exception
        {
            public string Vardas { get; set; }
            public int Amzius { get; set; }
            public VaikasException(string Vardas, int Amzius)
            {
                this.Vardas = Vardas;
                this.Amzius = Amzius;
                Console.WriteLine("{0} yra vaikas jam(-ai) yra {1} metai", Vardas, Amzius);
            }
        }

        public class PensininkasException : Exception
        {
            public string Vardas { get; set; }
            public int Amzius { get; set; }
            public PensininkasException(string Vardas, int Amzius)
            {
                this.Vardas = Vardas;
                this.Amzius = Amzius;
                Console.WriteLine("{0} yra pensininkas jam(-ai) yra {1} metai", Vardas, Amzius);
            }
        }
    }

}

