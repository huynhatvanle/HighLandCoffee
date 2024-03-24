using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighLandCoffee.Models
{
    [Table("ChitietHD")]
    public class ChitietHD
    {
        [Key]
        public int Machitiet {  get; set; }  
        public long Soluongmua { get; set; }    
        public long Gia { get; set; }
        public int Mahd {  get; set; }
        [ForeignKey("Mahd")]
        public virtual Hoadon Hoadon { get; set; }  
        public int Mamon { get; set; }
        [ForeignKey("Mamon")]
        public virtual Monan Monan { get; set; }    
    }
}
