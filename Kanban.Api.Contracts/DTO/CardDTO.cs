﻿using Kanban.Api.Contracts.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kanban.Api.Contracts.DTO
{
    public class CardDTO: BaseEntity<long>
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int Position { get; set; }
    }
}
