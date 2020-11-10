using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebAppBD.Models;

namespace WebAppBD.Data
{
    public class VIDEOTECContext : IdentityDbContext<IdentityUser>
    {
        public VIDEOTECContext(DbContextOptions<VIDEOTECContext> options)
            : base(options)
        { 

        }

        public virtual DbSet<Usuario> Usuario { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-1CH3FMA\\SQLEXPRESS;Initial Catalog=VIDEOTEC;User ID=Sap;Trusted_Connection=True;MultipleActiveResultSets=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.IdUsuario);
                entity.ToTable("Usuario");

                entity.Property(e => e.IdUsuario).HasColumnName("IdUsuario");

                entity.Property(e => e.Nombre).HasColumnName("Nombre");

                entity.Property(e => e.Apellido1).HasColumnName("Apellido1");

                entity.Property(e => e.Password).HasColumnName("Password");

                entity.Property(e => e.Correo).HasColumnName("Correo");

                entity.Property(e => e.Cedula).HasColumnName("Cedula");

                entity.HasOne(d => d.IdRolNavigation)
                    .WithMany(p => p.Usuario)
                    .HasForeignKey(d => d.IdRol)
                    .HasConstraintName("FK_Usuario_Roles");

                entity.Property(e => e.Estado).HasColumnName("Estado");
            });

            base.OnModelCreating(builder);
           
        }
    }
}
