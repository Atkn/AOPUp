using System;
using System.Collections.Generic;
using System.Text;

namespace Aup.Core.Entity
{
    public class BaseEntity : IEntity
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
    }
}
