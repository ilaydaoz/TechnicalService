using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechnicalServiceCore.Entites;

namespace TechnicalServiceEntity.Entity
{
    public class Device : BaseEntity
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string SerialNumber { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }

        public Guid TechnicianID { get; set; }
        public virtual Technician Technicians { get; set; }

        public Guid ServiceStatusID { get; set; }
        public virtual ServiceStatus ServiceStatuses { get; set; }
    }
}
