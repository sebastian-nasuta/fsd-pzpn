using System.Collections.Generic;

namespace Fsd.Pzpn.Crew.Api.Entities
{
    public class Player
    {
        public int Id { get; set; }

        public int Number { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public ICollection<ClubPlayer> ClubPlayers { get; set; }
    }
}
