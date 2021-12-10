using System;
using System.IO;
using System.Linq;

namespace ConsoleUtilitiesLite
{
    /// <summary>
    /// Some simple console utilities I use on my projects.
    /// </summary>
    public static class ConsoleUtilities
    {
        /// <summary>
        /// Text color used in the <c>ShowTitle</c> method.
        /// </summary>
        /// <seealso cref="ShowTitle(string[])"/>
        public static ConsoleColor TitleColor { get; set; } = ConsoleColor.Green;

        #region Division Properties

        /// <summary>
        /// Char used to make the divisions on the console.
        /// </summary>
        /// <seealso cref="Division()"/>
        /// <seealso cref="Division(int)"/>
        public static char DivisionSign { get; set; } = '=';

        /// <summary>
        /// Char used to make the sub divisions on the console.
        /// </summary>
        /// <seealso cref="SubDivision()"/>
        /// <seealso cref="SubDivision(int)"/>
        public static char SubDivisionSign { get; set; } = '=';

        /// <summary>
        /// Color used to make divisions on the console.
        /// </summary>
        /// <seealso cref="Division()"/>
        /// <seealso cref="Division(int)"/>
        public static ConsoleColor DivisionColor { get; set; } = ConsoleColor.Cyan;

        /// <summary>
        /// Color used to make sub divisions on the console.
        /// </summary>
        /// <seealso cref="SubDivision()"/>
        /// <seealso cref="SubDivision(int)"/>
        public static ConsoleColor SubDivisionColor { get; set; } = ConsoleColor.Yellow;

        #endregion Division Properties

        #region Logs Colors

        /// <summary>
        /// Text color used in the <c>InfoMessage</c> method.
        /// </summary>
        /// <seealso cref="LogInfoMessage(string, object[])"/>
        public static ConsoleColor InfoMessageColor { get; set; } = ConsoleColor.DarkGray;

        /// <summary>
        /// Text color used in the <c>SuccessMessage</c> method.
        /// </summary>
        /// <seealso cref="LogSuccessMessage(string, object[])"/>
        public static ConsoleColor SuccessMessageColor { get; set; } = ConsoleColor.Green;

        /// <summary>
        /// Text color used in the <c>WarningMessage</c> method.
        /// </summary>
        /// <seealso cref="LogWarningMessage(string, object[])"/>
        public static ConsoleColor WarningMessageColor { get; set; } = ConsoleColor.DarkYellow;

        /// <summary>
        /// Text color used in the <c>ErrorMessage</c> method.
        /// </summary>
        /// <seealso cref="LogErrorMessage(string, object[])"/>
        public static ConsoleColor ErrorMessageColor { get; set; } = ConsoleColor.Red;

        #endregion Logs Colors

        #region Simple Methods

        /// <summary>
        /// Shows each line of the given array to the console,
        /// uses the color of <c>TitleColor</c>.
        /// </summary>
        /// <param name="title">The title to be showed.</param>
        /// <seealso cref="TitleColor"/>
        public static void ShowTitle(string[] title)
        {
            Division();
            Console.ForegroundColor = TitleColor;

            foreach (var line in title)
                Console.WriteLine(CenterLine(line));

            Console.ForegroundColor = ConsoleColor.White;
            Division();
        }

        /// <summary>
        /// Logs a Runnning Version message with the color of warning. You can get the version of the assembly by calling:
        /// <c>System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString());</c>
        /// </summary>
        /// <param name="version">The version of the assembly.</param>
        public static void ShowVersion(string version) => LogWarningMessage("Running version: {0}", version);

        /// <summary>
        /// Returns the <paramref name="text"/> given with the right amount of spaces to be centered on the screen.
        /// </summary>
        /// <param name="text">The text to be centered.</param>
        /// <returns>The text with the right amount of spaces.</returns>
        public static string CenterLine(string text)
        {
            int extraSpaces = (int)Math.Ceiling((decimal)(Console.BufferWidth - text.Length) / 2);
            return new string(' ', extraSpaces) + text;
        }

        /// <summary>
        /// Creates a division with a length equal to the <c>Console.BufferWidth</c>,
        /// uses the <c>DivisionSign</c> property to make the division.
        /// </summary>
        /// <seealso cref="DivisionSign"/>
        public static void Division() => Division(Console.BufferWidth);

        /// <summary>
        /// Creates a Cyan division with the specified <paramref name="length"/>,
        /// uses the <c>DivisionSign</c> property to make the division.
        /// </summary>
        /// <param name="length">The length of the division to create.</param>
        /// <seealso cref="DivisionSign"/>
        public static void Division(int length) => LogFormat(new string(DivisionSign, length), DivisionColor);

        /// <summary>
        /// Creates a sub-division with a length equal to the <c>Console.BufferWidth</c>
        /// Uses the <c>SubDivisionSign</c> property to make the division.
        /// </summary>
        /// <seealso cref="DivisionSign"/>
        public static void SubDivision() => SubDivision(Console.BufferWidth);

        /// <summary>
        /// Creates a sub-division with the specified <paramref name="length"/>,
        /// uses the <c>SubDivisionSign</c> property to make the division.
        /// </summary>
        /// <param name="length">The length of the division to create.</param>
        /// <seealso cref="DivisionSign"/>
        public static void SubDivision(int length) => LogFormat(new string(DivisionSign, length), SubDivisionColor);

        #endregion Simple Methods

        #region Messages Methods

        /// <summary>
        /// Shows the specified <paramref name="message"/>,
        /// With the color of <c>InfoMessageColor</c>,
        /// <paramref name="args"/> is passed as is to the <c>Console.WriteLine</c> method.
        /// </summary>
        /// <param name="message">The message to write to the console.</param>
        /// <param name="args">An array of objects to write using.</param>
        /// <returns>The length of the string that was logged, useful for using <c>ClearPreviousLog</c>.</returns>
        public static int LogInfoMessage(string message, params object[] args) => LogFormat(message, InfoMessageColor, args);

        /// <summary>
        /// Shows the specified <paramref name="message"/>,
        /// With the color of <c>SuccessMessageColor</c>,
        /// <paramref name="args"/> is passed as is to the <c>Console.WriteLine</c> method.
        /// </summary>
        /// <param name="message">The message to write to the console.</param>
        /// <param name="args">An array of objects to write using.</param>
        /// <returns>The length of the string that was logged, useful for using <c>ClearPreviousLog</c>.</returns>
        public static int LogSuccessMessage(string message, params object[] args) => LogFormat(message, SuccessMessageColor, args);

        /// <summary>
        /// Shows the specified <paramref name="message"/>,
        /// With the color of <c>WarningMessageColor</c>,
        /// <paramref name="args"/> is passed as is to the <c>Console.WriteLine</c> method.
        /// </summary>
        /// <param name="message">The message to write to the console.</param>
        /// <param name="args">An array of objects to write using.</param>
        /// <returns>The length of the string that was logged, useful for using <c>ClearPreviousLog</c>.</returns>
        public static int LogWarningMessage(string message, params object[] args) => LogFormat(message, WarningMessageColor, args);

        /// <summary>
        /// Shows the specified <paramref name="message"/>,
        /// With the color of <c>ErrorMessageColor</c>,
        /// <paramref name="args"/> is passed as is to the <c>Console.WriteLine</c> method.
        /// </summary>
        /// <param name="message">The message to write to the console.</param>
        /// <param name="args">An array of objects to write using.</param>
        /// <returns>The length of the string that was logged, useful for using <c>ClearPreviousLog</c>.</returns>
        public static int LogErrorMessage(string message, params object[] args) => LogFormat(message, ErrorMessageColor, args);

        #endregion Messages Methods

        /// <summary>
        /// Logs the message with the specified arguments.
        /// </summary>
        /// <param name="format"></param>
        /// <param name="foregroundColor"></param>
        /// <param name="args"></param>
        /// <returns>The length of the string that was logged, useful for using <c>ClearPreviousLog</c>.</returns>
        private static int LogFormat(string format, ConsoleColor foregroundColor, params object[] args)
        {
            string loggedMessage = string.Format(format, args);
            ConsoleColor previousConsoleColor = Console.ForegroundColor;

            Console.ForegroundColor = foregroundColor;
            Console.WriteLine(loggedMessage);
            Console.ForegroundColor = previousConsoleColor;

            return CalculateLinesOf(loggedMessage);
        }

        private static int CalculateLinesOf(string loggedMessage)
        {
            string[] logs = loggedMessage.Split('\n', StringSplitOptions.TrimEntries);
            return logs.Sum(log =>
            {
                int v = (int)Math.Ceiling((decimal)log.Length / Console.BufferWidth);
                return log.Length == 0 ? Console.BufferWidth : v*Console.BufferWidth;
            });
        }

        /// <summary>
        /// Logs a message that shows that the <paramref name="imagePath"/> is being copied to <paramref name="newPath"/>,
        /// the color used is from <c>LogImageColor</c>.
        /// </summary>
        /// <param name="imagePath">The path of the image that is being copied.</param>
        /// <param name="newPath">The new path that the image will be copied to.</param>
        /// <returns>The length of the string that was logged, useful for using <c>ClearPreviousLog</c>.</returns>
        public static int LogImage(string imagePath, string newPath) => LogInfoMessage("Copying {0}{1}{2}", newPath, Path.DirectorySeparatorChar.ToString(), Path.GetFileName(imagePath));

        /// <summary>
        /// Deletes the previous log.
        /// Nothing should be outputted to the console between the call of a log and this function for this function to work properly.
        /// </summary>
        /// <param name="length">The size of the previous logged string</param>
        public static void ClearPreviousLog(int length)
        {
            int lines;
            if (length <= 0)
                return;
            if (length % Console.BufferWidth == 0)
                lines = length / Console.BufferWidth;
            else
                lines = (int)Math.Floor((decimal)(length / Console.BufferWidth)) + 1;
            ++lines;

            for (; lines != 0; lines--)
            {
                bool cursorIsNotAtTheTop = Console.CursorTop > 0;
                bool isNotLasLine = lines != 1;
                if (cursorIsNotAtTheTop && isNotLasLine)
                    GoToPreviousLine();

                ClearCurrentLine();
            }
            Console.CursorLeft = 0;
        }

        private static void GoToPreviousLine() => Console.CursorTop -= 1;

        private static void ClearCurrentLine()
        {
            int initialCursorRow = Console.CursorTop;

            Console.CursorLeft = 0;
            Console.Write(new string(' ', Console.BufferWidth));

            Console.CursorTop = initialCursorRow;
        }
    }
}