using EF_Task_2.Entities;
using Microsoft.EntityFrameworkCore;

namespace EF_Task_2.Contexts;

public class LibraryDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string connectionString = "Data Source = DESKTOP-RH41O1K\\SQLEXPRESS;" +
            "Initial Catalog = Library_Db_1;" +
            "Integrated Security = True;" +
            "Connect Timeout = 30;" +
            "Encrypt = True;" +
            "Trust Server Certificate = True;" +
            "Application Intent = ReadWrite;" +
            "Multi Subnet Failover = False";

        optionsBuilder.UseSqlServer(connectionString);
        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);

        base.OnModelCreating(modelBuilder);
    }

    public DbSet<Author> Authors { get; set; }
    public DbSet<Book> Books { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Department> Departments { get; set; }
    public DbSet<Faculty> Faculties { get; set; }
    public DbSet<Group> Groups { get; set; }
    public DbSet<Lib> Libs { get; set; }
    public DbSet<Press> Press { get; set; }
    public DbSet<S_Card> S_Cards { get; set; }
    public DbSet<Student> Students { get; set; }
    public DbSet<T_Card> T_Cards { get; set; }
    public DbSet<Teacher> Teachers { get; set; }
    public DbSet<Theme> Themes { get; set; }
}