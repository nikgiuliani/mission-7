using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCSharp6.Models
{
    public class MovieModel
    {
        [Key]
        [Required]
        public int movieId { get; set; }
        [Required]
        public string category { get; set; }
        [Required]
        public string title { get; set; }
        [Required]
        public ushort year { get; set; }
        [Required]
        public string director { get; set; }
        [Required]
        public string rating { get; set; }
        public bool edited { get; set; }
        public string lentTo { get; set; }
        [StringLength(25, ErrorMessage = "Notes must be a minimum of 25 characters!")]
        public string notes { get; set; }
    }
}