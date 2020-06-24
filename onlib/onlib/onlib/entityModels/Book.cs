using System;
using System.Collections.Generic;

namespace onlib
{
    public partial class Book
    {
        public Book()
        {
            AutorBook = new HashSet<AutorBook>();
            Basket = new HashSet<Basket>();
            BookCategory = new HashSet<BookCategory>();
            BookGenre = new HashSet<BookGenre>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? PubId { get; set; }
        public int? Price { get; set; }
        public string Description { get; set; }
        public int? AutorId { get; set; }
        public string Pictures { get; set; }


        public virtual Autor Autor { get; set; }
        public virtual Pub Pub { get; set; }
        public virtual ICollection<AutorBook> AutorBook { get; set; }
        public virtual ICollection<Basket> Basket { get; set; }
        public virtual ICollection<BookCategory> BookCategory { get; set; }
        public virtual ICollection<BookGenre> BookGenre { get; set; }
    }
}
