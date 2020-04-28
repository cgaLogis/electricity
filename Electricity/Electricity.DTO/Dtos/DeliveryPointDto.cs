using System;
using System.Collections.Generic;
using System.Text;

namespace Electricity.DTO.Dtos
{
    public class DeliveryPointDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int MaxPower { get; set; }

        public int ConsumptionObjectId { get; set; }

        public ConsumptionObjectDto ConsumptionObject { get; set; }

        public List<DeliveryPointMeterDto> DeliveryPointMeters { get; set; }
    }
}
