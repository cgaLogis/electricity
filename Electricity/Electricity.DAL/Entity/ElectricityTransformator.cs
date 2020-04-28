using Electricity.DAL.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Electricity.DAL.Entity
{
    public class ElectricityTransformator
    {
        [Key]
        public int Id { get; set; }

        public string  Number { get; set; }

        public ElectricityTransformatorType? Type { get; set; }

        public int? KTT { get; set; }

        public DateTime? ValidationDate { get; set; }

        public int? ElectricityPointId { get; set; }

        [ForeignKey( "ElectricityPointId" )]
        public ElectricityPoint ElectricityPoint { get; set; }
    }
}
