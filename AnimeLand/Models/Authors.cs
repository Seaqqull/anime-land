using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AnimeLand.Models
{
    public class Authors
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public String FIO { get; set; }
    }
}