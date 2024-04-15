namespace KoreanRomanization;

/// <summary>
/// Represents a rule for how to Romanize a final when followed by a given initial.
/// </summary>
public sealed class FinalPronunciationChangeRomanizationRule : RomanizationRule
{
    public KoreanLetter Final { get; private set; }
    public KoreanLetter SucceedingInitial { get; private set; }

    public FinalPronunciationChangeRomanizationRule(KoreanLetter Final1, KoreanLetter SucceedingInitial1, string Romanization1)
        : base(Romanization1)
    {
        Final = Final1;
        SucceedingInitial = SucceedingInitial1;
    }
}
