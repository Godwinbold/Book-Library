using BookLibrary.Models;
using Microsoft.EntityFrameworkCore;

namespace BookLibrary.Data
{
    public class BookLibraryDbContext : DbContext 
    {
        public BookLibraryDbContext(DbContextOptions<BookLibraryDbContext> options):base(options)
        {
            
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Reviews> Reviews { get; set; }

        public DbSet<SubCategories> SubCategories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Book>().HasData(
                new Book
                {
                    Id = 1,
                    Title = "Harry Potter and the Prisoner of Azkaban",
                    Description = "Magic",
                    Author = "J.K Rowling",
                    Pages = 780,
                    Publisher = "Bloomsbury",
                    Language = "English",
                    ISBN = "975609876112",
                    LibraryAddDate = DateTime.Now,
                    CopiesInLibrary = 50,
                    CopiesOutLibrary = 3,
                    AvailableCopies = 47,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    DeletedAt = null,
                    EVersion = true,
                    GenreId = 1

                }
                );

            modelBuilder.Entity<Genre>().HasData(
                new Genre
                {
                    Id = 1,
                    Name = "Fiction Books",  
                },
                new Genre
                {
                    Id = 2,
                    Name = "Non-Fiction Books",
                },
                new Genre
                {
                    Id = 3,
                    Name = "CD Genres"
                }
                
                );
        }

    }
}
