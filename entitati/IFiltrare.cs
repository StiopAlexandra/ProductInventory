﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entitati
{
    public interface IFiltrare
    {
        IEnumerable<ProdusAbstract> Filtrare(List<ProdusAbstract> colectie, ICriteriu c);       

    }
}
