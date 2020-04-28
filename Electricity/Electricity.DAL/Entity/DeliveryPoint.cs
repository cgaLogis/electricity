using System;
using System.Collections.Generic;
using System.Text;

namespace Electricity.DAL.Entity
{
    /// <summary>
    /// Точка поставки электроэнергии
    /// </summary>
    public class DeliveryPoint
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int MaxPower { get; set; }

        public int ConsumptionObjectId { get; set; }

        public ConsumptionObject ConsumptionObject { get; set; }

        public ICollection<DeliveryPointMeter> DeliveryPointMeters { get; set; }
    }
}
