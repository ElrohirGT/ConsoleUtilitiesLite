namespace ConsoleUtilitiesLite;
public class ProgressBarConfiguration
{
    public char StartChar { get; init; } = '|';
    public char BarFiller { get; init; } = '=';
    public char EmptySpaceFiller { get; init; } = '-';
    public char ProgressIndicator { get; init; } = '>';
    public char EndChar { get; init; } = '|';
    public bool ShowPercentage { get; init; } = true;
    public byte BarLength { get; init; } = 10;
    public bool AutoTerminate { get; init; } = true;
}
