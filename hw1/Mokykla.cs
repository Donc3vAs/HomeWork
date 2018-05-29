using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw1
{
    public class Mokykla
    {
        public int Klase { get; set; }
        public char KlasesRaide { get; set; }
        public int MokiniuSkaicius { get; set; }
        public DateTime PradziosMetai { get; set; }

        public Mokykla()
        {

        }

        public int KaipIlgaiMokos()
        {
            return DateTime.Today.Year - PradziosMetai.Year;
        }

        public Mokykla(int Kalse, char KlasesRaide, int MokiniuSkaicius, DateTime PradziosMetai)
        {
            this.Klase = Klase;
            this.KlasesRaide = KlasesRaide;
            this.MokiniuSkaicius = MokiniuSkaicius;
            this.PradziosMetai = PradziosMetai;
        }

    }
}
