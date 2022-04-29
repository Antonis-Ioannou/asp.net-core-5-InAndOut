using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace asp.net_core_5_InAndOut.Models
{
    public class Expenses
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Expense")]
        public string ExpenseName { get; set; }

        [DisplayName("Amount")]
        public string Amount { get; set; }
    }
}
