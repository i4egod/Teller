using Teller.Connect.Contracts;

namespace BlazorApp.Services
{
    public interface IEnrollmentProvider
    {
        EnrollmentCallbackData? Enrollment { get; set; }
    }
}
