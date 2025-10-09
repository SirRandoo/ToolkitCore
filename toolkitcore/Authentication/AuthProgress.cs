namespace ToolkitCore.Authentication;

/// <summary>Progress information for authentication flow.</summary>
public sealed class AuthProgress(AuthProgressState state, string message)
{
    public AuthProgressState State { get; } = state;
    public string Message { get; } = message;
}