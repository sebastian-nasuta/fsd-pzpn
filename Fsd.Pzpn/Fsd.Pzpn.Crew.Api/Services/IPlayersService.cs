using Fsd.Pzpn.Crew.Api.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Fsd.Pzpn.Crew.Api.Services
{
    public interface IPlayersService
    {
        IEnumerable<Player> GetAll();
        IQueryable<Player> GetFiltered(string firstNameQuery = null, string lastNameQuery = null, int? numberFromQuery = null);
    }
}
