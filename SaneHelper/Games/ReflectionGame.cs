using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SaneHelper.Games
{
    public static class ReflectionGame
    {
        private static Random random = new Random();
        private static bool gameShouldBeRunning = true;
        public static void Start()
        {
            while (gameShouldBeRunning)
            {
                Console.WriteLine($"Computer wants you to type letter: {GenerateRandomLetter()}");
                HandlePlayerInput(Console.ReadLine());
            }
        }

        private static char GenerateRandomLetter()
        {
            string availableCharacters = "abcdefghijklmnoprstuvwxyzABCDEFGHIJKLMNOPRSTUVWXYZ";
            return availableCharacters[random.Next(0, availableCharacters.Length)];
        }

        private static void CheckIfPlayerHasQuit(string input)
        {
            if (input == "q" || input == "quit")
            {
                gameShouldBeRunning = false;
            }
        }

        private static void HandlePlayerInput(string input)
        {
            CheckIfPlayerHasQuit(input);
        }

    }
}
