namespace ToolkitCore.Authentication;

/// <summary>Result type for authentication operations.</summary>
public sealed class AuthResult<T>
{
    private AuthResult(bool isSuccess, T value, string errorMessage, string errorCode)
    {
        IsSuccess = isSuccess;
        Value = value;
        ErrorMessage = errorMessage;
        ErrorCode = errorCode;
    }

    public bool IsSuccess { get; }
    public T Value { get; }
    public string ErrorMessage { get; }
    public string ErrorCode { get; }

    public static AuthResult<T> Success(T value)
    {
        return new AuthResult<T>(isSuccess: true, value, errorMessage: null, errorCode: null);
    }

    public static AuthResult<T> Failure(string errorMessage, string errorCode = null)
    {
        return new AuthResult<T>(isSuccess: false, value: default, errorMessage, errorCode);
    }
}