using Microsoft.EntityFrameworkCore;
namespace Hospital.Infrastructure;

public class HospitalContext : DbContext
{

    public HospitalContext()
    {

    }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=Hospital;Trusted_Connection=True;");
    }
}