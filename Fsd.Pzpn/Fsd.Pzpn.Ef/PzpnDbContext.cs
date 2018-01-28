using Fsd.Pzpn.Crew.Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace Fsd.Pzpn.Ef
{
    public class PzpnDbContext : DbContext
    {
        public DbSet<Player> Players { get; set; }

        public DbSet<ClubPlayer> ClubPlayers { get; set; }

        public DbSet<FootballClub> FootballClubs { get; set; }

        public PzpnDbContext(DbContextOptions<PzpnDbContext> options) 
            : base(options)
        {
        }
    }
}
