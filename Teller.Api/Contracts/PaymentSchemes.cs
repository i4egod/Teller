namespace Teller.Api.Contracts
{
    public record PaymentSchemes
    {
        public required List<Dictionary<string, string>> Schemes { get; init; }
    }
}
