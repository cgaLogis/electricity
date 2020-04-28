using System;
using System.Collections.Generic;
using System.Text;

namespace Electricity.DTO.Dtos
{
    public class ElectricityPointDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ElectricityMeterDto ElectMeter { get; set; }

        public ElectricityTransformatorDto ElectricityTransformator { get; set; }

        public VoltageTransformatorDto VoltageTransformator { get; set; }

        public int ObjectId { get; set; }

        public ConsumptionObjectDto Object { get; set; }
    }
}
