using System.Net.Http.Headers;
using System.Security.Claims;
using System.Text.Json;

namespace SharpScape.Website.Services
{
    public class AppAuthStateProvider : AuthenticationStateProvider
    {
        private IAuthTokenProvider _tokenProvider;
        private HttpClient _http;

        public AppAuthStateProvider(IAuthTokenProvider authTokenProvider, HttpClient http)
        {
            _tokenProvider = authTokenProvider;
            _http = http;
        }

        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            ClaimsIdentity identity;
            if (_tokenProvider.Token is not null)
            {
                identity = new ClaimsIdentity(ParseClaimsFromJwt(_tokenProvider.Token), "jwt");
                _http.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _tokenProvider.Token);
            }
            else
            {
                identity = new ClaimsIdentity();
                _http.DefaultRequestHeaders.Authorization = null;
            }

            var user = new ClaimsPrincipal(identity);
            var state = new AuthenticationState(user);

            NotifyAuthenticationStateChanged(Task.FromResult(state));

            return state;
        }

        // The following methods shamelessly stolen from SteveSandersonMS as per Patrick God
        public static IEnumerable<Claim>? ParseClaimsFromJwt(string jwt)
        {
            if (jwt != null)
            {
                var body = jwt.Split(".")[1];
                var bodyJson = Base64UrlDecode(body);
                var keyValuePairs = JsonSerializer.Deserialize<Dictionary<string, object>>(bodyJson);
                return keyValuePairs?.Select(kvp => new Claim(kvp.Key, kvp.Value.ToString()!));
            }
            else
            {
                return null;
            }
        }

        private static byte[] Base64UrlDecode(string encoded)
        {
            switch (encoded.Length % 4)
            {
                case 2: encoded += "=="; break;
                case 3: encoded += "="; break;
            }
            return Convert.FromBase64String(encoded);
        }
    }
}