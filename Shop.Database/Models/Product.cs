using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Shop.Data.Models
{
    public class Product
    {

        public Product()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        [Key]
        public string Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int Price { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        public ICollection<Product> InnerProducts { get; set; } = new HashSet<Product>();

        public string PaymentId { get; set; }

        public Payment Payment { get; set; }
    }
}
