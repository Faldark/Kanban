using Kanban.Api.Contracts.DTO;
using Kanban.Api.Contracts.Entities;
using Kanban.Api.Contracts.Interfaces.Services;
using Kanban.Api.Contracts.ViewModels;
using Kanban.Api.DAL.DataContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kanban.Api.BLL.Services
{
    public class BoardService: IBoardService
    {
        private KanbanDbContext _dbContext;
        public BoardService(KanbanDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<BoardDTO> GetBoardByIdAsync(long id)
        {
            var board = await _dbContext.Boards.FindAsync(id);
            return new BoardDTO
            {
                Id = board.Id,
                Title = board.Title
            };
        }

        public async Task<BoardsViewModel> GetBoardsAsync()
        {
            var boards = await _dbContext.Boards.ToListAsync();

            var result = new BoardsViewModel() { Boards = boards.Select(x => new BoardDTO
                {
                    Id = x.Id,
                    Title = x.Title,
                    Description = x.Description
                }).ToList()
            };
            return result;

        }

        public async Task CreateBoardAsync(BoardDTO board)
        {
            
            var entity = new Board
            {
                Description = board.Description,
                Title = board.Title

            };
            await _dbContext.Boards.AddAsync(entity);
            await _dbContext.SaveChangesAsync();
        }
        public async Task UpdateBoardAsync(BoardDTO board)
        {
            var entity = await _dbContext.Boards.FindAsync(board.Id);
            entity.Title = board.Title;
            entity.Description = board.Description;
            _dbContext.Boards.Update(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteBoardAsync(long id)
        {
            var entity = await _dbContext.Boards.FindAsync(id);
            _dbContext.Boards.Remove(entity);
        }
        
    }
}
