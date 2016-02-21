using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace asp_lesson_5_10_a.Models
{
    public class BookDbInitializer : DropCreateDatabaseAlways<BookContext>
    {
        protected override void Seed(BookContext db)
        {
            Book b1 = new Book { Name = "Война и мир"};
            Book b2 = new Book { Name = "Отцы и дети" };
            Book b3 = new Book { Name = "Чайка"};

            db.Books.AddRange(new List<Book> {b1, b2, b3});

            db.Authors.Add(new Author{ Name = "Толстой", Books = new List<Book> {b1, b2}});
            db.Authors.Add(new Author { Name = "Чехов", Books = new List<Book> { b3 } });

            db.SaveChanges();
            base.Seed(db);
        }
    }
}