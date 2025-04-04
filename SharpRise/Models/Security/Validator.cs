using System;
using System.Text.RegularExpressions;

namespace SharpRise.Models.Security
{
    public class Validator
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
        public static string? ValidatePassword(string password)
        {
            if (string.IsNullOrWhiteSpace(password))
                return "Пароль не может быть пустым.";

            if (password.Length < 8)
                return "Пароль должен быть длиной не менее 8 символов.";

            if (!Regex.IsMatch(password, @"[a-z]"))
                return "Пароль должен содержать хотя бы одну строчную букву.";

            if (!Regex.IsMatch(password, @"[A-Z]"))
                return "Пароль должен содержать хотя бы одну заглавную букву.";

            if (!Regex.IsMatch(password, @"\d"))
                return "Пароль должен содержать хотя бы одну цифру.";

            // Если все проверки пройдены
            return null;
        }

        internal static bool ValidateInviteCode(string code)
        {
            if (string.IsNullOrEmpty(code))
                return false;
            if (code.Length != 9)
                return false;
            if (code[4] != '-')
                return false;

            string lettersPart = code.Substring(0, 4);
            string numbersPart = code.Substring(5, 4);

            foreach (char c in lettersPart)
            {
                if (c < 'A' || c > 'Z')
                    return false;
            }

            foreach (char c in numbersPart)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }
    }
}