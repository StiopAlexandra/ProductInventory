using System;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Serialization;

namespace entitati
{
    [Serializable]
    //[XmlRoot("ServiciuParticularizat")]

    public class Serviciu : ProdusAbstract, IPackageble
    {

        public Serviciu()
        {
        }

        public Serviciu(long id, string nume, string codIntern, int pret, string categorie) : base(id, nume, codIntern, pret, categorie)
        {
        }

        public bool CanAddToPackage(Pachet pachet)
        {
            int nrS = (pachet.Elem_pachet).Count(item => item is Serviciu);
            if (nrS < pachet.NrServ)
                return true;
            return false;
        }

        public override String Descriere()
        {
            return $@"
    Serviciul{base.Descriere()}";
        }

        public void save2XML(string fileName)
        {
            XmlSerializer xs = new XmlSerializer(typeof(Serviciu));
            StreamWriter sw = new StreamWriter(fileName + ".xml");
            xs.Serialize(sw, this);
            sw.Close();
        }

        public static Serviciu loadFromXML(string fileName)
        {
            XmlSerializer xs = new XmlSerializer(typeof(Serviciu));
            FileStream fs = new FileStream(fileName + ".xml", FileMode.Open);
            XmlReader reader = new XmlTextReader(fs);
            Serviciu serviciu = (Serviciu)xs.Deserialize(reader);
            fs.Close();
            return serviciu;
        }
    }
}
