using Electricity.DAL.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Electricity.DAL.Entity
{
    public class VoltageTransformator
    {
        [Key]
        public int Id { get; set; }

        public string Number { get; set; }

        public int? KTN { get; set; }

        public DateTime? ValidationDate { get; set; }

        public VoltageTransformatorType? Type { get; set; }

        public int ElectricityPointId { get; set; }

        [ForeignKey( "ElectricityPointId" )]
        public ElectricityPoint ElectricityPoint { get; set; }
    }
}
