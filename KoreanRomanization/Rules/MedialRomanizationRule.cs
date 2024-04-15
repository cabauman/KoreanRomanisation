namespace KoreanRomanization;

/// <summary>
/// Represents a rule for how to Romanize a medial.
/// </summary>
public sealed class MedialRomanizationRule : RomanizationRule
{
    public KoreanLetter Medial { get; private set; }

    public MedialRomanizationRule(KoreanLetter Medial1, string Romanization1)
        : base(Romanization1)
    {
        Medial = Medial1;
    }
}
