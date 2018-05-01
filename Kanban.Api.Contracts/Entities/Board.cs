using Kanban.Api.Contracts.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kanban.Api.Contracts.Entities
{
    public class Board: BaseEntity<long>
    {
        public Board() {
            this.Cards = new List<Card>();
        }
        public string Title { get; set; }
        public string Description { get; set; }
        public ICollection<Card> Cards { get; set; }
        
    }
}
