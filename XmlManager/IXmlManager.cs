using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlManager
{
    public interface IXmlManager<T>
    {
            void Write(List<T> model, string path);
            List<T> Read(string path);
    }
}
