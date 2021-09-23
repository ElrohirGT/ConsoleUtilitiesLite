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
        }

        private static void ReallyLargeLogDelete()
        {
            int length = LogInfoMessage(new string('-', Console.BufferWidth * 150));
            ClearPreviousLog(length);
            LogInfoMessage("Only this should be on screen.");
        }

        private static void DeleteTest()
        {
            int length = LogInfoMessage("This will be deleted!");
            ClearPreviousLog(length);
            LogInfoMessage("This will not be deleted!");
        }

        private static void TitleTest()
        {
            ShowTitle(title);
        }
    }
}