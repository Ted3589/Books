using System;
using System.Collections.Generic;

namespace onlib
{
    public partial class Genre
    {
        public Genre()
        {
            BookGenre = new HashSet<BookGenre>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<BookGenre> BookGenre { get; set; }
    }
}
