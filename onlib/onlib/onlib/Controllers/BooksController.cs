using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using onlib;

namespace onlib.Controllers
{
        [Route("Catalogs")]
        public class BooksController : Controller
        {
            static readonly List<Book> data;
            static BooksController()
            {
                using (booksContext db = new booksContext())
                {
                    data = db.Book.ToList();
                }
            }

            [HttpGet("")]
            public IEnumerable<Book> Get()
            {
                return data;
            }

        }

    
}
