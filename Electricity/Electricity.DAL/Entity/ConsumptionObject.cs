using System;
using System.Collections.Generic;
using System.Text;

namespace Electricity.DAL.Entity
{
    /// <summary>
    /// Объект потребления
    /// </summary>
    public class ConsumptionObject
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public int OrganizationId { get; set; }

        public ChildOrganization Organization { get; set; }

        public ICollection<ElectricityPoint> Points { get; set; }

        public ICollection<DeliveryPoint> DeliveryPoints { get; set; }

    }
}
