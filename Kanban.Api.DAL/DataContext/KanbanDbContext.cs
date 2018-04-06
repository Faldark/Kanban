using Kanban.Api.Contracts.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kanban.Api.DAL.DataContext
{
    public class KanbanDbContext : DbContext
    {
        public DbSet<Card> Cards { get; set; }
        public DbSet<CardList> CardLists { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=FALDARK-PC\\SQLEXPRESS;Database=kanban;Trusted_Connection=True;");
        }
    }
}
