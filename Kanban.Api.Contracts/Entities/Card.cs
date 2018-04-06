using Kanban.Api.Contracts.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kanban.Api.Contracts.Entities
{
    public class Card : BaseEntity<int>
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public CardList CardList { get; set; }
    }
}
