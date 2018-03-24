using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ConfigurationManager.Models
{
    public class DecimalValuesViewModel
    {
        [Key]
        public int DecimalValuesId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public decimal Value { get; set; }
        public DateTime CreationDate { get; set; }
        public string LastModificationBy { get; set; }
    }
}