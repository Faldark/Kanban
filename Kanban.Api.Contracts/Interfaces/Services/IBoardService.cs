using Kanban.Api.Contracts.DTO;
using Kanban.Api.Contracts.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Kanban.Api.Contracts.Interfaces.Services
{
    public interface IBoardService
    {
        Task<BoardDTO> GetBoardByIdAsync(long id);
        Task<BoardsViewModel> GetBoardsAsync();
        Task CreateBoardAsync(BoardDTO board);
        Task UpdateBoardAsync(BoardDTO board);
        Task DeleteBoardAsync(long id);
    }
}
