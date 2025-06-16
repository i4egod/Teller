namespace Teller.Connect.Contracts
{
    public record Enrollment
    {
        public required string Id { get; init; }

        public required Institution Institution { get; init; }
    }
}
