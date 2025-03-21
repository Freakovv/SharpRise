using System;
using System.Text.RegularExpressions;

public class RegexValidator
{
    // Регулярное выражение для проверки email
    private static readonly Regex EmailRegex = new Regex(
        @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$",
        RegexOptions.Compiled
    );

    /// Проверяет, является ли строка валидным email.
    /// <returns>True, если email валиден, иначе False.</returns>
    public static bool IsValidEmail(string email)
    {
        if (string.IsNullOrWhiteSpace(email))
            return false;

        return EmailRegex.IsMatch(email);
    }

    /// Проверяет пароль на соответствие требованиям и возвращает сообщение об ошибке.
    /// <returns>Сообщение об ошибке или null, если пароль валиден.</returns>
    public static string ValidatePassword(string password)
    {
        if (string.IsNullOrWhiteSpace(password))
            return "Password cannot be empty.";

        if (password.Length < 8)
            return "Password must be at least 8 characters long.";

        if (!Regex.IsMatch(password, @"[a-z]"))
            return "Password must contain at least one lowercase letter.";

        if (!Regex.IsMatch(password, @"[A-Z]"))
            return "Password must contain at least one uppercase letter.";

        if (!Regex.IsMatch(password, @"\d"))
            return "Password must contain at least one digit.";

        // Если все проверки пройдены
        return null;
    }
}