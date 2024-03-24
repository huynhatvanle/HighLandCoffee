using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighLandCoffee.Models
{
    [Table("Monan")]
    public class Monan
    {
        [Key]
        public int  Mamon {  get; set; }
        [StringLength(100)]
        public string Tenmon { get; set; }  
        public long  Soluong {  get; set; }
        public long  Gia { get; set; }
        public string Maloai { get; set; }
        [ForeignKey("Maloai")]
        public virtual Loai Loai { get; set; }
        [StringLength(100)]
        public string Anh {  get; set; }    

    }
}
