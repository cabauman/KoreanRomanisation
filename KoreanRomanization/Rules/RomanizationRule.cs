namespace KoreanRomanization;

/// <summary>
/// A base class representing a rule for how to Romanize something.
/// </summary>
public abstract class RomanizationRule
{
    public string Romanization { get; protected set; }

    public RomanizationRule(string Romanization1)
    {
        Romanization = Romanization1;
    }
}
