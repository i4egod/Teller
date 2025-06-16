using System.Text.Json.Serialization;
using Teller.Client.Contracts;

namespace Teller.Api.Contracts
{
    public record Account
    {
        public required string Id { get; init; }
        
        public required string Name { get; init; }

        public required string Status { get; init; }

        public required string Type { get; init; }

        public required string Currency { get; init; }

        [JsonPropertyName("enrollment_id")]
        public required string EnrollmentId { get; init; }

        public required Institution Institution { get; init; }

        public required Links Links { get; init; }

        public required string Subtype { get; init; }

        [JsonPropertyName("last_four")]
        public required string LastFour { get; init; }

    }
}
