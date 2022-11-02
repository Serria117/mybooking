using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using mybooking.domain.Entities;

namespace mybooking.repository.DataContext;

public class AppDbContext : IdentityDbContext<AppUser>
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
    }

    public DbSet<Apartment>     Apartments     { get; set; } = null!;
    public DbSet<RoomClass>     RoomClasses    { get; set; } = null!;
    public DbSet<AppRole>       AppRoles       { get; set; } = null!;
    public DbSet<AppUser>       AppUsers       { get; set; } = null!;
    public DbSet<ApartmentType> ApartmentTypes { get; set; } = null!;
}