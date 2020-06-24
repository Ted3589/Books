using System;
using System.Collections.Generic;

namespace onlib
{
    public partial class Autor
    {
        public Autor()
        {
            AutorBook = new HashSet<AutorBook>();
            Book = new HashSet<Book>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public DateTime? Birthdate { get; set; }

        public virtual ICollection<AutorBook> AutorBook { get; set; }
        public virtual ICollection<Book> Book { get; set; }
    }
}
