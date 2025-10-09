using Newtonsoft.Json;

namespace ToolkitCore.Authentication;

internal sealed class ErrorResponse
{
    [JsonProperty("status")] public int Status { get; set; }
    [JsonProperty("message")] public string Message { get; set; }
}