using System;
using static ConsoleUtilitiesLite.ConsoleUtilities;

namespace ConsoleUtilitiesLiteTests
{
    internal class Program
    {
        private static string[] title = new string[]
        {
            "────────────────────────────────────────────────────────────────────────",
            "─██████████████─██████████─██████████████─██████─────────██████████████─",
            "─██░░░░░░░░░░██─██░░░░░░██─██░░░░░░░░░░██─██░░██─────────██░░░░░░░░░░██─",
            "─██████░░██████─████░░████─██████░░██████─██░░██─────────██░░██████████─",
            "─────██░░██───────██░░██───────██░░██─────██░░██─────────██░░██─────────",
            "─────██░░██───────██░░██───────██░░██─────██░░██─────────██░░██████████─",
            "─────██░░██───────██░░██───────██░░██─────██░░██─────────██░░░░░░░░░░██─",
            "─────██░░██───────██░░██───────██░░██─────██░░██─────────██░░██████████─",
            "─────██░░██───────██░░██───────██░░██─────██░░██─────────██░░██─────────",
            "─────██░░██─────████░░████─────██░░██─────██░░██████████─██░░██████████─",
            "─────██░░██─────██░░░░░░██─────██░░██─────██░░░░░░░░░░██─██░░░░░░░░░░██─",
            "─────██████─────██████████─────██████─────██████████████─██████████████─",
            "────────────────────────────────────────────────────────────────────────"
        };

        private static void Main(string[] args)
        {
            TitleTest();
            DeleteTest();
            ReallyLargeLogDelete();
            DeleteTestAccountsForNewLines();
        }

        private static void DeleteTestAccountsForNewLines()
        {
            int[] length = LogInfoMessage("I'm a string that occupies\nmore than one line!\n Hello! I'm Monica");
            ClearPreviousLog(length);
            LogInfoMessage("There is no Hello! I'm Monica here.");
        }

        private static void ReallyLargeLogDelete()
        {
            int[] length = LogInfoMessage(new string('-', Console.BufferWidth * 150));
            ClearPreviousLog(length);
            LogInfoMessage("There are no \"-\" on the screen.");
        }

        private static void DeleteTest()
        {
            int[] length = LogInfoMessage("This will be deleted!");
            ClearPreviousLog(length);
            LogInfoMessage("This will not be deleted!");
        }

        private static void TitleTest()
        {
            ShowTitle(title);
        }
    }
}