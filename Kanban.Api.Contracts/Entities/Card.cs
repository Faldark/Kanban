using Kanban.Api.Contracts.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kanban.Api.Contracts.Entities
{
    public class Card : BaseEntity<long>
    {
        // for all Entities
        public Card() {
            this.Board = new Board();
            this.Status = new Status();
        }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Order { get; set; }
        public Board Board { get; set; }
        public Status Status { get; set; }
        //for necessary entities
        public long BoardId { get; set; }
        public long StatusId { get; set; }
    }
}
