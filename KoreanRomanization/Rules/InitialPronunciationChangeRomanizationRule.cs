namespace KoreanRomanization;

/// <summary>
/// Represents a rule for how to Romanize an initial when it is preceded by a given final.
/// </summary>
public sealed class InitialPronunciationChangeRomanizationRule : RomanizationRule
{
    public KoreanLetter PrecedingFinal { get; private set; }
    public KoreanLetter Initial { get; private set; }

    public InitialPronunciationChangeRomanizationRule(KoreanLetter PrecedingFinal1, KoreanLetter Initial1, string Romanization1)
        : base(Romanization1)
    {
        PrecedingFinal = PrecedingFinal1;
        Initial = Initial1;
    }
}
