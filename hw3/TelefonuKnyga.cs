using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw3
{
    public class TelefonuKnyga
    {
        public string Vardas { get; set; }
        public string Pavarde { get; set; }
        public string Numeris { get; set; }

        public TelefonuKnyga() { }

        public TelefonuKnyga(string Vardas, string Pavarde, string Numeris)
        {
            this.Vardas = Vardas;
            this.Pavarde = Pavarde;
            this.Numeris = Numeris;
        }
    }
}
