﻿using System;
using System.Collections.Generic;

namespace onlib
{
    public partial class Role
    {
        public Role()
        {
            Users = new HashSet<Users>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? Key { get; set; }

        public virtual ICollection<Users> Users { get; set; }
    }
}
