using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shopper.Model
{
    public interface IEntityBase
    {
        long Id { get; set; }
        DateTime CreatedDate { get; set; }
        string CreatedBy { get; set; }
        DateTime ModifiedDate { get; set; }
        string ModifiedBy { get; set; }
        bool isActive { get; set; }
        bool Delete { get; set; }
    }

    public class EntityBase : IEntityBase
    {
        public long Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public bool isActive { get; set; }
        public bool Delete { get; set; }
    }
}
