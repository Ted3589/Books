using System;
using System.Collections.Generic;

namespace onlib
{
    public partial class Category
    {
        public Category()
        {
            BookCategory = new HashSet<BookCategory>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<BookCategory> BookCategory { get; set; }
    }
}
