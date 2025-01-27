﻿using System;
using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations;

namespace DataGridAvto.Framework.Contracts.Models
{
    /// <summary>
    /// Машина
    /// </summary>
    public class Avto
    {
        public Guid Id { get; set; }

        /// <summary>
        /// Марка
        /// </summary>
        
        /// <intheridoc cref="Models.Mark"/>
        public Mark Mark { get; set; }

        /// <summary>
        /// Гос номер
        /// </summary>
        [Required]
        [StringLength(8, MinimumLength = 7)]
        public string Number { get; set; }

        /// <summary>
        /// Пробег
        /// </summary>
        [Required]
        [Range(0, 999999)]
        public int Probeg { get; set; }

        /// <summary>
        /// Средний расход топлива за час 
        /// </summary>
        
        public decimal AvgFuelCons { get; set; }

        /// <summary>
        /// Текущий объем топлива
        /// </summary>

        public decimal CurrFuel {  get; set; }

        /// <summary>
        /// Стоимость аренды (за минуту)
        /// </summary>

        public decimal CostRent { get; set; }

        /// <summary>
        /// Запас хода топлива
        /// </summary>
    }
}
