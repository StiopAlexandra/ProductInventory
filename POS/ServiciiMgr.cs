using entitati;
using System;
using System.Xml;

namespace POS
{
    class ServiciiMgr : ProduseAbstracteMgr
    {
        public void InitListafromXML()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("servicii.xml");
            XmlNodeList lista_noduri = doc.SelectNodes("/servicii/Serviciu");
            foreach (XmlNode nod in lista_noduri)
            {
                string nume = nod["Nume"].InnerText;
                string codIntern = nod["CodIntern"].InnerText;
                int pret = int.Parse(nod["Pret"].InnerText);
                string categorie = nod["Categorie"].InnerText;
                if (!Cautare(nume, codIntern, pret, categorie))
                {
                    Elemente.Add(new Serviciu(Elemente.Count + 1, nume, codIntern, pret, categorie));
                }
                else
                {
                    Console.Write("In fisier exista servicii identice" + "\n");
                }
            }
        }

        public bool Cautare(string nume, string codIntern, int pret, string categorie)
        {
            foreach (ProdusAbstract serv in Elemente)
            {
                if (serv is Serviciu && (serv.Nume).Equals(nume) && (serv.CodIntern).Equals(codIntern)
                    && serv.Pret == pret && (serv.Categorie).Equals(categorie))
                    return true;
            }
            return false;
        }
    }
}
