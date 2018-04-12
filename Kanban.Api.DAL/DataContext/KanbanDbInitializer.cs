using Kanban.Api.Contracts.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kanban.Api.DAL.DataContext
{
    public class KanbanDbInitializer
    {
        private KanbanDbContext _context;

        public KanbanDbInitializer(KanbanDbContext context)
        {
            _context = context;
        }

        public async Task Seed()
        {
            if (!_context.Boards.Any())
            {
                _context.Boards.Add(new Board
                {
                    Cards = new List<Card>(),
                    Title = "Backlog"
                });

                _context.Boards.Add(new Board
                {
                    Cards = new List<Card>(),
                    Title = "Selected for Development"
                });

                _context.Boards.Add(new Board
                {
                    Cards = new List<Card>(),
                    Title = "In Progress"
                });
                _context.Boards.Add(new Board
                {
                    Cards = new List<Card>(),
                    Title = "Done"
                });

                await _context.SaveChangesAsync();
            }
        }
    }

    
}
