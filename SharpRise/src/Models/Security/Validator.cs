using Microsoft.IdentityModel.Tokens;
using System;
using System.Diagnostics;
using System.Text;
using System.Text.RegularExpressions;

namespace SharpRise.src.Models.Security
{
    public class Validator
    {
        #region Email
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

        #endregion

        #region Password
        // Регулярное выражение для проверки password
        private static readonly Regex PasswordRegex = new Regex(
            @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,}$",
            RegexOptions.Compiled
        );

        /// <summary>
        /// Проверяет пароль на соответствие требованиям и возвращает сообщение об ошибке.
        /// </summary>
        /// <returns>Сообщение об ошибке или null, если пароль валиден.</returns>
        public static string? ValidatePassword(string password)
        {
            if (string.IsNullOrWhiteSpace(password))
                return "Пароль не может быть пустым.";

            if (password.Length < 8)
                return "Пароль должен быть длиной не менее 8 символов.";

            if (!PasswordRegex.IsMatch(password))
            {
                StringBuilder error = new StringBuilder("Пароль должен содержать:");

                if (!password.Any(char.IsLower))
                    error.Append("\n- хотя бы одну строчную букву");

                if (!password.Any(char.IsUpper))
                    error.Append("\n- хотя бы одну заглавную букву");

                if (!password.Any(char.IsDigit))
                    error.Append("\n- хотя бы одну цифру");

                return error.ToString();
            }

            return null;
        }
        #endregion

        #region InviteCode
        internal static bool ValidateInviteCode(string code)
        {
            // убрать пробелы
            code = code.Trim();

            // 5-й символ — это '-'
            if (code[4] != '-')
                return false;

            // первые 4 символа (A-Z, регистронезависимые)
            string lettersPart = code.Substring(0, 4);
            if (!lettersPart.All(c => char.IsLetter(c) && c >= 'A' && c <= 'Z'))
                return false;

            // последние 4 символа (0-9)
            string numbersPart = code.Substring(5, 4);
            if (!numbersPart.All(char.IsDigit))
                return false;

            return true;
        }
        #endregion

    }
}