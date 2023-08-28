using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechnicalServiceCore.Entites;

namespace TechnicalServiceEntity.Entity
{
    public class ServiceStatus : BaseEntity
    {
        public int ServiceStatusID { get; set; }
        public string Description { get; set; }
    }
}
