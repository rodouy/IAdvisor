using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ConfigurationManager.Models
{
    public class IntegerValuesViewModel
    {
        [Key]
        public int IntegerValuesId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public long Value { get; set; }
        public DateTime CreationDate { get; set; }
        public string LastModificationBy { get; set; }
    }
}