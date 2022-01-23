using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleUtilitiesLite
{
    /// <summary>
    /// A class that listens for user input and activates commands based on that input.
    /// </summary>
    public class CommandObserver : KeyedCollection<ConsoleKey, ConsoleCommand>, IDisposable
    {
        private readonly CancellationTokenSource _cts = new();
        private CancellationTokenSource? _combinedTokenSource;
        private bool _isDisposed;

        /// <summary>
        /// Get's a readonly collection of the commands in this observer.
        /// </summary>
        public ICollection<ConsoleCommand>? Commands => Dictionary?.Values;

        protected override ConsoleKey GetKeyForItem(ConsoleCommand item) => item.ActivatorKey;
        /// <summary>
        /// Starts listening for user input.
        /// </summary>
        /// <returns>A task that completes once this class stops listening to user input.</returns>
        public Task StartObserving() => Task.Run(ReadAndProcessInput, _cts.Token);
        /// <summary>
        /// Starts listening for user input.
        /// You can supply a cancelation token to stop listening when that cancellation token is cancelled.
        /// </summary>
        /// <param name="token">A token to cancel the operation.</param>
        /// <returns>A task that completes once this class stops listening to user input.</returns>
        public Task StartObserving(CancellationToken token)
        {
            _combinedTokenSource = CancellationTokenSource.CreateLinkedTokenSource(_cts.Token, token);
            return Task.Run(ReadAndProcessInput, _combinedTokenSource.Token);
        }

        private void ReadAndProcessInput()
        {
            while (true)
            {
                ConsoleKeyInfo readKey = Console.ReadKey(true);
                if (!Dictionary.TryGetValue(readKey.Key, out ConsoleCommand command))
                    continue;
                command.Execute();
            }
        }
        /// <summary>
        /// Stops listening for user input, this can be used even if you supplied a cancellation token.
        /// </summary>
        public void StopObserving()
        {
            _cts.Cancel();
            _combinedTokenSource?.Cancel();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_isDisposed)
            {
                if (disposing)
                {
                    _cts.Dispose();
                    _combinedTokenSource?.Dispose();
                }
                _isDisposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }

    public record ConsoleCommand(ConsoleKey ActivatorKey, Action Execute, string Description);
}
