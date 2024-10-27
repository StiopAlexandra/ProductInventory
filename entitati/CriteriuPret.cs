﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entitati
{
    public class CriteriuPret : ICriteriu
    {
        int pret;

        public CriteriuPret(int pret)
        {
            this.pret = pret;
        }

        public bool IsIndeplinit(ProdusAbstract p)
        {
            if(p.Pret == this.pret)
                return true;
            return false;
        }
    }
}
