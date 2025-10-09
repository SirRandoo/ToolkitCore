namespace ToolkitCore.Authentication;

public enum AuthProgressState
{
    Initiating,
    WaitingForUser,
    Polling,
    Completed,
    Failed
}