using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

public class PizzaDbFactory : IDesignTimeDbContextFactory<PizzaDb>
{
    public PizzaDb CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<PizzaDb>();

        
        optionsBuilder.UseSqlite("Data Source=pizzastore.db");

        return new PizzaDb(optionsBuilder.Options);
    }
}
