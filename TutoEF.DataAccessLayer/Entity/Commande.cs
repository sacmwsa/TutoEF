﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutoEF.DataAccessLayer.Entity
{
    [Table("Order")]
    public class Commande
    {
        [Key]
        public int OrderId { get; set; }
        
        public string Reference { get; set; }
        public int TotalHT { get; set; }
    }
}
