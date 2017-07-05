using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shopper.Model.Entities
{
    public class User : EntityBase
    {
        public string UserName { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
        public Gender Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public string Photo { get; set; }
        public string Confirmation { get; set; }
        public bool isConfirmed { get; set; }
    }
}
