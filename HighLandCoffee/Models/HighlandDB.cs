using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighLandCoffee.Models
{
    public class HighlandDB:DbContext
    {
        public DbSet<ChitietHD> ChitietHDs { get; set; }
        public DbSet<Hoadon> Hoadons { get; set; }
        public DbSet<Khachhang> Khachhangs { get; set; }
        public DbSet<Loai> Loais { get; set; }
        public DbSet<Monan> Monans { get; set; }
        public DbSet<Dangnhap> Dangnhaps { get; set; }  
     
        public string ConnectionString { get; set; }

        public HighlandDB()
        {
            var folder = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            ConnectionString = Path.Combine(folder, "Highland.db");

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data Source = {ConnectionString}");

        }
    }
}
