using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entitati
{
    public class CriteriuCategorie : ICriteriu
    {
        string categorie;

        public CriteriuCategorie(string categorie)
        {
            this.categorie = categorie;
        }

        public bool IsIndeplinit(ProdusAbstract p)
        {
            if ((p.Categorie).Equals(this.categorie))
                return true;
            return false;
        }
    }
}
