using System.Text;

namespace KoreanRomanization;

/// <summary>
/// A base class for classes that can Romanize Korean text according to their own internal Romanization rules.
/// </summary>
public abstract class Romanization : IRomanization
{
    protected StringBuilder _stringBuilder = new();

    #region Properties

    public bool PreserveNonKoreanText { get; set; }
    public bool UseSh { get; set; }
    public bool UseOi { get; set; }

    protected IEnumerable<InitialRomanizationRule> InitialRomanizationRules;
    protected IEnumerable<InitialPronunciationChangeRomanizationRule> InitialPronunciationChangeRomanizationRules;

    protected IEnumerable<MedialRomanizationRule> MedialRomanizationRules;

    protected IEnumerable<FinalRomanizationRule> FinalRomanizationRules;
    protected IEnumerable<FinalPronunciationChangeRomanizationRule> FinalPronunciationChangeRomanizationRules;

    #endregion

    #region Constructors

    public Romanization()
    {
        PreserveNonKoreanText = true;
        UseSh = true;
        UseOi = false;
    }

    /// <summary>
    /// Sets the rules of the Romanization system. In this library, Romanization rules are hard-coded, since they rarely change - this function is where they are set.
    /// </summary>
    protected abstract void SetRules();

    #endregion

    #region Romanization Functions

    /// <summary>
    /// Takes a text string and converts it into a text block of Korean and non-Korean text sections.
    /// </summary>
    /// <param name="Text"></param>
    /// <returns></returns>
    public TextBlock GetTextBlock(string Text)
    {
        var TextBlock1 = new TextBlock();
        var KoreanTextSection1 = new KoreanTextSection();
        var NonKoreanTextSection1 = new NonKoreanTextSection();

        foreach (var Character in Text)
        {
            if (KoreanSyllable.IsAKoreanSyllable(Character))
            {
                var Syllable = new KoreanSyllable(Character);

                if (!string.IsNullOrEmpty(NonKoreanTextSection1.Content))
                {
                    TextBlock1.TextSections.Add(NonKoreanTextSection1);
                    NonKoreanTextSection1 = new NonKoreanTextSection();
                }

                KoreanTextSection1.Syllables.Add(Syllable);
            }
            else
            {
                if (KoreanTextSection1.Syllables.Any())
                {
                    TextBlock1.TextSections.Add(KoreanTextSection1);
                    KoreanTextSection1 = new KoreanTextSection();
                }

                NonKoreanTextSection1.Content += Character;
            }
        }

        if (!string.IsNullOrEmpty(NonKoreanTextSection1.Content))
        {
            TextBlock1.TextSections.Add(NonKoreanTextSection1);
        }

        if (KoreanTextSection1.Syllables.Count > 0)
        {
            TextBlock1.TextSections.Add(KoreanTextSection1);
        }

        return TextBlock1;
    }

    /// <summary>
    /// Returns whether or not the given letter is an 'i' medial, which is useful for Romanizing the letters shiot and ssangshiot.
    /// </summary>
    /// <param name="Letter"></param>
    /// <returns></returns>
    protected bool IsIMedial(KoreanLetter Letter)
    {
        var IMedials = new List<KoreanLetter>() { KoreanLetter.I, KoreanLetter.Ya, KoreanLetter.Yae, KoreanLetter.Yeo, KoreanLetter.Ye, KoreanLetter.Yo, KoreanLetter.Yu };

        return IMedials.Any(m => m == Letter);
    }

    public string RomanizeText(string Text, bool useDashes = false)
    {
        var TextBlock1 = GetTextBlock(Text);

        return RomanizeTextBlock(TextBlock1, useDashes);
    }

    public string RomanizeTextBlock(TextBlock TextBlock1, bool useDashes)
    {
        _stringBuilder.Clear();

        foreach (var TextSection in TextBlock1.TextSections)
        {
            if (TextSection is KoreanTextSection)
            {
                var KoreanTextSection1 = TextSection as KoreanTextSection;
                var Syllables = KoreanTextSection1.Syllables.ToArray();

                if (Syllables.Length > 1)
                {
                    for (var i = 0; i < Syllables.Length; i++)
                    {
                        KoreanSyllable? PrecedingSyllable = null;
                        KoreanSyllable Syllable = Syllables[i];
                        KoreanSyllable? SucceedingSyllable = null;

                        var RomanizedText = "";

                        if (i > 0)
                        {
                            PrecedingSyllable = Syllables[i - 1];
                        }
                        if (i < Syllables.Length - 1)
                        {
                            SucceedingSyllable = Syllables[i + 1];
                        }

                        RomanizedText = RomanizeSyllable(Syllable, PrecedingSyllable, SucceedingSyllable);

                        _stringBuilder.Append(RomanizedText);
                        if (useDashes && i < Syllables.Length - 1)
                        {
                            _stringBuilder.Append('-');
                        }
                    }
                }
                else if (Syllables.Length == 1)
                {
                    var RomanizedText = RomanizeSyllable(Syllables[0]);

                    _stringBuilder.Append(RomanizedText);
                }
            }
            else if (TextSection is NonKoreanTextSection)
            {
                var Content = (TextSection as NonKoreanTextSection).Content;

                _stringBuilder.Append(Content);
            }
        }

        return _stringBuilder.ToString();
    }

    public abstract string RomanizeSyllable(KoreanSyllable Syllable, KoreanSyllable? PrecedingSyllable = null, KoreanSyllable? SucceedingSyllable = null);
    public abstract string RomanizeLetter(KoreanLetter Letter);

    #endregion
}
