using Microsoft.EntityFrameworkCore;

public class Context : DbContext
{
    public DbSet<Tickets> tbl_Tickets { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("server=.\\SQL2019;database=AirlineDB;trusted_connection=true;MultipleActiveResultSets=True;TrustServerCertificate=True");
    }
}