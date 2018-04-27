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
        public DbSet<Board> Boards { get; set; }
        public DbSet<Status> Statuses { get; set; }
        //public KanbanDbContext() {
        //    this.Configuration.LazyLoadingEnabled = false;
        //}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=FALDARK-PC\\SQLEXPRESS;Database=Kanban;Trusted_Connection=True;");
        }
    }
}
