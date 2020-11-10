using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pekseg
{
    class Pekseg
    {
        string nev;
        List<Pekaru> termekek = new List<Pekaru>();
        DateTime alapitva;

        public Pekseg(string nev, List<Pekaru> termekek, DateTime alapitva)
        {
            this.nev = nev;
            this.termekek = termekek;
            this.alapitva = alapitva;
        }

        public override string ToString()
        {
            return String.Format($"{this.nev}-{this.alapitva}");
        }

        public string Nev { get => nev; set => nev = value; }
        public DateTime Alapitva { get => alapitva; set => alapitva = value; }
        internal List<Pekaru> Termekek { get => termekek; set => termekek = value; }

        
    }
}
