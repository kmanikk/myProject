using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShopping_Project_Models
{
    public class CoverType
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        [Display(Name="CoverType Name")]
        public string Name { get; set; }
    }
}
