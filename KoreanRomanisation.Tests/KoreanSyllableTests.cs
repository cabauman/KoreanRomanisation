using Xunit;

namespace KoreanRomanisation.Tests;

/// <summary>
/// A set of tests for the KoreanSyllable structure.
/// </summary>
public class KoreanSyllableTests
{
    #region Initial Character Codes Tests

    [Fact]
    public void CharacterCodesGaTest()
    {
        var Syllable1 = new KoreanSyllable('가');

        Assert.Equal(KoreanLetter.Giyeok, Syllable1.Initial);
        Assert.Equal(KoreanLetter.A, Syllable1.Medial);
        Assert.Equal(KoreanLetter.None, Syllable1.Final);
    }

    [Fact]
    public void CharacterCodesNaTest()
    {
        var Syllable1 = new KoreanSyllable('나');

        Assert.Equal(KoreanLetter.Nieun, Syllable1.Initial);
        Assert.Equal(KoreanLetter.A, Syllable1.Medial);
        Assert.Equal(KoreanLetter.None, Syllable1.Final);
    }

    [Fact]
    public void CharacterCodesDaTest()
    {
        var Syllable1 = new KoreanSyllable('다');

        Assert.Equal(KoreanLetter.Digeut, Syllable1.Initial);
        Assert.Equal(KoreanLetter.A, Syllable1.Medial);
        Assert.Equal(KoreanLetter.None, Syllable1.Final);
    }

    [Fact]
    public void CharacterCodesMaTest()
    {
        var Syllable1 = new KoreanSyllable('마');

        Assert.Equal(KoreanLetter.Mieum, Syllable1.Initial);
        Assert.Equal(KoreanLetter.A, Syllable1.Medial);
        Assert.Equal(KoreanLetter.None, Syllable1.Final);
    }

    [Fact]
    public void CharacterCodesBaTest()
    {
        var Syllable1 = new KoreanSyllable('바');

        Assert.Equal(KoreanLetter.Bieup, Syllable1.Initial);
        Assert.Equal(KoreanLetter.A, Syllable1.Medial);
        Assert.Equal(KoreanLetter.None, Syllable1.Final);
    }

    [Fact]
    public void CharacterCodesSaTest()
    {
        var Syllable1 = new KoreanSyllable('사');

        Assert.Equal(KoreanLetter.Shiot, Syllable1.Initial);
        Assert.Equal(KoreanLetter.A, Syllable1.Medial);
        Assert.Equal(KoreanLetter.None, Syllable1.Final);
    }

    [Fact]
    public void CharacterCodesATest()
    {
        var Syllable1 = new KoreanSyllable('아');

        Assert.Equal(KoreanLetter.Ieung, Syllable1.Initial);
        Assert.Equal(KoreanLetter.A, Syllable1.Medial);
        Assert.Equal(KoreanLetter.None, Syllable1.Final);
    }

    [Fact]
    public void CharacterCodesJaTest()
    {
        var Syllable1 = new KoreanSyllable('자');

        Assert.Equal(KoreanLetter.Jieut, Syllable1.Initial);
        Assert.Equal(KoreanLetter.A, Syllable1.Medial);
        Assert.Equal(KoreanLetter.None, Syllable1.Final);
    }

    [Fact]
    public void CharacterCodesHaTest()
    {
        var Syllable1 = new KoreanSyllable('하');

        Assert.Equal(KoreanLetter.Hieut, Syllable1.Initial);
        Assert.Equal(KoreanLetter.A, Syllable1.Medial);
        Assert.Equal(KoreanLetter.None, Syllable1.Final);
    }

    #endregion

    #region Medial Character Codes Tests

    [Fact]
    public void CharacterCodesGeoTest()
    {
        var Syllable1 = new KoreanSyllable('거');

        Assert.Equal(KoreanLetter.Giyeok, Syllable1.Initial);
        Assert.Equal(KoreanLetter.Eo, Syllable1.Medial);
        Assert.Equal(KoreanLetter.None, Syllable1.Final);
    }

    [Fact]
    public void CharacterCodesGoTest()
    {
        var Syllable1 = new KoreanSyllable('고');

        Assert.Equal(KoreanLetter.Giyeok, Syllable1.Initial);
        Assert.Equal(KoreanLetter.O, Syllable1.Medial);
        Assert.Equal(KoreanLetter.None, Syllable1.Final);
    }

    [Fact]
    public void CharacterCodesGuTest()
    {
        var Syllable1 = new KoreanSyllable('구');

        Assert.Equal(KoreanLetter.Giyeok, Syllable1.Initial);
        Assert.Equal(KoreanLetter.U, Syllable1.Medial);
        Assert.Equal(KoreanLetter.None, Syllable1.Final);
    }

    [Fact]
    public void CharacterCodesGeuTest()
    {
        var Syllable1 = new KoreanSyllable('그');

        Assert.Equal(KoreanLetter.Giyeok, Syllable1.Initial);
        Assert.Equal(KoreanLetter.Eu, Syllable1.Medial);
        Assert.Equal(KoreanLetter.None, Syllable1.Final);
    }

    [Fact]
    public void CharacterCodesGiTest()
    {
        var Syllable1 = new KoreanSyllable('기');

        Assert.Equal(KoreanLetter.Giyeok, Syllable1.Initial);
        Assert.Equal(KoreanLetter.I, Syllable1.Medial);
        Assert.Equal(KoreanLetter.None, Syllable1.Final);
    }

    #endregion

    #region Final Character Codes Tests

    [Fact]
    public void CharacterCodesGakTest()
    {
        var Syllable1 = new KoreanSyllable('각');

        Assert.Equal(KoreanLetter.Giyeok, Syllable1.Initial);
        Assert.Equal(KoreanLetter.A, Syllable1.Medial);
        Assert.Equal(KoreanLetter.GiyeokBatchim, Syllable1.Final);
    }

    [Fact]
    public void CharacterCodesGanTest()
    {
        var Syllable1 = new KoreanSyllable('간');

        Assert.Equal(KoreanLetter.Giyeok, Syllable1.Initial);
        Assert.Equal(KoreanLetter.A, Syllable1.Medial);
        Assert.Equal(KoreanLetter.NieunBatchim, Syllable1.Final);
    }

    [Fact]
    public void CharacterCodesGat1Test()
    {
        var Syllable1 = new KoreanSyllable('갇');

        Assert.Equal(KoreanLetter.Giyeok, Syllable1.Initial);
        Assert.Equal(KoreanLetter.A, Syllable1.Medial);
        Assert.Equal(KoreanLetter.DigeutBatchim, Syllable1.Final);
    }

    [Fact]
    public void CharacterCodesGamTest()
    {
        var Syllable1 = new KoreanSyllable('감');

        Assert.Equal(KoreanLetter.Giyeok, Syllable1.Initial);
        Assert.Equal(KoreanLetter.A, Syllable1.Medial);
        Assert.Equal(KoreanLetter.MieumBatchim, Syllable1.Final);
    }

    [Fact]
    public void CharacterCodesGapTest()
    {
        var Syllable1 = new KoreanSyllable('갑');

        Assert.Equal(KoreanLetter.Giyeok, Syllable1.Initial);
        Assert.Equal(KoreanLetter.A, Syllable1.Medial);
        Assert.Equal(KoreanLetter.BieupBatchim, Syllable1.Final);
    }

    [Fact]
    public void CharacterCodesGat2Test()
    {
        var Syllable1 = new KoreanSyllable('갓');

        Assert.Equal(KoreanLetter.Giyeok, Syllable1.Initial);
        Assert.Equal(KoreanLetter.A, Syllable1.Medial);
        Assert.Equal(KoreanLetter.ShiotBatchim, Syllable1.Final);
    }

    [Fact]
    public void CharacterCodesGangTest()
    {
        var Syllable1 = new KoreanSyllable('강');

        Assert.Equal(KoreanLetter.Giyeok, Syllable1.Initial);
        Assert.Equal(KoreanLetter.A, Syllable1.Medial);
        Assert.Equal(KoreanLetter.IeungBatchim, Syllable1.Final);
    }

    [Fact]
    public void CharacterCodesGat3Test()
    {
        var Syllable1 = new KoreanSyllable('갖');

        Assert.Equal(KoreanLetter.Giyeok, Syllable1.Initial);
        Assert.Equal(KoreanLetter.A, Syllable1.Medial);
        Assert.Equal(KoreanLetter.JieutBatchim, Syllable1.Final);
    }

    [Fact]
    public void CharacterCodesGat4Test()
    {
        var Syllable1 = new KoreanSyllable('갛');

        Assert.Equal(KoreanLetter.Giyeok, Syllable1.Initial);
        Assert.Equal(KoreanLetter.A, Syllable1.Medial);
        Assert.Equal(KoreanLetter.HieutBatchim, Syllable1.Final);
    }

    #endregion
}
