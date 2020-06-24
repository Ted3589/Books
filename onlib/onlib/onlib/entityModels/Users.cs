using System;
using System.Collections.Generic;

namespace onlib
{
    public partial class Users
    {
        public Users()
        {
            Basket = new HashSet<Basket>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int? RoleId { get; set; }

        public virtual Role Role { get; set; }
        public virtual ICollection<Basket> Basket { get; set; }
    }
}
