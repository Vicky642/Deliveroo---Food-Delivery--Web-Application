//using System;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata;
//using Deliveroo.Models;

//#nullable disable

//namespace Deliveroo.Data
//{
//    public partial class DeliverooContext : DbContext
//    {
//        public DeliverooContext()
//        {
//        }

//        public DeliverooContext(DbContextOptions<DeliverooContext> options)
//            : base(options)
//        {
//        }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//                optionsBuilder.UseMySql("server=localhost;database=deliveroo;uid=root", Microsoft.EntityFrameworkCore.ServerVersion.Parse("5.7.31-mysql"));
//            }
//        }

//        protected override void OnModelCreating(ModelBuilder modelBuilder)
//        {
//            modelBuilder.HasCharSet("latin1")
//                .UseCollation("latin1_swedish_ci");

//            OnModelCreatingPartial(modelBuilder);
//        }

//        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
//    }
//}
