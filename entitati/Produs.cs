using System;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Serialization;

namespace entitati
{
    [Serializable]
    public class Produs : ProdusAbstract, IPackageble
    {
        string producator;

        public Produs()
        {
        }

        public Produs(long id, string nume, string codIntern, string producator, int pret, string categorie) : base(id, nume, codIntern, pret, categorie)
        {
            this.producator = producator;
        }

        public string Producator { get => producator; set => producator = value; }

        public bool CanAddToPackage(Pachet pachet)
        {
            int nrP = (pachet.Elem_pachet).Count(item => item is Produs);
            if (nrP < pachet.NrProd)
                return true;
            return false;
        }

        public override string Descriere()
        {
            return $@"
    Produsul{base.Descriere()}
        Producator: {Producator}";      
        }

    }
}
