using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EntityFrameworkExam
{
    public static class MyHelpers
    {
        public static List<Author> SearchForAnAuthor(string searchText)
        {
            using (var ctx = new BooksEntities1())
            {
                List<Author> authorSearch =
                    ctx.Authors.Where(a => a.FirstName.Contains(searchText) || a.LastName.Contains(searchText)).ToList();
                return authorSearch;
            }
        }

        public static List<Title> SearchForTitles(string searchText)
        {
            using (var ctx = new BooksEntities1())
            {
                List<Title> titleSearch = ctx.Titles.Where(t => t.Title1.Contains(searchText)).ToList();
                return titleSearch;
            }
        }

        public static List<Title> PopulateGridviewWithBooksFromASelectedAuthor(string id)
        {
            using (var ctx = new BooksEntities1())
            {
                ctx.Authors.Load();
                var populateGridviewWithBooks = ctx.Authors.Local.Where(a => a.AuthorID == Convert.ToInt32(id)).First();

                var bookQuery = populateGridviewWithBooks.Titles.OrderBy(t => t.Title1).ToList();
                return bookQuery;
            }
        }

        public static Author AddAuthor(string firstName, string lastName, string country)
        {
            using (var ctx = new BooksEntities1())
            {
                Author newAuthor = new Author();
                newAuthor.FirstName = firstName;
                newAuthor.LastName = lastName;
                newAuthor.CountryOfResidence = country;

                ctx.Authors.Add(newAuthor);
                ctx.SaveChanges();
                return newAuthor;
            }
        }
    }
}