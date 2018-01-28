using Fsd.Pzpn.Crew.Api.Dtos;
using Fsd.Pzpn.Crew.Api.Entities;

namespace Fsd.Pzpn.Crew.Api.Projections
{
    public class PlayerProjections
    {
        public static PlayerSummaryDto ToSummary(Player player)
        {
            return new PlayerSummaryDto
            {
                Id = player.Id,
                FirstName = player.FirstName,
                LastName = player.LastName,
                Number = player.Number,
            };
        }
    }
}
