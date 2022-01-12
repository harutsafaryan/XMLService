using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using XmlManager;


namespace XmlManager
{
    internal class XmlManager<T> : IXmlManager<T>
    {
       

        public List<T> Read(string path)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(List<T>));
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                List<T> items = (List<T>)formatter?.Deserialize(fs);
                return items;
            }
        }

        public void Write(List<T> model, string path)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(List<T>));
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, model);
            };
        }
    }
}
