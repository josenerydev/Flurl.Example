using Flurl.WebApi.Models;

namespace Flurl.WebApi.Services
{
    public interface IMapService
    {
        Task<DistanceDto> GetDistance();
    }
}
