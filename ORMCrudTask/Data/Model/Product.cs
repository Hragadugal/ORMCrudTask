using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace ORMCrudTask.Data.Model
{
    public class Product
    {
        public int Id { get; set; }
        
        [Required]
        [MaxLength(20)]
        public string Name { get; set; }

        public decimal Price { get; set; }
        public decimal Stock { get; set; }

    }
}
