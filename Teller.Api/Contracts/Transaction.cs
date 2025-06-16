using System.Text.Json.Serialization;

namespace Teller.Api.Contracts
{
    public record Transaction
    {
        public required string Id { get; init; }

        [JsonPropertyName("account_id")]
        public required string AccountId { get; init; }

        public required string Date { get; init; }

        public required string Amount { get; init; }

        public required string Status { get; init; }

        public required string Type { get; init; }

        public required string Description { get; init; }

        public required TransactionDetails Details { get; init; }

        public required Links Links { get; init; }
    }
}