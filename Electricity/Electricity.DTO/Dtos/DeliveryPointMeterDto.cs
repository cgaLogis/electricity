using System;
using System.Collections.Generic;
using System.Text;

namespace Electricity.DTO.Dtos
{
    public class DeliveryPointMeterDto
    {
        public int Id { get; set; }

        public int DeliveryPointId { get; set; }

        public DeliveryPointDto DeliveryPoint { get; set; }
    }
}
