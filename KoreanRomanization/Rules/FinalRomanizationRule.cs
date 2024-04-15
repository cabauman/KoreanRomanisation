namespace KoreanRomanization;

/// <summary>
/// Represents a rule for how to Romanize a final.
/// </summary>
public sealed class FinalRomanizationRule : RomanizationRule
{
    public KoreanLetter Final { get; private set; }

    public FinalRomanizationRule(KoreanLetter Final1, string Romanization1)
        : base(Romanization1)
    {
        Final = Final1;
    }
}
