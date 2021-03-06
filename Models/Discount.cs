﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GasStation.Models
{
    public class Discount
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int DiscountId { get; set; }
        public Product Product { get; set; }
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Type { get; set; }
        [Required]
        public decimal Value { get; set; }

        [DataType(DataType.Date)]
        public DateTime BeginDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime FinishDate { get; set; }
    }
}
