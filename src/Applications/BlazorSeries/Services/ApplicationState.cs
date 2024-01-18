using BlazorSeries.Libraries.Shared.StateManagement;
using Microsoft.AspNetCore.Components;

namespace BlazorSeries.Services;

internal sealed class ApplicationState : IApplicationState
{
    public string Status { get; private set; } = string.Empty;

    public event Action? Observer;

    public void DisplayFailure()
    {
        Status = "Failure occurred!";
        Observer?.Invoke();
    }

    public void DisplaySuccess()
    {
        Status = "Success!";
        Observer?.Invoke();
    }
}
