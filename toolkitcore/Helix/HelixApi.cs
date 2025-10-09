using System;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ToolkitCore.Helix;

public static class HelixApi
{
    /// <summary>Validates a Twitch OAuth token.</summary>
    /// <param name="token">The Twitch OAuth token to validate.</param>
    /// <param name="cancellationToken">The cancellation token to use for the request.</param>
    /// <returns>A result containing the token validation response, indicating the success or failure of token validation.</returns>
    /// <exception cref="ArgumentNullException">Thrown if the token is null or empty.</exception>
    public static async Task<Result<TokenValidationResponse>> ValidateTokenAsync(string token, CancellationToken cancellationToken = default)
    {
        if (string.IsNullOrEmpty(token)) throw new ArgumentNullException(nameof(token));

        using (var request = new HttpRequestMessage(HttpMethod.Get, requestUri: "https://id.twitch.tv/oauth2/validate"))
        {
            request.Headers.Add(name: "Authorization", $"OAuth {token}");

            HttpResponseMessage response = await GlobalResources.Client.SendAsync(request, cancellationToken).ConfigureAwait(false);

            switch (response.StatusCode)
            {
                case HttpStatusCode.Unauthorized: return Result.Fail<TokenValidationResponse>("Token is invalid or expired");
                case HttpStatusCode.OK:
                {
                    string content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    return Result.Ok(JsonConvert.DeserializeObject<TokenValidationResponse>(content));
                }
                default: return Result.Fail<TokenValidationResponse>("Failed to validate oauth token");
            }
        }
    }
}