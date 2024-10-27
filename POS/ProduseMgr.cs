using entitati;
using System;
using System.Xml;

namespace POS
{
    class ProduseMgr : ProduseAbstracteMgr
    {
        public void InitListafromXML()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("produse.xml");
            XmlNodeList lista_noduri = doc.SelectNodes("/produse/Produs");
            foreach (XmlNode nod in lista_noduri)
            {
                string nume = nod["Nume"].InnerText;
                string codIntern = nod["CodIntern"].InnerText;
                string producator = nod["Producator"].InnerText;
                int pret = int.Parse(nod["Pret"].InnerText);
                string categorie = nod["Categorie"].InnerText;
                if (!Cautare(nume, codIntern, producator, pret, categorie))
                {
                    Elemente.Add(new Produs(Elemente.Count + 1, nume, codIntern, producator, pret, categorie));
                }
                else
                {
                    Console.Write("In fisier exista produse identice" + "\n");
                }
            }
        }

        public bool Cautare(string nume, string codIntern, string producator, int pret, string categorie)
        {
            foreach (ProdusAbstract prod in Elemente)
            {
                if (prod is Produs && (prod.Nume).Equals(nume) && ((Produs)prod).Producator.Equals(producator) &&
                    (prod.CodIntern).Equals(codIntern) && prod.Pret == pret && (prod.Categorie).Equals(categorie))
                    return true;
            }
            return false;
        }
    }
}
