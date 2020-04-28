﻿using Electricity.DAL.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Electricity.DAL.Entity
{
    /// <summary>
    /// Счетчик электроэнергии
    /// </summary>
    public class ElectricityMeter
    {
        [Key]
        public int Id { get; set; }

        public string Number { get; set; }

        public ElectricityMeterType? Type { get; set; }

        public DateTime? ValidationDate { get; set; }

        public int? ElectricityPointId { get; set; }

        [ForeignKey( "ElectricityPointId" )]
        public ElectricityPoint ElectricityPoint { get; set; }
    }
}
