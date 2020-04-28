using Electricity.DTO.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Electricity.DTO.Dtos
{
    public class ElectricityTransformatorDto
    {
        public int Id { get; set; }

        public string Number { get; set; }

        public ElectricityTransformatorTypeDto? Type { get; set; }

        public int? KTT { get; set; }

        public DateTime? ValidationDate { get; set; }

        public int ElectricityPointId { get; set; }
        public ElectricityPointDto ElectricityPoint { get; set; }
    }
}
