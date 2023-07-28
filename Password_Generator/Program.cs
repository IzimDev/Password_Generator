using System;
using System.Security.Cryptography;

namespace Password_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            string capitalLetters = "QWERTYUIOPASDFGHJKLZXCVBNM";
            string smallLetters = "qwertyuiopasdfghjklzxcvbnm";
            string digits = "0123456789";
            string specialCharacters = "!@#$%^&*()-_=+<,>.";
            string allChars = capitalLetters + smallLetters + digits + specialCharacters;

            string password = "";

            Console.WriteLine("Enter the password length: ");
            int length = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < length; i++)
            {
                int randomValue = RandomNumberGenerator.GetInt32(0, allChars.Length);
                char character = allChars[randomValue];
                password += character;
            }

            Console.WriteLine(password);
        }
    }
}
