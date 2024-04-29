﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Namshi.Domain.Entities
{
    public class BaseEntity<T>
    {
        public required T Id { get; set; }
    }
}
