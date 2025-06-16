namespace Teller.Connect.Contracts
{
    public record EnrollmentCallbackData
    {
        public required string AccessToken { get; init; }

        public required User User { get; init; }

        public required Enrollment Enrollment { get; init; }

        public required List<string> Signatures { get; init; }
    }
}
