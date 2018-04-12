using Kanban.Api.Contracts.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kanban.Api.Contracts.DTO
{
    public class BoardDTO: BaseEntity<long>
    {
        public string Title { get; set; }
    }
}
