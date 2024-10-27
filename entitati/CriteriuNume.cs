using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entitati
{
    public class CriteriuNume : ICriteriu
    {
        string nume;

        public CriteriuNume(string nume)
        {
            this.nume = nume;
        }
        public bool IsIndeplinit(ProdusAbstract p)
        {
            if ((p.Nume).Equals(this.nume))
                return true;
            return false;
        }
    }
}
