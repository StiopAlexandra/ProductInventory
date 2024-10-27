using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using entitati;

namespace POS
{
    abstract class ProduseAbstracteMgr
    {
        private static List<ProdusAbstract> elemente = new List<ProdusAbstract>();
        private static bool isProd;
        private static bool isServ;
        private static long id = elemente.Count();

        private static int indexCurent;

        public static List<ProdusAbstract> Elemente { get => elemente; set => elemente = value; }
        public static int IndexCurent { get => indexCurent; set => indexCurent = value; }
        
        public static bool IsProd { get => isProd; set => isProd = value; }
        public static bool IsServ { get => isServ; set => isServ = value; }
        public static long Id { get => id; set => id = value; }

        public virtual void Afisare()
        {
            Console.WriteLine("\n" + "Elementele sunt:");
            foreach (ProdusAbstract p in elemente)
                Console.WriteLine(p.Descriere());
        }

        public long GenerateId()
        {
            return id++;
        }

        public void OrdonareNume(bool asc)
        {
            if(asc)
            {
                IEnumerable<ProdusAbstract> interogare =
                                    from prod in elemente
                                    orderby prod.Nume
                                    select prod;
                Elemente = interogare.ToList();
            }
            else
            {
                IEnumerable<ProdusAbstract> interogare =
                                    from prod in elemente
                                    orderby prod.Nume descending
                                    select prod;
                Elemente = interogare.ToList();
            }   
        }

        public void OrdonareCategorie(bool asc)
        {
            if (asc)
            {
                IEnumerable<ProdusAbstract> interogare =
                                    from prod in elemente
                                    orderby prod.Categorie
                                    select prod;
                Elemente = interogare.ToList();
            }
            else
            {
                IEnumerable<ProdusAbstract> interogare =
                                    from prod in elemente
                                    orderby prod.Categorie descending
                                    select prod;
                Elemente = interogare.ToList();
            }
        }

        public void OrdonarePret(bool asc)
        {
            if (asc)
            {
                IEnumerable<ProdusAbstract> interogare =
                                    from prod in elemente
                                    orderby prod.Pret
                                    select prod;
                Elemente = interogare.ToList();
            }
            else
            {
                IEnumerable<ProdusAbstract> interogare =
                                    from prod in elemente
                                    orderby prod.Pret descending
                                    select prod;
                Elemente = interogare.ToList();
            }
        }

        public IEnumerable<ProdusAbstract> FiltrareNume(string nume)
        {
            FiltrareCriteriu f = new FiltrareCriteriu();
            return f.Filtrare(elemente, new CriteriuNume(nume));
        }

        public IEnumerable<ProdusAbstract> FiltrarePret(int pret)
        {
            FiltrareCriteriu f = new FiltrareCriteriu();
            return f.Filtrare(elemente, new CriteriuPret(pret));
        }

        public IEnumerable<ProdusAbstract> FiltrareCategorie(string categorie)
        {
            FiltrareCriteriu f = new FiltrareCriteriu();
            return f.Filtrare(elemente, new CriteriuCategorie(categorie));
        }

        public void save2XML(string fileName)
        {
            Type[] prodAbstractTypes = new Type[3];
            prodAbstractTypes[0] = typeof(Pachet);
            prodAbstractTypes[1] = typeof(Serviciu);
            prodAbstractTypes[2] = typeof(Produs);
            XmlSerializer xs = new XmlSerializer(typeof(List<ProdusAbstract>), prodAbstractTypes);
            StreamWriter sw = new StreamWriter(fileName + ".xml");
            try
            {
                xs.Serialize(sw, elemente);
            }
            catch (IOException e)
            {
                Console.WriteLine("IOException source: " + e.Source);
            }
            sw.Close();
        }

        public List<ProdusAbstract> loadFromXML(string fileName)
        {
            Type[] prodAbstractTypes = new Type[3];
            prodAbstractTypes[0] = typeof(Pachet);
            prodAbstractTypes[1] = typeof(Serviciu);
            prodAbstractTypes[2] = typeof(Produs);
            XmlSerializer xs = new XmlSerializer(typeof(List<ProdusAbstract>), prodAbstractTypes);
            try
            {
                FileStream fs = new FileStream(fileName + ".xml", FileMode.Open);
                XmlReader reader = new XmlTextReader(fs);
                List<ProdusAbstract> colectie = (List<ProdusAbstract>)xs.Deserialize(reader);
                fs.Close();
                return colectie;

            }
            catch (IOException e)
            {
                Console.WriteLine("IOException source: " + e.Source);
            }
            return null;
        }
    }
}
