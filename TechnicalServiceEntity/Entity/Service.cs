using TechnicalServiceCore.Entites;

namespace TechnicalServiceEntity.Entity
{
    public class Service : BaseEntity
    {
        public Guid TechnicianID { get; set; }
        public virtual Technician Technicians { get; set; }
      
        public Guid DeviceID { get; set; }
        public virtual Device Devices { get; set; }
       
        public Guid CustomerID { get; set; }
        public virtual Customer Customers { get; set; }
       
        public Guid ServiceStatusID { get; set; }
        public virtual ServiceStatus ServiceStatuses { get; set; }
    }
}
