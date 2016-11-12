namespace BookShopSystem.ConsoleClient
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using BookShopSystem.Data;
    using BookShopSystem.Data.Migrations;


    public class Program
    {
        static void Main()
        {
           var context=new BookShopContext();
           
            var migrationStrategy = new MigrateDatabaseToLatestVersion<BookShopContext,Configuration>();
            Database.SetInitializer(migrationStrategy);
            context.Database.Initialize(true);

          //  BooksAfter2000(context);

          //  AuthorsWithBookBefore1990(context);

          //  BookFromSpecificAuthor(context,"George Powell");

         //   TestBookRealtions(context);

        }

        public static void BooksAfter2000(BookShopContext context)
        {
            var result = context.Books.Where(x => x.ReleaseDate.Year > 2000);

            foreach (var book in result)
            {
                Console.WriteLine($"{book.Title}");
            }
        }

        public static void AuthorsWithBookBefore1990(BookShopContext context)
        {
            var result = context.Books.Where(x => x.ReleaseDate.Year < 1990);

            foreach (var book in result)
            {
                Console.WriteLine($"{book.Author.FirstName} {book.Author.LastName}");
            }
        }

        public static void BookFromSpecificAuthor(BookShopContext context, string authorName)
        {
            string[] authorNames = authorName.Split(new []{' '});
            string firstName = authorNames[0];
            string secondName = authorNames[1];
            var books = context.Books
                .Where(x => x.Author.FirstName==firstName && x.Author.LastName==secondName)
                .OrderByDescending(x => x.ReleaseDate)
                .OrderBy(x => x.Title);

            foreach (var book in books)
            {
                Console.WriteLine($"{book.Title} {book.ReleaseDate} {book.Copies}");
            }
        }

        public static void TestBookRealtions(BookShopContext context)
        {
            var books = context.Books
                               .Take(3)
                               .ToList();

            books[0].RelatedBooks.Add(books[1]);
            books[1].RelatedBooks.Add(books[0]);
            books[0].RelatedBooks.Add(books[2]);
            books[2].RelatedBooks.Add(books[0]);

            context.SaveChanges();

            var booksFromQuery = context.Books.Take(3);
            
            foreach (var book in booksFromQuery)
            {
                Console.WriteLine("--{0}", book.Title);
                foreach (var relatedBook in book.RelatedBooks)
                {
                    Console.WriteLine(relatedBook.Title);
                }
            }

        }
    }
}
