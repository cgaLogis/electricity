using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Electricity.WebService.Models
{
    public class VoltageTransformatorModel
    {
        public string Number { get; set; }

        public int? KTN { get; set; }

        public DateTime? ValidationDate { get; set; }

        public int? Type { get; set; }
    }
}
