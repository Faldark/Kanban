using Kanban.Api.Contracts.DTO;
using Kanban.Api.Contracts.Entities;
using Kanban.Api.Contracts.Interfaces.Services;
using Kanban.Api.DAL.DataContext;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Kanban.Api.BLL.Services
{
    public class CardService: ICardService
    {
        private KanbanDbContext _dbContext;
        public CardService(KanbanDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<CardDTO> GetCardByIdAsync(long id)
        {
            var card = await _dbContext.Cards.FindAsync(id);
            return new CardDTO
            {
                Id = card.Id,
                Description = card.Description,
                Order = card.Order,
                Title = card.Title,
                StatusId = card.Status.Id
            };
        }

        public async Task CreateCardAsync(CardDTO card)
        {
            var status = await _dbContext.Statuses.FindAsync(card.StatusId);
            var entity = new Card
            {
                Description = card.Description,
                Order = card.Order,
                Title = card.Title

            };
            await _dbContext.Cards.AddAsync(entity);
            await _dbContext.SaveChangesAsync();
        }
        public async Task UpdateCardAsync(CardDTO card)
        {
            var entity = await _dbContext.Cards.FindAsync(card.Id);
            entity.Title = card.Title;
            entity.Description = card.Description;
            _dbContext.Cards.Update(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteCardAsync(long id)
        {
            var entity = await _dbContext.Cards.FindAsync(id);
            _dbContext.Cards.Remove(entity);
        }

    }
}
