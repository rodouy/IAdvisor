using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ConfigurationManager.Models
{
    public class StringValuesViewModel
    {
        [Key]
        public int StringValuesId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Value { get; set; }
        public DateTime CreationDate { get; set; }
        public string LastModificationBy { get; set; }
    }
}