using System.Globalization;

namespace KoreanRomanisation;

/// <summary>
/// Represents a single letter of Korean - a jamo.
/// </summary>
public readonly struct KoreanLetter : IEquatable<KoreanLetter>, IEquatable<char>, IEquatable<int>, IComparable<KoreanLetter>, IComparable<char>, IComparable<int>, IFormattable
{
    #region Character Code Constants

    private const int FirstKoreanLetterCharacterCode = 4352;
    private const int LastKoreanLetterCharacterCode = 4607;

    private const int FirstCommonInitialCharacterCode = 4352;
    private const int LastCommonInitialCharacterCode = 4370;

    private const int FirstCommonMedialCharacterCode = 4449;
    private const int LastCommonMedialCharacterCode = 4469;

    private const int FirstCommonFinalCharacterCode = 4520;
    private const int LastCommonFinalCharacterCode = 4546;

    #endregion

    #region Instantiation Shortcuts

    public static readonly KoreanLetter None = new KoreanLetter(-1);

    public static readonly KoreanLetter Giyeok = new KoreanLetter('ᄀ');
    public static readonly KoreanLetter SsangGiyeok = new KoreanLetter('ᄁ');
    public static readonly KoreanLetter Nieun = new KoreanLetter('ᄂ');
    public static readonly KoreanLetter Digeut = new KoreanLetter('ᄃ');
    public static readonly KoreanLetter SsangDigeut = new KoreanLetter('ᄄ');
    public static readonly KoreanLetter Rieul = new KoreanLetter('ᄅ');
    public static readonly KoreanLetter Mieum = new KoreanLetter('ᄆ');
    public static readonly KoreanLetter Bieup = new KoreanLetter('ᄇ');
    public static readonly KoreanLetter SsangBieup = new KoreanLetter('ᄈ');
    public static readonly KoreanLetter Shiot = new KoreanLetter('ᄉ');
    public static readonly KoreanLetter SsangShiot = new KoreanLetter('ᄊ');
    public static readonly KoreanLetter Ieung = new KoreanLetter('ᄋ');
    public static readonly KoreanLetter Jieut = new KoreanLetter('ᄌ');
    public static readonly KoreanLetter SsangJieut = new KoreanLetter('ᄍ');
    public static readonly KoreanLetter Chieut = new KoreanLetter('ᄎ');
    public static readonly KoreanLetter Kieuk = new KoreanLetter('ᄏ');
    public static readonly KoreanLetter Tieut = new KoreanLetter('ᄐ');
    public static readonly KoreanLetter Pieup = new KoreanLetter('ᄑ');
    public static readonly KoreanLetter Hieut = new KoreanLetter('ᄒ');

    public static readonly KoreanLetter A = new KoreanLetter('ᅡ');
    public static readonly KoreanLetter Ae = new KoreanLetter('ᅢ');
    public static readonly KoreanLetter Ya = new KoreanLetter('ᅣ');
    public static readonly KoreanLetter Yae = new KoreanLetter('ᅤ');
    public static readonly KoreanLetter Eo = new KoreanLetter('ᅥ');
    public static readonly KoreanLetter E = new KoreanLetter('ᅦ');
    public static readonly KoreanLetter Yeo = new KoreanLetter('ᅧ');
    public static readonly KoreanLetter Ye = new KoreanLetter('ᅨ');
    public static readonly KoreanLetter O = new KoreanLetter('ᅩ');
    public static readonly KoreanLetter Wa = new KoreanLetter('ᅪ');
    public static readonly KoreanLetter Wae = new KoreanLetter('ᅫ');
    public static readonly KoreanLetter Oe = new KoreanLetter('ᅬ');
    public static readonly KoreanLetter Yo = new KoreanLetter('ᅭ');
    public static readonly KoreanLetter U = new KoreanLetter('ᅮ');
    public static readonly KoreanLetter Wo = new KoreanLetter('ᅯ');
    public static readonly KoreanLetter We = new KoreanLetter('ᅰ');
    public static readonly KoreanLetter Wi = new KoreanLetter('ᅱ');
    public static readonly KoreanLetter Yu = new KoreanLetter('ᅲ');
    public static readonly KoreanLetter Eu = new KoreanLetter('ᅳ');
    public static readonly KoreanLetter Ui = new KoreanLetter('ᅴ');
    public static readonly KoreanLetter I = new KoreanLetter('ᅵ');

    public static readonly KoreanLetter GiyeokBatchim = new KoreanLetter('ᆨ');
    public static readonly KoreanLetter SsangGiyeokBatchim = new KoreanLetter('ᆩ');
    public static readonly KoreanLetter GiyeokShiotBatchim = new KoreanLetter('ᆪ');
    public static readonly KoreanLetter NieunBatchim = new KoreanLetter('ᆫ');
    public static readonly KoreanLetter NieunJieutBatchim = new KoreanLetter('ᆬ');
    public static readonly KoreanLetter NieunHieutBatchim = new KoreanLetter('ᆭ');
    public static readonly KoreanLetter DigeutBatchim = new KoreanLetter('ᆮ');
    public static readonly KoreanLetter RieulBatchim = new KoreanLetter('ᆯ');
    public static readonly KoreanLetter RieulGiyeokBatchim = new KoreanLetter('ᆰ');
    public static readonly KoreanLetter RieulMieumBatchim = new KoreanLetter('ᆱ');
    public static readonly KoreanLetter RieulBieupBatchim = new KoreanLetter('ᆲ');
    public static readonly KoreanLetter RieulShiotBatchim = new KoreanLetter('ᆳ');
    public static readonly KoreanLetter RieulTieutBatchim = new KoreanLetter('ᆴ');
    public static readonly KoreanLetter RieulPieupBatchim = new KoreanLetter('ᆵ');
    public static readonly KoreanLetter RieulHieutBatchim = new KoreanLetter('ᆶ');
    public static readonly KoreanLetter MieumBatchim = new KoreanLetter('ᆷ');
    public static readonly KoreanLetter BieupBatchim = new KoreanLetter('ᆸ');
    public static readonly KoreanLetter BieupShiotBatchim = new KoreanLetter('ᆹ');
    public static readonly KoreanLetter ShiotBatchim = new KoreanLetter('ᆺ');
    public static readonly KoreanLetter SsangShiotBatchim = new KoreanLetter('ᆻ');
    public static readonly KoreanLetter IeungBatchim = new KoreanLetter('ᆼ');
    public static readonly KoreanLetter JieutBatchim = new KoreanLetter('ᆽ');
    public static readonly KoreanLetter ChieutBatchim = new KoreanLetter('ᆾ');
    public static readonly KoreanLetter KieukBatchim = new KoreanLetter('ᆿ');
    public static readonly KoreanLetter TieutBatchim = new KoreanLetter('ᇀ');
    public static readonly KoreanLetter PieupBatchim = new KoreanLetter('ᇁ');
    public static readonly KoreanLetter HieutBatchim = new KoreanLetter('ᇂ');

    #endregion

    #region Core Properties

    private readonly int _CharacterCode;

    public int CharacterCode => _CharacterCode;

    #endregion

    #region Operator Overloads

    public static bool operator ==(KoreanLetter KoreanLetter1, KoreanLetter KoreanLetter2)
    {
        return KoreanLetter1.CharacterCode == KoreanLetter2.CharacterCode;
    }

    public static bool operator !=(KoreanLetter KoreanLetter1, KoreanLetter KoreanLetter2)
    {
        return KoreanLetter1.CharacterCode != KoreanLetter2.CharacterCode;
    }

    #endregion

    #region Constructors

    public KoreanLetter(int CharacterCode1)
    {
        if (!IsAKoreanLetter(CharacterCode1) && CharacterCode1 != -1)
        {
            var Message = $"Korean letters have character codes between {FirstKoreanLetterCharacterCode} and {LastKoreanLetterCharacterCode}.";

            throw new ArgumentOutOfRangeException(nameof(CharacterCode1), Message);
        }

        _CharacterCode = CharacterCode1;
    }

    public static KoreanLetter GetKoreanLetterFromInitialCharacterCode(int InitialCharacterCode1)
    {
        if (!IsACommonInitial(FirstCommonInitialCharacterCode + InitialCharacterCode1))
        {
            var Message = $"Korean initials are numbered between 0 and { LastCommonInitialCharacterCode - FirstCommonInitialCharacterCode }";

            throw new ArgumentOutOfRangeException(nameof(InitialCharacterCode1), Message);
        }

        return new KoreanLetter(FirstCommonInitialCharacterCode + InitialCharacterCode1);
    }

    public static KoreanLetter GetKoreanLetterFromMedialCharacterCode(int MedialCharacterCode1)
    {
        if (!IsACommonMedial(FirstCommonMedialCharacterCode + MedialCharacterCode1))
        {
            var Message = $"Korean medials are numbered between 0 and { LastCommonMedialCharacterCode - FirstCommonMedialCharacterCode }";

            throw new ArgumentOutOfRangeException(nameof(MedialCharacterCode1), Message);
        }

        return new KoreanLetter(FirstCommonMedialCharacterCode + MedialCharacterCode1);
    }

    public static KoreanLetter GetKoreanLetterFromFinalCharacterCode(int FinalCharacterCode1)
    {
        if (FinalCharacterCode1 == 0)
        {
            return new KoreanLetter(-1);
        }

        if (!IsACommonFinal(FirstCommonFinalCharacterCode + FinalCharacterCode1 - 1))
        {
            var Message = $"Korean finals are numbered between 1 and { LastCommonFinalCharacterCode - FirstCommonFinalCharacterCode + 1 }";

            throw new ArgumentOutOfRangeException(nameof(FinalCharacterCode1), Message);
        }

        return new KoreanLetter(FirstCommonFinalCharacterCode + FinalCharacterCode1 - 1);
    }

    public static bool IsAKoreanLetter(int CharacterCode1)
    {
        return (CharacterCode1 >= FirstKoreanLetterCharacterCode && CharacterCode1 <= LastKoreanLetterCharacterCode);
    }

    public static bool IsACommonInitial(int CharacterCode1)
    {
        return (CharacterCode1 >= FirstCommonInitialCharacterCode && CharacterCode1 <= LastCommonInitialCharacterCode);
    }

    public static bool IsACommonMedial(int CharacterCode1)
    {
        return (CharacterCode1 >= FirstCommonMedialCharacterCode && CharacterCode1 <= LastCommonMedialCharacterCode);
    }

    public static bool IsACommonFinal(int CharacterCode1)
    {
        return (CharacterCode1 >= FirstCommonFinalCharacterCode && CharacterCode1 <= LastCommonFinalCharacterCode);
    }

    #endregion

    #region Comparisons

    public bool Equals(KoreanLetter KoreanLetter1)
    {
        if (KoreanLetter1 == default)
        {
            return false;
        }

        return CharacterCode == KoreanLetter1.CharacterCode;
    }

    public bool Equals(char c)
    {
        return CharacterCode == c;
    }

    public bool Equals(int i)
    {
        return CharacterCode == i;
    }

    public int CompareTo(KoreanLetter KoreanLetter1)
    {
        return CharacterCode.CompareTo(KoreanLetter1.CharacterCode);
    }

    public int CompareTo(char c)
    {
        return CharacterCode.CompareTo(c);
    }

    public int CompareTo(int i)
    {
        return CharacterCode.CompareTo(i);
    }

    #endregion

    #region String Formatting

    public override string ToString()
    {
        return ToString("H");
    }

    public string ToString(string Format)
    {
        return ToString(Format, CultureInfo.CurrentCulture);
    }

    public string ToString(string Format, IFormatProvider FormatProvider)
    {
        Format = Format.Replace("H", ((char)_CharacterCode).ToString());

        return Format;
    }

    #endregion
}
