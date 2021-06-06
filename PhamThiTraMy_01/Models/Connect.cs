using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace PhamThiTraMy_01.Models
{
    public partial class Connect : DbContext
    {
        public Connect()
            : base("name=Connect")
        {
        }

        public virtual DbSet<LopHoc>LopHocs { get; set; }
        public virtual DbSet<SinhVien> SinhViens { get; set; }
        public virtual DbSet<AccountModel> AccountModels { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
