namespace KoreanRomanization;

/// <summary>
/// Represents a rule for how to Romanize an initial.
/// </summary>
public sealed class InitialRomanizationRule : RomanizationRule
{
    public KoreanLetter Initial { get; private set; }

    public InitialRomanizationRule(KoreanLetter Initial1, string Romanization1)
        : base(Romanization1)
    {
        Initial = Initial1;
    }
}
