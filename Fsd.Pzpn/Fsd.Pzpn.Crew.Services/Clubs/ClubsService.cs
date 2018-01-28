using Fsd.Pzpn.Crew.Api.Services;
using Fsd.Pzpn.Crew.Api.Entities;
using Fsd.Pzpn.Ef;
using System.Linq;

namespace Fsd.Pzpn.Crew.Services.Clubs
{
    public class ClubsService : IClubsService
    {
        private readonly PzpnDbContext _dbContext;

        public ClubsService(PzpnDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public FootballClub Get(int id)
        {
            return _dbContext.FootballClubs.FirstOrDefault(club => club.Id == id);
        }
    }
}
