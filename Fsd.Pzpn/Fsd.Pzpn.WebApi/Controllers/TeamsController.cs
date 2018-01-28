using Microsoft.AspNetCore.Mvc;
using Fsd.Pzpn.Crew.Api.Dtos;
using Fsd.Pzpn.Crew.Api.Services;
using Fsd.Pzpn.Crew.Api.Projections;

namespace Fsd.Pzpn.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class TeamsController : Controller
    {
        private readonly IClubsService _clubService;

        public TeamsController(IClubsService clubService)
        {
            _clubService = clubService;
        }

        [HttpGet("{id}")]
        public ClubSummaryDto Get(int id)
        {
            var team = _clubService.Get(id);
            return team != null ? ClubProjections.ToSummary(team) : null;
        }
    }
}
