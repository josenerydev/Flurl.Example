using Flurl.Http;
using Flurl.WebApi.Models;

namespace Flurl.WebApi.Services
{
    public class MapService : IMapService
    {
        private readonly IFlurlClient _httpClient;
        private readonly string _segment;

        public MapService(HttpClient httpClient)
        {
            _httpClient = new FlurlClient(httpClient);
            _segment = "maps/api/distancematrix/json?units=imperial&origins=Dallas,Tx&destinations=Los%20Angeles,CA&key=9898ff77-d143-4bf9-8764-e20b92f4be6e";
        }

        public async Task<DistanceDto> GetDistance()
        {
            var distance = await _httpClient.Request(_segment).GetJsonAsync<DistanceDto>();

            return distance;
        }
    }
}
