namespace Data
{
    using Data.Model;
    using Microsoft.EntityFrameworkCore;

    /// <summary>
    /// Product Database Context
    /// </summary>
    public class ProductContext : DbContext
    {
        /// <summary>
        /// Products Table
        /// </summary>
        public DbSet<Car> Products { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        public ProductContext()
        {
            // Create the database automaticly
            Database.EnsureCreated();
        }

        /// <summary>
        /// Connection string to Microsoft SQL Server
        /// </summary>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Database=CarShop20; Integrated Security=True");
        }
    }
}
