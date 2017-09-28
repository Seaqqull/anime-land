using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AnimeLand.Models
{
    public class Books
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public String Title { get; set; }
        [Required]
        [StringLength(100)]
        public String TitleEng { get; set; }
        [Required]
        [StringLength(1000)]
        public String Discription{ get; set; }
        public Countries Countries { get; set; }
        public int CountriesId { get; set; }

    }
}