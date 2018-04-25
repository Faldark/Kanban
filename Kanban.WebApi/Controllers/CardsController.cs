using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Kanban.Api.Contracts.Interfaces.Services;
using Kanban.Api.Contracts.DTO;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Kanban.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class CardsController : Controller
    {
        private ICardService _cardService;
        public CardsController(ICardService cardService)
        {
            _cardService = cardService;
        }
        
        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<CardDTO> GetCardByIdAsync(long id)
        {
            return await _cardService.GetCardByIdAsync(id);
        }

        // POST api/values
        [HttpPost]
        public async Task CreateCard([FromBody]CardDTO card)
        {
            await _cardService.CreateCardAsync(card);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public async Task UpdateCardAsync(long id, [FromBody]CardDTO card)
        {
            await _cardService.UpdateCardAsync(card);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public async Task DeleteCardAsync(long id)
        {
            await _cardService.DeleteCardAsync(id);
        }

        // Move api/values/5/move
        [HttpPut("{id}/move")]
        public async Task MoveCardAsync(long id, [FromBody]CardDTO card)
        {
            await _cardService.MoveCardAsync(card);
        }


    }
}
