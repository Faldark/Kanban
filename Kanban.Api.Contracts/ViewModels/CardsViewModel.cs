using Kanban.Api.Contracts.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kanban.Api.Contracts.ViewModels
{
    public class CardsViewModel
    {
        public IEnumerable<CardDTO> Cards { get; set; }
    }
}
