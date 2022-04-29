using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace asp.net_core_5_InAndOut.Models
{
    public class Item
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Borrower")]
        [Required]
        public string Borrower { get; set; }

        [Required]
        [DisplayName("Lender")]
        public string Lender { get; set; }

        [Required]
        [DisplayName("Item name")]
        public string ItemName { get; set; }
    }
}
