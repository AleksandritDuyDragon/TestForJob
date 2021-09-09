using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace TestForJob
{
    class Serialization
    {
        XmlSerializer formatter = new XmlSerializer(typeof(List<Cheque>));
        public void Serializator(string inputpath, List<Cheque> cheques)
        {
            using (FileStream fs = new FileStream(inputpath, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, cheques);
            }
        }
        public List<Cheque> Deserializator(string inputpath)
        {
            List<Cheque> cheques;
            using (FileStream fs = new FileStream(inputpath, FileMode.OpenOrCreate))
            {
                cheques = (List<Cheque>)formatter.Deserialize(fs);
            }
            return cheques;
        }
    }
}
