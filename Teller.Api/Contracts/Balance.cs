using System.Text.Json.Serialization;

namespace Teller.Api.Contracts
{
    public record Balance
    {
        [JsonPropertyName("account_id")]
        public required string AccountId { get; init; }

        public required string Available { get; init; }

        public required string Ledger { get; init; }

        public required Links Links { get; init; }
    }
}
