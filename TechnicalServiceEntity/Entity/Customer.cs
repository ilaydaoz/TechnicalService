using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechnicalServiceCore.Entites;

namespace TechnicalServiceEntity.Entity
{
    public class Customer : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int Phone { get; set; }

        public virtual List<Device>? Devices { get; set; }
    }
}
