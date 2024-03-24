using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighLandCoffee.Models
{
    [Table("Khachhang")]
    public class Khachhang
    {
        [Key]
        public int Makh {  get; set; }
        [StringLength(100)]
        public string Tenkh { get; set; }
        [StringLength(100)] 
        public string Diachi { get; set; }
        [StringLength(100)]
        public string SoDT {  get; set; }
        [StringLength(100)]
        public string Email { get; set; }

       

    }
}
