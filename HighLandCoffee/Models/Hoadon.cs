using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighLandCoffee.Models
{
    [Table("Hoadon")]
    public class Hoadon
    {
        [Key]
        public int Mahd {  get; set; }   
        public DateTime Ngaymua { get; set; }   
        
        public int Makh { get; set; }
        [ForeignKey("Makh")]
        public virtual Khachhang Khachhang { get; set; }
    }
}
