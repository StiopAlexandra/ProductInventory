using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entitati
{
    public class FiltrareCriteriu : IFiltrare
    {
        public IEnumerable<ProdusAbstract> Filtrare(List<ProdusAbstract> colectie, ICriteriu c)
        {
            IEnumerable<ProdusAbstract> interogare =
                    from item in colectie
                    where c.IsIndeplinit(item)
                    select item;
            return interogare;
        }
    }
}
