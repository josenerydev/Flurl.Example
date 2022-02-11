using Flurl.WebApi.Models;
using Flurl.WebApi.Services;

using Microsoft.AspNetCore.Mvc;

namespace Flurl.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MapController : ControllerBase
    {
        private readonly IMapService _mapService;

        private readonly ILogger<MapController> _logger;

        public MapController(ILogger<MapController> logger, IMapService mapService)
        {
            _logger = logger;
            _mapService = mapService;
        }

        [HttpGet(Name = "GetDistance")]
        public async Task<DistanceDto> Get()
        {
            return await _mapService.GetDistance();
        }
    }
}