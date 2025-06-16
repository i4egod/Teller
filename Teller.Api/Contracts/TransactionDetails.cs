using System.Text.Json.Serialization;

namespace Teller.Api.Contracts
{
    public record TransactionDetails
    {

        [JsonPropertyName("processing_status")]
        public required string ProcessingStatus { get; init; }

        public required string Category { get; init; }

    }
}
