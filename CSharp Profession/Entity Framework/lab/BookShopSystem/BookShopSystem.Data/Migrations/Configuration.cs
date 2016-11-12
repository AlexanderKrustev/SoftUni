namespace BookShopSystem.Data.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using BookShopSystem.Models;
    using BookShopSystem.Models.Enums;

    public sealed class Configuration : DbMigrationsConfiguration<BookShopSystem.Data.BookShopContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            ContextKey = "BookShopSystem.Data.BookShopContext";
        }

        protected override void Seed(BookShopContext context)
        {
           
            var random= new Random();
           // SeedCategory(context);
            
           // SeedAuthors(context);
            context.SaveChanges();

            var authors = context.Authors.ToList();
            var category = context.Categories.ToList();
          //  SeedBooks(context, random, authors, category);
          //  context.SaveChanges();

        }

        private void SeedBooks(BookShopContext context, Random random, List<Author> authors, List<Category> categories)
        {

            using (var reader = new StreamReader("books.txt"))
            {
                var line = reader.ReadLine();
                line = reader.ReadLine();
                while (line != null)
                {
                    var data = line.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                    var authorIndex = random.Next(0, authors.Count);
                    var author = authors[authorIndex];
                    var edition = (BookType) int.Parse(data[0]);
                    var releaseDate = DateTime.ParseExact(data[1], "d/M/yyyy", CultureInfo.InvariantCulture);
                    var copies = int.Parse(data[2]);
                    var price = decimal.Parse(data[3]);
                    var ageRestriction = (Age) int.Parse(data[4]);
                    var title = data[5];
                    for (int i = 6; i < data.Length; i++)
                    {
                        title += data[i];
                    }

                    int numberOfCategories = random.Next(1, categories.Count);
                    ICollection<Category> currentBookCategory =
                        new List<Category>();

                    while (numberOfCategories > 0)
                    {
                        currentBookCategory.Add(context.Categories.Find(random.Next(0, context.Categories.Count())));

                        numberOfCategories--;
                    }

                    context.Books.Add(new Book()
                    {
                        Author = author,
                        EditionType = edition,
                        ReleaseDate = releaseDate,
                        Copies = copies,
                        Price = price,
                        AgeRestriction = ageRestriction,
                        Title = title,
                        Categories = currentBookCategory
                    });

                    line = reader.ReadLine();
                }
            }

        }

        private void SeedAuthors(BookShopContext context)
        {

            using (var reader = new StreamReader("authors.txt"))
            {
                var line = reader.ReadLine();
                line = reader.ReadLine();
                while (line != null)
                {
                    var data = line.Split(new[] { ' ' }, 6);
                    var firstName = data[0];
                    var lastName = data[1];

                    context.Authors.Add(new Author()
                    {
                        FirstName = firstName,
                        LastName = lastName
                        
                    });

                    line = reader.ReadLine();
                    
                }
            }

        }

        private void SeedCategory(BookShopContext context)
        {

            using (var reader = new StreamReader("categories.txt"))
            {
                var line = reader.ReadLine();
                line = reader.ReadLine();
                while (line != null)
                {
                    var category = line;

                    context.Categories.Add(new Category()
                    {
                        Name = category

                    });

                  line = reader.ReadLine();
                 
                }
            }

        }

        
    }
}
