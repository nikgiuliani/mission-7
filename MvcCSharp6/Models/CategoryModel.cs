using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCSharp6.Models
{
    public class CategoryModel
    {
        [Key]
        [Required]
        public int categoryId { get; set; }
        public string categoryName { get; set; }
    }
}