﻿// <auto-generated />
using Kanban.Api.DAL.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace Kanban.Api.DAL.Migrations
{
    [DbContext(typeof(KanbanDbContext))]
    partial class KanbanDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Kanban.Api.Contracts.Entities.Board", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("Boards");
                });

            modelBuilder.Entity("Kanban.Api.Contracts.Entities.Card", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long?>("BoardId");

                    b.Property<string>("Description");

                    b.Property<int>("Position");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.HasIndex("BoardId");

                    b.ToTable("Cards");
                });

            modelBuilder.Entity("Kanban.Api.Contracts.Entities.Card", b =>
                {
                    b.HasOne("Kanban.Api.Contracts.Entities.Board", "Board")
                        .WithMany("Cards")
                        .HasForeignKey("BoardId");
                });
#pragma warning restore 612, 618
        }
    }
}
