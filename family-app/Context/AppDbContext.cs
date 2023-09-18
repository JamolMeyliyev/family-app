using family_app.Entities;
using family_app.Entities.Account;
using Microsoft.EntityFrameworkCore;

namespace family_app.Context;

public class AppDbContext:DbContext
{
    public DbSet<Address> addresses { get; set; }
    public DbSet<Cost> costs { get; set; }
    public DbSet<Family> families { get; set; }
    public DbSet<Holiday> holidays { get; set; }
    public DbSet<Home> homes { get; set; }
    public DbSet<Home_Family> homes_families { get; set;}
    public DbSet<Income> incomes { get; set; }
    public DbSet<Message> messages { get; set; }
    public DbSet<User> users { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

}
