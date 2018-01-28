using System.Collections.Generic;

namespace Fsd.Pzpn.Crew.Api.Entities
{
    public class FootballClub
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<ClubPlayer> ClubPlayers { get; set; }
    }
}
