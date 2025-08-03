using BookStoreAPI2.Model;
using Microsoft.AspNetCore.Mvc;

namespace BookStoreAPI2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookController : ControllerBase
    {

        [HttpGet(Name = "GetBooks")]
        public List<BookEntity> Get()
        {
            BookStoreDAL dal = new BookStoreDAL();
          
            var books = dal.GetBooks();
            return books;
        }
    }
}
