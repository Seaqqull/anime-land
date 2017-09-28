using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AnimeLand.Models
{
    public class Genres
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public String Name { get; set; }
    }
}