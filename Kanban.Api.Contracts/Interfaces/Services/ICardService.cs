using Kanban.Api.Contracts.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Kanban.Api.Contracts.Interfaces.Services
{
    public interface ICardService
    {
        Task<CardDTO> GetCardByIdAsync(long id);
        Task<List<CardDTO>> GetCardsByBoardAsync(long id);
        Task CreateCardAsync(CardDTO card);
        Task UpdateCardAsync(CardDTO card);
        Task DeleteCardAsync(long id);
        Task MoveCardAsync(CardDTO card);
    }
}
