using Microsoft.EntityFrameworkCore;
using ToDoServices.API.Model;

namespace ToDoServices.API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<TodoTask> TodoTasks { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TodoTask>().HasData(
                               new TodoTask
                               {
                                   Id = 1,
                                   Tile = "Task 1",
                                   Description = "Description 1",
                                   IsCompleted = false
                               },
                                              new TodoTask
                                              {
                                                  Id = 2,
                                                  Tile = "Task 2",
                                                  Description = "Description 2",
                                                  IsCompleted = false
                                              },
                                                             new TodoTask
                                                             {
                                                                 Id = 3,
                                                                 Tile = "Task 3",
                                                                 Description = "Description 3",
                                                                 IsCompleted = false
                                                             }
                                                                        );

        }

    }
}
