using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace entitati
{
    [Serializable]

    public class Pachet : ProdusAbstract, IPackageble
    {
        int nrProd;
        int nrServ;
        List<ProdusAbstract> elem_pachet = new List<ProdusAbstract>();

        public List<ProdusAbstract> Elem_pachet { get => elem_pachet; set => elem_pachet = value; }
        public int NrProd { get => nrProd; set => nrProd = value; }
        public int NrServ { get => nrServ; set => nrServ = value; }

        public Pachet(long id, string nume, string codIntern, int nrProd, int nrServ, string categorie) : base(id, nume, codIntern, categorie)
        {
            this.nrProd = nrProd;
            this.nrServ = nrServ;
        }

        public Pachet()
        {
        }

        public bool CanAddToPackage(Pachet pachet)
        {
            return false;
        }

        public override string Descriere()
        {
            string descriere = "";
            foreach (ProdusAbstract elem in elem_pachet)
            {
                descriere = String.Concat(descriere, elem.Descriere());
            }
            return $@"
Pachetul{base.Descriere()}
        Produse: {NrProd}
        Servicii: {NrServ}
        Elemente Pachet: {descriere}
";
        }

        public void Add_elem(ProdusAbstract p)
        {
            if (((IPackageble)p).CanAddToPackage(this))
            {
                elem_pachet.Add(p);
                this.Pret = this.Pret + p.Pret;         
            }
        }
    }
}
