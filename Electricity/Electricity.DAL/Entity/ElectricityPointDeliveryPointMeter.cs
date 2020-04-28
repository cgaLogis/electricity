using System;
using System.Collections.Generic;
using System.Text;

namespace Electricity.DAL.Entity
{
    /// <summary>
    /// Таблица для связывания Точки измерения электроэнергии с рассчетными прибором
    /// </summary>
    public class ElectricityPointDeliveryPointMeter
    {
        public int Id { get; set; }

        public int ElectricityPointId { get; set; }

        public ElectricityPoint ElectricityPoint { get; set; }

        public int DeliveryPointMeterId { get; set; }

        public DeliveryPointMeter DeliveryPointMeter { get; set; }

        public DateTime? Created { get; set; }

    }
}
