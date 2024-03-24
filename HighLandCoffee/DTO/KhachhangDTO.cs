using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighLandCoffee.DTO
{
    public class KhachhangDTO
    {
        public int Makh { get; set; }
        public string Hoten { get; set; }
        public string Diachi { get; set; }
        public string Sodt { get; set; }
        public string Email { get; set; }
    }
}
