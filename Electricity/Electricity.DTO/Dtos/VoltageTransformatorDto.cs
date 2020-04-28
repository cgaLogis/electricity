using Electricity.DTO.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Electricity.DTO.Dtos
{
    public class VoltageTransformatorDto
    {
        public int Id { get; set; }

        public string Number { get; set; }

        public int? KTN { get; set; }

        public DateTime? ValidationDate { get; set; }

        public VoltageTransformatorTypeDto? Type { get; set; }

        public int ElectricityPointId { get; set; }
        public ElectricityPointDto ElectricityPoint { get; set; }
    }
}
