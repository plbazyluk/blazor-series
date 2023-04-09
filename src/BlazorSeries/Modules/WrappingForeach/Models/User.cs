namespace BlazorSeries.Modules.WrappingForeach.Models;

public record User(Guid Id, string FirstName, string LastName, DateTime RegistrationUtc)
{
    public readonly static List<User> Source = new()
    {
        new(Guid.NewGuid(), "Tony", "Stark", DateTime.UtcNow),
        new(Guid.NewGuid(), "Steve", "Rogers", DateTime.UtcNow.AddDays(-2)),
        new(Guid.NewGuid(), "T'challa", string.Empty, DateTime.UtcNow.AddDays(-7)),
        new(Guid.NewGuid(), "Bruce", "Banner", DateTime.UtcNow.AddDays(-2))
    };
}