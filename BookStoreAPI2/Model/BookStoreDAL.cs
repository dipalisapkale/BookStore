using System.Reflection.Metadata.Ecma335;

namespace BookStoreAPI2.Model
{
    public class BookStoreDAL
    {
        public List<BookEntity> GetBooks()
        {

            BookEntity book = new BookEntity();
            List<BookEntity> books = new List<BookEntity>();

            book.Id = 1;
            book.Title = "The Monk Who Sold His Ferrari";
            book.Author = "James";
            book.Price = 456;
            books.Add(book);

            book=  new BookEntity();
            book.Id = 2;
            book.Title = "MyGrandma";
            book.Author = "SudhaMurti";
            book.Price = 350;
            books.Add(book);

            return books;

        }
       


    }
}
