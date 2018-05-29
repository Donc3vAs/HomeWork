using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw1
{
    public class Klase : Mokykla
    {
        public List<string> MokiniuiVardai { get; set; }
        public int[] MokiniuVidurkiai { get; set; }
        

        public Klase()
        {

        }
        public Klase(int Klase, char KlasesRaide, int MokiniuSkaicius, DateTime PradziosMetai, List<string> MokiniuiVardai, int[] MokiniuVidurkiai) 
            : base (Klase, KlasesRaide, MokiniuSkaicius, PradziosMetai)
        {
            this.MokiniuiVardai = MokiniuiVardai;
            this.MokiniuVidurkiai = MokiniuVidurkiai;
        }
    }
}
