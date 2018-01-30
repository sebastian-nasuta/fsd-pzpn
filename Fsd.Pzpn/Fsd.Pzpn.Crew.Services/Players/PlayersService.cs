using System.Collections.Generic;
using Fsd.Pzpn.Crew.Api.Entities;
using Fsd.Pzpn.Crew.Api.Services;
using Fsd.Pzpn.Ef;
using System.Linq;

namespace Fsd.Pzpn.Crew.Services.Players
{
    public class PlayersService : IPlayersService
    {
        private readonly PzpnDbContext _dbContext;

        public PlayersService(PzpnDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Player> GetAll()
        {
            return _dbContext.Players;
        }

        public IQueryable<Player> GetFiltered(string firstNameQuery = null, string lastNameQuery = null, int? numberFromQuery = null)
        {
            var query = _dbContext.Players.Select(item => item);

            if (!string.IsNullOrEmpty(firstNameQuery))
                query = query.Where(item => item.FirstName.Contains(firstNameQuery));

            if (!string.IsNullOrEmpty(lastNameQuery))
                query = query.Where(item => item.LastName.Contains(lastNameQuery));

            if (numberFromQuery.HasValue)
                query = query.Where(item => item.Number >= numberFromQuery);

            return query;
        }

        public void AddNewPlayer(string firstNameQuery, string lastNameQuery, int numberFromQuery)
        {
            _dbContext.Players.Add(new Player
            {
                Number = numberFromQuery,
                FirstName = firstNameQuery,
                LastName = lastNameQuery,
            });
            _dbContext.SaveChanges();
        }
    }
}
