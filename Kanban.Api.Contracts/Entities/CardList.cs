using Kanban.Api.Contracts.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kanban.Api.Contracts.Entities
{
    public class CardList: BaseEntity<int>
    {
        public string Title { get; set; }
        public ICollection<Card> Cards { get; set; }
    }
}
