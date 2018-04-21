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
    public class BoardsController : Controller
    {
        private IBoardService _boardService;
        public BoardsController(IBoardService boardService)
        {
            _boardService = boardService;
        }
        // GET: api/values
        [HttpGet]
        public async Task<IList<BoardDTO>> GetBoardsAsync()
        {
            return await _boardService.GetBoardsAsync();
            
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<BoardDTO> GetBoardByIdAsync(long id)
        {
            return await _boardService.GetBoardByIdAsync(id);
           
        }

        // POST api/values
        [HttpPost]
        public async Task CreateBoardAsync([FromBody]BoardDTO board)
        {
            await _boardService.CreateBoardAsync(board);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public async Task UpdateBoardAsync(long id, [FromBody]BoardDTO board)
        {
            await _boardService.UpdateBoardAsync(board);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public async Task DeleteBoardAsync(long id)
        {
            await _boardService.DeleteBoardAsync(id);
        }
    }
}
