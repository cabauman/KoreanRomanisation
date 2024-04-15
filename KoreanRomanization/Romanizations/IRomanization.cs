namespace KoreanRomanization;

public interface IRomanization
{
    /// <summary>
    /// Whether or not to remove any text that isn't Korean from the final output.
    /// </summary>
    bool PreserveNonKoreanText { get; set; }

    /// <summary>
    /// Whether or not to Romanize the letter shiot as 'sh', and ssangshiot as 'ssh', when they appear before an 'i' sound.
    /// </summary>
    bool UseSh { get; set; }

    /// <summary>
    /// Whether or not to Romanize o followed by i as 'oi' instead of 'oe'.
    /// </summary>
    bool UseOi { get; set; }

    /// <summary>
    /// Romanize a given text string.
    /// </summary>
    /// <param name="Text"></param>
    /// <returns></returns>
    string RomanizeText(string Text, bool useDashes);

    /// <summary>
    /// Romanize a given text block.
    /// </summary>
    /// <param name="TextBlock1"></param>
    /// <returns></returns>
    string RomanizeTextBlock(TextBlock TextBlock1, bool useDashes);

    /// <summary>
    /// Romanize a given Korean syllable.
    /// </summary>
    /// <param name="Syllable"></param>
    /// <param name="PrecedingSyllable"></param>
    /// <param name="SucceedingSyllable"></param>
    /// <returns></returns>
    string RomanizeSyllable(KoreanSyllable Syllable, KoreanSyllable? PrecedingSyllable = null, KoreanSyllable? SucceedingSyllable = null);

    /// <summary>
    /// Romanize a given Korean letter.
    /// </summary>
    /// <param name="Letter"></param>
    /// <returns></returns>
    string RomanizeLetter(KoreanLetter Letter);
}
