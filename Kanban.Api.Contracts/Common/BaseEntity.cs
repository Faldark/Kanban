using System;
using System.Collections.Generic;
using System.Text;

namespace Kanban.Api.Contracts.Common
{
    public abstract class BaseEntity<TKey> where TKey: IComparable
    {
        public TKey Id { get; set; }
    }
}
