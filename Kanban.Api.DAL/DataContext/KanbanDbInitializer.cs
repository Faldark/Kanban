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
            if (!_context.Statuses.Any())
            {
                _context.Statuses.Add(new Status
                {
                    
                    Name = "Backlog"
                });

                _context.Statuses.Add(new Status
                {
                    Name = "Selected for Development"
                });

                _context.Statuses.Add(new Status
                {
                    Name = "In Progress"
                });
                _context.Statuses.Add(new Status
                {
                    Name = "Done"
                });

                await _context.SaveChangesAsync();
            }
        }
    }

    
}
