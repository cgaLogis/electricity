using System;
using System.Collections.Generic;
using System.Text;

namespace Electricity.DTO.Dtos
{
    public class ConsumptionObjectDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public int OrganizationId { get; set; }

        public ChildOrganizationDto Organization { get; set; }

        public List<ElectricityPointDto> Points { get; set; }

        public List<DeliveryPointDto> DeliveryPoints { get; set; }
    }
}
