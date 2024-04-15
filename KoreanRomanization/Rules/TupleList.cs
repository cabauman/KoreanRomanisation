namespace KoreanRomanization;

/// <summary>
/// Represents a list of two-item tuples. Makes it easier to hard-code Romanization rules.
/// </summary>
/// <typeparam name="T1"></typeparam>
/// <typeparam name="T2"></typeparam>
public class TupleList<T1, T2> : List<Tuple<T1, T2>>
{
    public void Add(T1 Item1, T2 Item2)
    {
        Add(new Tuple<T1, T2>(Item1, Item2));
    }
}

/// <summary>
/// Represents a list of three-item tuples. Makes it easier to hard-coded Romanization rules.
/// </summary>
/// <typeparam name="T1"></typeparam>
/// <typeparam name="T2"></typeparam>
/// <typeparam name="T3"></typeparam>
public class TupleList<T1, T2, T3> : List<Tuple<T1, T2, T3>>
{
    public void Add(T1 Item1, T2 Item2, T3 Item3)
    {
        Add(new Tuple<T1, T2, T3>(Item1, Item2, Item3));
    }
}

public class RomanizationRuleList : TupleList<KoreanLetter, string>
{
    public IEnumerable<InitialRomanizationRule> ToInitialRomanizationRules()
    {
        return this.Select(r => new InitialRomanizationRule(r.Item1, r.Item2));
    }

    public IEnumerable<MedialRomanizationRule> ToMedialRomanizationRules()
    {
        return this.Select(r => new MedialRomanizationRule(r.Item1, r.Item2));
    }

    public IEnumerable<FinalRomanizationRule> ToFinalRomanizationRules()
    {
        return this.Select(r => new FinalRomanizationRule(r.Item1, r.Item2));
    }
}

public class PronunciationChangeRomanizationRuleList : TupleList<KoreanLetter, KoreanLetter, string>
{
    public IEnumerable<InitialPronunciationChangeRomanizationRule> ToInitialPronunciationChangeRomanizationRules()
    {
        return this.Select(r => new InitialPronunciationChangeRomanizationRule(r.Item1, r.Item2, r.Item3));
    }

    public IEnumerable<FinalPronunciationChangeRomanizationRule> ToFinalPronunciationChangeRomanizationRules()
    {
        return this.Select(r => new FinalPronunciationChangeRomanizationRule(r.Item1, r.Item2, r.Item3));
    }
}
