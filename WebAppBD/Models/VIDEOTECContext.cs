using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebAppBD.Models
{
    public partial class VIDEOTECContext : DbContext
    {
        public VIDEOTECContext()
        {
        }

        public VIDEOTECContext(DbContextOptions<VIDEOTECContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ArchiFichaSocio> ArchiFichaSocio { get; set; }
        public virtual DbSet<ArchiPeliDevueltas> ArchiPeliDevueltas { get; set; }
        public virtual DbSet<ArchiPeliPorTitulo> ArchiPeliPorTitulo { get; set; }
        public virtual DbSet<ArchiPeliPrestadas> ArchiPeliPrestadas { get; set; }
        public virtual DbSet<Ficha> Ficha { get; set; }
        public virtual DbSet<ListaEspera> ListaEspera { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<Socio> Socio { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-1CH3FMA\\SQLEXPRESS;Initial Catalog=VIDEOTEC;User ID=Sap;Trusted_Connection=True;MultipleActiveResultSets=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ArchiFichaSocio>(entity =>
            {
                entity.HasKey(e => e.IdFichaSocio)
                    .HasName("PK_Ficha_Socio");

                entity.ToTable("Archi_Ficha_Socio");

                entity.Property(e => e.IdFichaSocio).HasColumnName("IdFicha_Socio");

                entity.Property(e => e.ActoresFavorito)
                    .IsRequired()
                    .HasColumnName("Actores_Favorito")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoSocio).HasColumnName("Codigo_Socio");

                entity.Property(e => e.DirectoresFavorito)
                    .IsRequired()
                    .HasColumnName("Directores_Favorito")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GeneroFavorito)
                    .IsRequired()
                    .HasColumnName("Genero_Favorito")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodigoSocioNavigation)
                    .WithMany(p => p.ArchiFichaSocio)
                    .HasForeignKey(d => d.CodigoSocio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Codigo_Socio");
            });

            modelBuilder.Entity<ArchiPeliDevueltas>(entity =>
            {
                entity.HasKey(e => e.IdPeliDevuelta)
                    .HasName("PK_Archi_Peli_Devuelta");

                entity.ToTable("Archi_Peli_Devueltas");

                entity.Property(e => e.IdPeliDevuelta).HasColumnName("IdPeli_Devuelta");

                entity.Property(e => e.Actores)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Directores)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaDevolucion)
                    .HasColumnName("Fecha_Devolucion")
                    .HasColumnType("datetime");

                entity.Property(e => e.Genero)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumCintas).HasColumnName("Num_Cintas");

                entity.Property(e => e.Titulo)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ArchiPeliPorTitulo>(entity =>
            {
                entity.HasKey(e => e.IdPeliPorTitulo);

                entity.ToTable("Archi_Peli_Por_Titulo");

                entity.Property(e => e.IdPeliPorTitulo).HasColumnName("IdPeli_Por_Titulo");

                entity.Property(e => e.Actores)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Directores)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Genero)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumCintas).HasColumnName("Num_Cintas");

                entity.Property(e => e.Titulo)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ArchiPeliPrestadas>(entity =>
            {
                entity.HasKey(e => e.IdPeliPrestada);

                entity.ToTable("Archi_Peli_Prestadas");

                entity.Property(e => e.IdPeliPrestada).HasColumnName("IdPeli_Prestada");

                entity.Property(e => e.Actores)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Directores)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaPrestamo)
                    .HasColumnName("Fecha_Prestamo")
                    .HasColumnType("datetime");

                entity.Property(e => e.Genero)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumCintas).HasColumnName("Num_Cintas");

                entity.Property(e => e.Titulo)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Ficha>(entity =>
            {
                entity.HasKey(e => e.IdFicha);

                entity.Property(e => e.CodigoSocio).HasColumnName("Codigo_Socio");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.IdFichaSocio).HasColumnName("IdFicha_Socio");

                entity.Property(e => e.IdPeliDevuelta).HasColumnName("IdPeli_Devuelta");

                entity.Property(e => e.IdPeliPorTitulo).HasColumnName("IdPeli_Por_Titulo");

                entity.Property(e => e.IdPeliPrestada).HasColumnName("IdPeli_Prestada");

                entity.Property(e => e.NumCinta).HasColumnName("Num_Cinta");

                entity.Property(e => e.Pelicula)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodigoSocioNavigation)
                    .WithMany(p => p.Ficha)
                    .HasForeignKey(d => d.CodigoSocio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Codigo_Socios");

                entity.HasOne(d => d.IdFichaSocioNavigation)
                    .WithMany(p => p.Ficha)
                    .HasForeignKey(d => d.IdFichaSocio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IdFicha_Socio");

                entity.HasOne(d => d.IdPeliDevueltaNavigation)
                    .WithMany(p => p.Ficha)
                    .HasForeignKey(d => d.IdPeliDevuelta)
                    .HasConstraintName("FK_IdPeli_Devuelta");

                entity.HasOne(d => d.IdPeliPorTituloNavigation)
                    .WithMany(p => p.Ficha)
                    .HasForeignKey(d => d.IdPeliPorTitulo)
                    .HasConstraintName("FK_IdPeli_Por_Titulo");

                entity.HasOne(d => d.IdPeliPrestadaNavigation)
                    .WithMany(p => p.Ficha)
                    .HasForeignKey(d => d.IdPeliPrestada)
                    .HasConstraintName("FK_IdPeli_Prestada");
            });

            modelBuilder.Entity<ListaEspera>(entity =>
            {
                entity.HasKey(e => e.IdListaEspera);

                entity.ToTable("Lista_Espera");

                entity.Property(e => e.IdListaEspera).HasColumnName("IdLista_Espera");

                entity.Property(e => e.CantidadSocios).HasColumnName("Cantidad_Socios");

                entity.Property(e => e.TiempoEspera).HasColumnName("Tiempo_Espera");

                entity.HasOne(d => d.IdFichaNavigation)
                    .WithMany(p => p.ListaEspera)
                    .HasForeignKey(d => d.IdFicha)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IdFicha");
            });

            modelBuilder.Entity<Roles>(entity =>
            {
                entity.HasKey(e => e.IdRol);

                entity.Property(e => e.IdRol).HasColumnName("IdRol");

                entity.Property(e => e.Descripcion).HasColumnName("Descripcion");
            });

            modelBuilder.Entity<Socio>(entity =>
            {
                entity.HasKey(e => e.Codigo_Socio);

                entity.Property(e => e.Codigo_Socio).HasColumnName("Codigo_Socio");

                entity.Property(e => e.Apellido_1)
                    .IsRequired()
                    .HasColumnName("Apellido_1")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Apellido_2)
                    .IsRequired()
                    .HasColumnName("Apellido_2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Usuario>(entity =>
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

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
