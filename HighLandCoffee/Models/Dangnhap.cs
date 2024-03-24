using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighLandCoffee.Models
{
    [Table("Admin")]
    public class Dangnhap
    {
        [Key]
        public string Tendn { get; set; }   
        public string Pass { get; set; }    
    }
}
