using entitati;
using System;
using System.Xml;

namespace POS
{
    class PacheteMgr : ProduseAbstracteMgr
    {
        public void InitListafromXML()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("pachete.xml");
            XmlNodeList lista_noduri = doc.SelectNodes("/pachete/Pachet");
            foreach (XmlNode nod in lista_noduri)
            {
                string nume = nod["Nume"].InnerText;
                string codIntern = nod["CodIntern"].InnerText;
                int nrProd = int.Parse(nod["Produse"].InnerText);
                int nrServ = int.Parse(nod["Servicii"].InnerText);
                string categorie = nod["Categorie"].InnerText;
                Pachet pachet = new Pachet(Elemente.Count + 1, nume, codIntern, nrProd, nrServ, categorie);
                foreach (XmlNode nodP in nod.SelectNodes("Produs"))
                {
                    string numeP = nodP["Nume"].InnerText;
                    string codInternP = nodP["CodIntern"].InnerText;
                    string producatorP = nodP["Producator"].InnerText;
                    int pretP = int.Parse(nodP["Pret"].InnerText);
                    string categorieP = nodP["Categorie"].InnerText;
                    Produs prod = new Produs(Elemente.Count + 1, numeP, codInternP, producatorP, pretP, categorieP);
                    pachet.Add_elem(prod);
                }
                foreach (XmlNode nodS in nod.SelectNodes("Serviciu"))
                {
                    string numeS = nodS["Nume"].InnerText;
                    string codInternS = nodS["CodIntern"].InnerText;
                    int pretS = int.Parse(nodS["Pret"].InnerText);
                    string categorieS = nodS["Categorie"].InnerText;
                    Serviciu serv = new Serviciu(Elemente.Count + 1, numeS, codInternS, pretS, categorieS);
                    pachet.Add_elem(serv);
                }
                Elemente.Add(pachet);
            }
        }
    }
}
