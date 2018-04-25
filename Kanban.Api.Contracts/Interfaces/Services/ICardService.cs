using Kanban.Api.Contracts.DTO;
using Kanban.Api.Contracts.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Kanban.Api.Contracts.Interfaces.Services
{
    public interface ICardService
    {
        Task<CardDTO> GetCardByIdAsync(long id);
        Task<CardsViewModel> GetCardsByBoardAsync(long id);
        Task CreateCardAsync(CardDTO card);
        Task UpdateCardAsync(CardDTO card);
        Task DeleteCardAsync(long id);
        Task MoveCardAsync(CardDTO card);
    }
}
