using BlazorSeries.Libraries.Shared.StateManagement;

namespace BlazorSeries.ActionIndicatorsWithMediator.StateManagement;

internal sealed class SuccessfulSaveHandler : IRequestHandler<SuccessfulSave>
{
    private readonly IApplicationState _state;

    public SuccessfulSaveHandler(IApplicationState state)
    {
        _state = state;
    }

    public Task Handle(SuccessfulSave request, CancellationToken cancellationToken)
    {
        _state.DisplaySuccess();
        return Task.CompletedTask;
    }
}
