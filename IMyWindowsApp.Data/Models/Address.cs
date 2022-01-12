using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMyWindowsApp.Data.Models
{
    [Serializable]
    public class Address
    {
        public Address()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public string Adr { get; set; }
        public Guid StudentId { get; set; }
    }
}
