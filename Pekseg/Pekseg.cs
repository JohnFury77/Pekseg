using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pekseg
{
    class Pekseg
    {
        private string nev;
        private List<Pekaru> termekek = new List<Pekaru>();
        private DateTime alapitva;

        public Pekseg(string nev, DateTime alapitva)
        {
            this.Nev = nev;
            this.termekek = new List<Pekaru>();
            this.Alapitva = alapitva;
        }

        public override string ToString()
        {
            return String.Format($"{this.nev}-{this.alapitva}");
        }

        public string Nev { get => nev; set => nev = value; }
        public DateTime Alapitva { get => alapitva; set => alapitva = value; }
        public void SetTermekek(Pekaru p)
        {
            termekek.Add(p);
        }

        public List<Pekaru> GetTermekek()
        {
            return this.termekek;
        }


    }
}
