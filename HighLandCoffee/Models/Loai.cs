using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighLandCoffee.Models
{
    [Table("Loai")]
    public class Loai
    {
        [Key]
        public string Maloai {  get; set; }
        [StringLength(100)]
        public string Tenloai { get; set; } 

        //public virtual Monan Monan { get; set; }    
    }
}
