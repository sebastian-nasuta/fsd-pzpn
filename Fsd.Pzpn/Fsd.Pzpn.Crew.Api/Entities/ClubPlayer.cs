namespace Fsd.Pzpn.Crew.Api.Entities
{
    public class ClubPlayer
    {
        public int Id { get; set; }

        public int PlayerId { get; set; }

        public int FootballClubId { get; set; }

        public Player Player { get; set; }

        public FootballClub FootballClub { get; set; }
    }
}
