using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Electricity.WebService.Models
{
    public class ElectricityTransformatorModel
    {
        public string Number { get; set; }

        public int? Type { get; set; }

        public int? KTT { get; set; }

        public DateTime? ValidationDate { get; set; }
    }
}
