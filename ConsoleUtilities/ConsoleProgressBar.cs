using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ConsoleUtilitiesLite;
public partial class ConsoleProgressBar
{
    public ConsoleProgressBar(ProgressBarConfiguration? configuration = null)
    {
        Configuration = configuration ?? new ProgressBarConfiguration();
        _channel = Channel.CreateUnbounded<string>(new UnboundedChannelOptions { SingleReader = true, SingleWriter = true });
        OutputChannel = _channel.Reader;
    }

    public ProgressBarConfiguration Configuration { get; }

    private readonly Channel<string> _channel;

    public ChannelReader<string> OutputChannel { get; }

    public void UpdatePercentage(float percentageBetween0and1)
    {
        if (percentageBetween0and1 < 0 || percentageBetween0and1 > 1)
            throw new ArgumentOutOfRangeException(nameof(percentageBetween0and1));

        string progressBar = ConstructProgressBar(percentageBetween0and1);
        _channel.Writer.TryWrite(progressBar);
        if (Configuration.AutoTerminate && 1 - percentageBetween0and1 < float.Epsilon)
            _channel.Writer.TryComplete();
    }
    public bool TryComplete() => _channel.Writer.TryComplete();

    private string ConstructProgressBar(float percentage)
    {
        byte progress = (byte)Math.Round(Configuration.BarLength * percentage, 0);
        StringBuilder progressBar = new();

        progressBar.Append(Configuration.StartChar);
        progressBar.Append(new string(Configuration.BarFiller, progress));
        progressBar.Append(Configuration.ProgressIndicator);
        progressBar.Append(new string(Configuration.EmptySpaceFiller, Configuration.BarLength - progress));
        progressBar.Append(Configuration.EndChar);
        if (Configuration.ShowPercentage)
            progressBar.Append($" {percentage:P2}");

        return progressBar.ToString();
    }
}
