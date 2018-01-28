using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Fsd.Pzpn.Crew.Api.Services;
using Fsd.Pzpn.Crew.Api.Dtos;
using System.Linq;
using Fsd.Pzpn.Crew.Api.Projections;
using Fsd.Pzpn.Crew.Api.Entities;

namespace Fsd.Pzpn.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class PlayersController : Controller
    {
        private readonly IPlayersService _playersService;

        public PlayersController(IPlayersService playersService)
        {
            _playersService = playersService;
        }

        [HttpGet]
        public IEnumerable<PlayerSummaryDto> Get(string firstName, string lastName, int? number)
        {
            return _playersService
                .GetFiltered(firstName, lastName, number)
                .Select(PlayerProjections.ToSummary);
        }
    }
}
