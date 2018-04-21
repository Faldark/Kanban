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
            }
            await _context.SaveChangesAsync();
            var status = await _context.Statuses.FirstOrDefaultAsync();
            if (!_context.Boards.Any())
            {
                _context.Boards.Add(new Board
                {
                    Title = "Develop yourself",
                    Description = "To develop yourself as a personality, improve old and add new skills",
                    Cards = new List<Card>(){
                        new Card
                        {
                            Title = "Develop your mind",
                            Description = "Read intersting books, always try something new every day",
                            Order = 1,
                            Status = status
                        },
                        new Card
                        {
                            Title = "Develop your body",
                            Description = "Run or do workout 3 times a week, dont eat junk food",
                            Order = 2,
                            Status = status
                        },
                        new Card
                        {
                            Title = "Develop your spirit",
                            Description = "Improve your power of will by doing previous two cards, its a slow and tedious process but totally worth it",
                            Order = 3,
                            Status = status
                        },
                    }

                });
                _context.Boards.Add(new Board
                {
                    Title = "Read 99 books",
                    Description = "To read 99 books each year",
                    Cards = new List<Card>(){
                        new Card
                        {
                            Title = "Read 33 books each 4 months",
                            Description = "Just read, anything you desire",
                            Order = 1,
                            Status = status
                        },
                        new Card
                        {
                            Title = "Read 99 books each 12 months",
                            Description = "Just read, anything you desire",
                            Order = 2,
                            Status = status
                        },
                        new Card
                        {
                            Title = "Read 11 books each 1,5 months",
                            Description = "Just read, anything you desire",
                            Order = 3,
                            Status = status
                        },
                    }

                });
            }


            await _context.SaveChangesAsync();
        }
    }

    
}
