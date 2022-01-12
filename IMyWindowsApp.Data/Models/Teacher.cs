using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace IMyWindowsApp.Data.Models
{
    [Serializable, XmlRoot(Namespace = "www.contoso.com", ElementName = "Teacher", IsNullable = true)]
    public class Teacher
    {
        public Teacher()
        {
            Id = Guid.NewGuid();
        }
        public Guid? Id { get; set; }
        public int? Age { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
    }
}
