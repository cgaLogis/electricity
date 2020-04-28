using System;
using System.Collections.Generic;
using System.Text;

namespace Electricity.DAL.Entity
{
    /// <summary>
    /// Расчетный прибор учета 
    /// </summary>
    public class DeliveryPointMeter
    {
        public int Id { get; set; }

        public int DeliveryPointId { get; set; }

        public DeliveryPoint DeliveryPoint { get; set; }

    }
}
