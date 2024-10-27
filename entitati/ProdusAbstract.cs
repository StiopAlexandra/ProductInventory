using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace entitati
{
    [Serializable]

    public abstract class ProdusAbstract : IComparable
    {      
        long id;
        string nume;
        string codIntern;
        int pret;
        string categorie;

        protected ProdusAbstract(long id, string nume, string codIntern, int pret, string categorie)
        {
            this.id = id;
            this.nume = nume;
            this.codIntern = codIntern;
            this.pret = pret;
            this.categorie = categorie;
        }

        protected ProdusAbstract(long id, string nume, string codIntern, string categorie)
        {
            this.id = id;
            this.nume = nume;
            this.codIntern = codIntern;
            this.categorie = categorie;
        }

        protected ProdusAbstract()
        {
        }

        //[XmlElement("ID")]
        public long Id { get => id; set => id = value; }
        //[XmlElement("Numele")]
        public string Nume { get => nume; set => nume = value; }
        //[XmlElement("CodulIntern")]
        public string CodIntern { get => codIntern; set => codIntern = value; }
        //[XmlElement("Pretul")]
        public int Pret { get => pret; set => pret = value; }
        //[XmlElement("Categoria")]
        public string Categorie { get => categorie; set => categorie = value; }

        public virtual String Descriere()
        {
            return $@"[{Id}]:
        Nume: {Nume}
        Cod Intern: {CodIntern}
        Pret: { Pret}
        Categorie: { Categorie}";
        }
        public int CompareTo(object obj)
        {
            return this.Nume.CompareTo(((ProdusAbstract)obj).Nume);
        }

    }
}
