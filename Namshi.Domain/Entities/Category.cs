using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Namshi.Domain.Entities
{
    public class Category: BaseEntity<int>
    {
        public required string Name { get; set; }
        public required string Description { get; set; }

        // Navigtional Property
        public virtual ICollection<Product> Products { get; set; } = new HashSet<Product>();
    }
}
