using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GummiBearKingdom.Models
{
    
    [Table("Products")]
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        public string Name { get; set; }
		[Required]
        public string Description { get; set; }
		[Required]
        public string Cost { get; set; }
		[Required]
        public int CountryId { get; set; }
        public virtual Country Country { get; set; }
    }

}
