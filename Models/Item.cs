﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace asp.net_core_5_InAndOut.Models
{
    public class Item
    {
        [Key]
        public int Id { get; set; }

        public string Borrower { get; set; }
    }
}