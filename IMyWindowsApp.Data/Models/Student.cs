using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace IMyWindowsApp.Data.Models
{
    [Serializable, XmlRoot(Namespace = "www.contoso.com", ElementName = "Student", IsNullable = true)]
    public class Student
    {
        public Student()
        {
            Id = Guid.NewGuid();
        }
        public Guid? Id { get; set; }
        public int? Age { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public Guid? teacherId { get; set; }
    }
}
