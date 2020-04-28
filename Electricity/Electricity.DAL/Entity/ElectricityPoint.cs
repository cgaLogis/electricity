using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Electricity.DAL.Entity
{
    /// <summary>
    /// Точка измерения электроэнергии
    /// </summary>
    public class ElectricityPoint
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public int? ElectricityMeterId { get; set; }

        //[ForeignKey( "ElectricityMeterId" )]
        public virtual ElectricityMeter ElectricityMeter { get; set; }

        public int? ElectricityTransformatorId { get; set; }

        //[ForeignKey( "ElectricityTransformatorId" )]
        public virtual ElectricityTransformator ElectricityTransformator { get; set; }

        public int? VoltageTransformatorId { get; set; }

        //[ForeignKey( "VoltageTransformatorId" )]
        public virtual VoltageTransformator VoltageTransformator { get; set; }

        public int? ObjectId { get; set; }

        public virtual ConsumptionObject Object { get; set; }

        public ICollection<ElectricityPointDeliveryPointMeter> ElectricityPointDeliveryPointMeters { get; set; }

    }
}
