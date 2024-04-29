using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Namshi.Domain.Entities
{
    public class Product: BaseEntity<int>
    {
        public required string Name { get; set; }
        public required string Description { get; set; }
        public required decimal Price { get; set; }

        // Navigtional Property
        public required int CategoryId { get; set; }
        public virtual Category? Category { get; set; }
    }
}
