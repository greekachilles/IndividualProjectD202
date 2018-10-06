using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace LibraryApplication.Models
{
    public partial class LibraryApplicationDBContext : DbContext
    {
        public virtual DbSet<Book> Book { get; set; }
        public virtual DbSet<Borrower> Borrower { get; set; }

        public LibraryApplicationDBContext(DbContextOptions<LibraryApplicationDBContext> options) : base(options)
        { }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            modelBuilder.Entity<Book>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("text");

                entity.HasOne(d => d.Borrower)
                    .WithMany(p => p.Book)
                    .HasForeignKey(d => d.BorrowerId)
                    .HasConstraintName("FK_Book_Borrower");
            });

            modelBuilder.Entity<Borrower>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Phone).HasMaxLength(30);
            });
        }
    }
}
