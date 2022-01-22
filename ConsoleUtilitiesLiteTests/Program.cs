using System;
using System.Threading.Tasks;

using ConsoleUtilitiesLite;

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
            TestProgressBar().Wait();
        }

        private static async Task TestProgressBar()
        {
            var bar = new ConsoleProgressBar(new ProgressBarConfiguration { BarLength = 20 });
            Random random = new();
            var reader = bar.OutputChannel;
            for (int i = 0; i < 101; i++)
            {
                float percentage = MathF.Min(i / 100f + (float)random.NextDouble()/100f, 1);
                bar.UpdatePercentage(percentage);
            }

            int[] length = Array.Empty<int>();
            await foreach (var item in reader.ReadAllAsync())
            {
                ClearPreviousLog(length);
                length = LogWarningMessage(item);
                await Task.Delay(250);
            }
            bar.UpdatePercentage(1);
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