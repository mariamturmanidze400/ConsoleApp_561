using System.Text.RegularExpressions;

namespace ConsoleApp_561.Validators;

internal static class StudentValidator
{
    private static readonly Regex EmailRegex = new(
        @"^[A-Za-z0-9._%+\-]+@[A-Za-z0-9\-]+(\.[A-Za-z0-9\-]+)*\.[A-Za-z]{2,}$",
        RegexOptions.Compiled);

    public static bool IsValidEmail(string? email) =>
        !string.IsNullOrWhiteSpace(email) && EmailRegex.IsMatch(email);

    public static bool IsValidBirthDate(DateOnly birthDate) =>
        birthDate <= DateOnly.FromDateTime(DateTime.Today);
}
