namespace Teller.Client.Contracts
{
    public record Institution
    {
        public required string Id { get; init; }

        public required string Name { get; init; }

        public List<string> Products { get; init; } = [];
    }
}
