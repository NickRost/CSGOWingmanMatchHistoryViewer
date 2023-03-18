using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSGOWingmanMatchHistoryViewer.Services
{
    public class MatchService
    {
        private readonly HttpClient _httpClient;
        public MatchService()
        {
            _httpClient = new HttpClient();
        }

        public async Task<string> GetMatchDetails(string matchToken, string cookiesHeader, string steamId)
        {
            _httpClient.BaseAddress = new Uri("https://steamcommunity.com/profiles/76561198141127669/gcpd/730");
            _httpClient.DefaultRequestHeaders.Add("Cookie", cookiesHeader);
            _httpClient.DefaultRequestHeaders.Add("Referer", $"https://steamcommunity.com/profiles/{steamId}/gcpd/730/?tab=matchhistorywingman");

            await _httpClient.GetAsync(matchToken);

            return "";
        }
    }
}
