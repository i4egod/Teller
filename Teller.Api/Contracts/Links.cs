namespace Teller.Api.Contracts
{
    public record Links
    {
        public string Account { get; init; } = string.Empty;
        public string Payments { get; init; } = string.Empty;
        public string Balances { get; init; } = string.Empty;
        public string Transactions { get; init; } = string.Empty;
        public required string Self { get; init; } = string.Empty;
    }
}
