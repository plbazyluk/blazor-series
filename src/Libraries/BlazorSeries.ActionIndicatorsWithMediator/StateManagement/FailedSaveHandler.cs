using BlazorSeries.Libraries.Shared.StateManagement;

namespace BlazorSeries.ActionIndicatorsWithMediator.StateManagement;

internal sealed class FailedSaveHandler : IRequestHandler<FailedSave>
{
    private readonly IApplicationState _state;

    public FailedSaveHandler(IApplicationState state)
    {
        _state = state;
    }

    public Task Handle(FailedSave request, CancellationToken cancellationToken)
    {
        _state.DisplayFailure();
        return Task.CompletedTask;
    }
}
