using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static hw4.Asmenys;

namespace hw4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = System.IO.File.ReadAllLines("Asmenys.txt");
            List<string> sarasiukas = new List<string>();
            Asmenys asmenys = new Asmenys();
            
            // pasako kas saraše vaikas kas pensininkas
            for (int i = 0; i < lines.Length; i++)
            {
                try
                {
                    asmenys = new Asmenys(sarasiukas);
                    string[] iskyrimas = lines[i].Split(' ');
                    if (int.Parse(iskyrimas[1]) < 18)
                        throw new VaikasException(iskyrimas[0], int.Parse(iskyrimas[1]));
                    if (int.Parse(iskyrimas[1]) >= 65)
                        throw new PensininkasException(iskyrimas[0], int.Parse(iskyrimas[1]));
                    asmenys.Vardas.Add(lines[i]);
                }
                catch (VaikasException)
                {                    
                }
                catch (PensininkasException)
                {
                }
            }
        }

    }
}
