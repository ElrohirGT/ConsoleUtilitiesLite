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

    public static string CreateProgressBar(float percentageBetween0and1, ProgressBarConfiguration? configuration = null)
    {
        var conf = configuration ?? new ProgressBarConfiguration();
        if (percentageBetween0and1 < 0 || percentageBetween0and1 > 1)
            throw new ArgumentOutOfRangeException(nameof(percentageBetween0and1));
        return ConstructProgressBar(percentageBetween0and1, conf);
    }

    public string UpdatePercentage(float percentageBetween0and1)
    {
        if (percentageBetween0and1 < 0 || percentageBetween0and1 > 1)
            throw new ArgumentOutOfRangeException(nameof(percentageBetween0and1));

        string progressBar = ConstructProgressBar(percentageBetween0and1, Configuration);
        _channel.Writer.TryWrite(progressBar);
        if (Configuration.AutoTerminate && 1 - percentageBetween0and1 < float.Epsilon)
            _channel.Writer.TryComplete();
        return progressBar;
    }
    public bool TryComplete() => _channel.Writer.TryComplete();

    private static string ConstructProgressBar(float percentage, ProgressBarConfiguration configuration)
    {
        byte progress = (byte)Math.Round(configuration.BarLength * percentage, 0);
        StringBuilder progressBar = new();

        progressBar.Append(configuration.StartChar);
        progressBar.Append(new string(configuration.BarFiller, progress));
        progressBar.Append(configuration.ProgressIndicator);
        progressBar.Append(new string(configuration.EmptySpaceFiller, configuration.BarLength - progress));
        progressBar.Append(configuration.EndChar);
        if (configuration.ShowPercentage)
            progressBar.Append($" {percentage:P2}");

        return progressBar.ToString();
    }
}
