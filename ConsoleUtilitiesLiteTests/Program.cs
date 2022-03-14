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

        private static async Task Main(string[] args)
        {
            TitleTest();
            DeleteTest();
            ReallyLargeLogDelete();
            DeleteTestAccountsForNewLines();
            await TestProgressBar();
            await CommandObserverTest();
            TestUserInput();
        }

        private static void TestUserInput()
        {
            LogInfoMessage("This will ask for a number, and should stop when a valid number is ingresed.");
            LogInfoMessage("The success message should contain the number ingresed.");
            var number = GetUserInput(
                "Insert a number",
                "Please write a valid number",
                "The number: {0} is valid!",
                int.Parse,
                (s) => int.TryParse(s, out _)
            );
        }

        private static async Task CommandObserverTest()
        {
            CommandObserver observer = new();
            observer.Add(new ConsoleCommand(ConsoleKey.Q, observer.StopObserving, "blabla"));

            Console.WriteLine("Command observer started.");
            Console.WriteLine("Press Q NOW!");
            var t = observer.StartObserving();
            await t;
            Console.WriteLine("Command Observer stopped.");
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
                await Task.Delay(150);
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