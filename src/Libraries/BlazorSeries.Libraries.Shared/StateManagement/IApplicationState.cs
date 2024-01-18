namespace BlazorSeries.Libraries.Shared.StateManagement;

public interface IApplicationState
{
    event Action? Observer;

    string Status { get; }

    void DisplaySuccess();

    void DisplayFailure();
}
