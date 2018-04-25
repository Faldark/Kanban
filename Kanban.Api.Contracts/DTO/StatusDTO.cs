using Kanban.Api.Contracts.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kanban.Api.Contracts.DTO
{
    public class StatusDTO: BaseEntity<long>
    {
        public string Name { get; set; }
    }
}
