using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace onlib
{
    public partial class booksContext : DbContext
    {
        public booksContext()
        {
        }

        public booksContext(DbContextOptions<booksContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Autor> Autor { get; set; }
        public virtual DbSet<AutorBook> AutorBook { get; set; }
        public virtual DbSet<Basket> Basket { get; set; }
        public virtual DbSet<Book> Book { get; set; }
        public virtual DbSet<BookCategory> BookCategory { get; set; }
        public virtual DbSet<BookGenre> BookGenre { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Genre> Genre { get; set; }
        public virtual DbSet<Pub> Pub { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Database=books;Username=postgres;Password=05058585q;Integrated Security=true;Pooling=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Autor>(entity =>
            {
                entity.ToTable("autor");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Birthdate)
                    .HasColumnName("birthdate")
                    .HasColumnType("date");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.Patronymic).HasColumnName("patronymic");

                entity.Property(e => e.Surname).HasColumnName("surname");
            });

            modelBuilder.Entity<AutorBook>(entity =>
            {
                entity.ToTable("autor_book");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AutorId).HasColumnName("autor_id");

                entity.Property(e => e.BookId).HasColumnName("book_id");

                entity.HasOne(d => d.Autor)
                    .WithMany(p => p.AutorBook)
                    .HasForeignKey(d => d.AutorId)
                    .HasConstraintName("autor_book_autor_id_fkey");

                entity.HasOne(d => d.Book)
                    .WithMany(p => p.AutorBook)
                    .HasForeignKey(d => d.BookId)
                    .HasConstraintName("autor_book_book_id_fkey");
            });

            modelBuilder.Entity<Basket>(entity =>
            {
                entity.ToTable("basket");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.BookId).HasColumnName("book_id");

                entity.Property(e => e.DateSending)
                    .HasColumnName("date_sending")
                    .HasColumnType("date");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.UsersId).HasColumnName("users_id");

                entity.HasOne(d => d.Book)
                    .WithMany(p => p.Basket)
                    .HasForeignKey(d => d.BookId)
                    .HasConstraintName("basket_book_id_fkey");

                entity.HasOne(d => d.Users)
                    .WithMany(p => p.Basket)
                    .HasForeignKey(d => d.UsersId)
                    .HasConstraintName("basket_users_id_fkey");
            });

            modelBuilder.Entity<Book>(entity =>
            {
                entity.ToTable("book");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AutorId).HasColumnName("autor_id");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.PubId).HasColumnName("pub_id");

                entity.HasOne(d => d.Autor)
                    .WithMany(p => p.Book)
                    .HasForeignKey(d => d.AutorId)
                    .HasConstraintName("book_autor_id_fkey");

                entity.HasOne(d => d.Pub)
                    .WithMany(p => p.Book)
                    .HasForeignKey(d => d.PubId)
                    .HasConstraintName("book_pub_id_fkey");
            });

            modelBuilder.Entity<BookCategory>(entity =>
            {
                entity.ToTable("book_category");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.BookId).HasColumnName("book_id");

                entity.Property(e => e.CategoryId).HasColumnName("category_id");

                entity.HasOne(d => d.Book)
                    .WithMany(p => p.BookCategory)
                    .HasForeignKey(d => d.BookId)
                    .HasConstraintName("book_category_book_id_fkey");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.BookCategory)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("book_category_category_id_fkey");
            });

            modelBuilder.Entity<BookGenre>(entity =>
            {
                entity.ToTable("book_genre");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.BookId).HasColumnName("book_id");

                entity.Property(e => e.GenreId).HasColumnName("genre_id");

                entity.HasOne(d => d.Book)
                    .WithMany(p => p.BookGenre)
                    .HasForeignKey(d => d.BookId)
                    .HasConstraintName("book_genre_book_id_fkey");

                entity.HasOne(d => d.Genre)
                    .WithMany(p => p.BookGenre)
                    .HasForeignKey(d => d.GenreId)
                    .HasConstraintName("book_genre_genre_id_fkey");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("category");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name).HasColumnName("name");
            });

            modelBuilder.Entity<Genre>(entity =>
            {
                entity.ToTable("genre");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name).HasColumnName("name");
            });

            modelBuilder.Entity<Pub>(entity =>
            {
                entity.ToTable("pub");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Adress).HasColumnName("adress");

                entity.Property(e => e.Name).HasColumnName("name");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("role");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Key).HasColumnName("key");

                entity.Property(e => e.Name).HasColumnName("name");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.ToTable("users");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Email).HasColumnName("email");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.Password).HasColumnName("password");

                entity.Property(e => e.Patronymic).HasColumnName("patronymic");

                entity.Property(e => e.RoleId).HasColumnName("role_id");

                entity.Property(e => e.Surname).HasColumnName("surname");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("users_role_id_fkey");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
