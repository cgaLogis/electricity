using System;
using System.Collections.Generic;
using System.Text;

namespace Electricity.DAL.Entity
{
    /// <summary>
    /// Точка измерения электроэнергии
    /// </summary>
    public class ElectricityPoint
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ElectricityMeter ElectMeter { get; set; }

        public ElectricityTransformator ElectricityTransformator { get; set; }

        public VoltageTransformator VoltageTransformator { get; set; }

        public int ObjectId { get; set; }

        public ConsumptionObject Object { get; set; }

    }
}
