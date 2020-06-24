using System;
using System.Collections.Generic;

namespace onlib
{
    public partial class Pub
    {
        public Pub()
        {
            Book = new HashSet<Book>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }

        public virtual ICollection<Book> Book { get; set; }
    }
}
