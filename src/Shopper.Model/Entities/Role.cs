using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shopper.Model.Entities
{
    public class Role : EntityBase
    {
        public string RoleName { get; set; }
        public string Description { get; set; }
    }
}
