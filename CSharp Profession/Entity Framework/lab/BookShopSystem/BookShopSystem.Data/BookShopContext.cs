namespace BookShopSystem.Data
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using BookShopSystem.Models;

    public class BookShopContext : DbContext
    {
       
        public BookShopContext()
            : base("name=BookShopContext")
        {
           // var migrationStrategy = new DropCreateDatabaseAlways<BookShopContext>();
          // Database.SetInitializer(migrationStrategy);
            
        }

        public IDbSet<Book> Books { get; set; }

        public IDbSet<Author> Authors { get; set; }

        public IDbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>()
                .HasMany(x => x.RelatedBooks)
                .WithMany()
                .Map(m =>
                {
                    m.MapLeftKey("Book");
                    m.MapRightKey("RelatedBook");
                    m.ToTable("RetaledBooks");
                });
            base.OnModelCreating(modelBuilder);
        }
    }
 
}