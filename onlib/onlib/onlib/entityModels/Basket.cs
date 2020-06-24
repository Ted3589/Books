using System;
using System.Collections.Generic;

namespace onlib
{
    public partial class Basket
    {
        public int Id { get; set; }
        public int? BookId { get; set; }
        public int? Quantity { get; set; }
        public DateTime? DateSending { get; set; }
        public int? UsersId { get; set; }

        public virtual Book Book { get; set; }
        public virtual Users Users { get; set; }
    }
}
