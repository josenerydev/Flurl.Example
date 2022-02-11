using Flurl.Http;
using Flurl;
using Flurl.WebApi.Models;

using Newtonsoft.Json;

namespace Flurl.WebApi.Services
{
    public class MapService : IMapService
    {
        private readonly IFlurlClient _httpClient;
        private readonly string _uri;

        public MapService(HttpClient httpClient)
        {
            _httpClient = new FlurlClient(httpClient);
            _uri = "https://7790c6bf-b841-4861-b4eb-771358c0c53e.mock.pstmn.io/maps/api/distancematrix/json?units=imperial&origins=Dallas,Tx&destinations=Los%20Angeles,CA&key=9898ff77-d143-4bf9-8764-e20b92f4be6e";
        }

        public async Task<DistanceDto> GetDistance()
        {
            var distance = await _httpClient.Request(_uri).GetJsonAsync<DistanceDto>();

            return distance;
        }
    }
}
