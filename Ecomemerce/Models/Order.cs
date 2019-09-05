using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Models
{
    public class Order
    {
        [key]
        public int ID { get; set; }
        [Required ]
        public int Qty { get; set; }
        [Required]
        public decimal TotalCost { get; set; }
        [Required]
        public decimal TotalPaid { get; set; }
        
        public decimal? Discount { get; set; }

        public int? ProductId { get; set; }

        public Product Product { get; set; }




    }
}
