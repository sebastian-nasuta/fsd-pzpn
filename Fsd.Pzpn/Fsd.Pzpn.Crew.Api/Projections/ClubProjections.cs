using Fsd.Pzpn.Crew.Api.Dtos;
using Fsd.Pzpn.Crew.Api.Entities;
using System.Linq;

namespace Fsd.Pzpn.Crew.Api.Projections
{
    public class ClubProjections
    {
        public static ClubSummaryDto ToSummary(FootballClub team)
        {
            return new ClubSummaryDto
            {
                Id = team.Id,
                Name = team.Name,
                Players = team.ClubPlayers.Select(map => PlayerProjections.ToSummary(map.Player))
            };
        }
    }
}
