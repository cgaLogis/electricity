using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Electricity.WebService.Models
{
    public class ElectricityPointModel
    {
        public string Name { get; set; }

        public ElectricityMeterModel ElectricityMeter { get; set; }

        public ElectricityTransformatorModel ElectricityTransformator { get; set; }

        public VoltageTransformatorModel VoltageTransformator { get; set; }

        public int? ObjectId { get; set; }

    }
}
