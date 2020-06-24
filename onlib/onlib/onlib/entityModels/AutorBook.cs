using System;
using System.Collections.Generic;

namespace onlib
{
    public partial class AutorBook
    {
        public int Id { get; set; }
        public int? AutorId { get; set; }
        public int? BookId { get; set; }

        public virtual Autor Autor { get; set; }
        public virtual Book Book { get; set; }
    }
}
