using System;

namespace CA___codeaceademy___caesar_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            Console.WriteLine("Please enter your secret message: ");
            string input = Console.ReadLine();
            char[] secretMessage = input.ToCharArray();
            char[] encryptedMessage = new char[secretMessage.Length];

            for (int i = 0; i < secretMessage.Length; i++)
            {
                char letter = secretMessage[i];
                int positionOfLetter = Array.IndexOf(alphabet, letter);
                int newPos = (positionOfLetter + 3) % 26;
                char encryptedCharacter = alphabet[newPos];
                encryptedMessage[i] = encryptedCharacter;
            }
            string encodedCharacters = String.Join("", encryptedMessage);
            Console.WriteLine($"Your encoded message is: {encodedCharacters}");

        }
    }
}
