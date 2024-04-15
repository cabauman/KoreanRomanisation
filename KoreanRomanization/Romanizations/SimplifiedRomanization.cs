using System.Text;

namespace KoreanRomanization;

/// <summary>
/// A class for Romanizing text according to the Simplified Romanization of Korean.
/// </summary>
public sealed class SimplifiedRomanization : Romanization
{
    public SimplifiedRomanization()
    {
        SetRules();
    }

    protected override void SetRules()
    {
        var InitialRomanizationRulesList = new RomanizationRuleList()
        {
            { KoreanLetter.Giyeok, "k" },
            { KoreanLetter.SsangGiyeok, "kk" },
            { KoreanLetter.Nieun, "n" },
            { KoreanLetter.Digeut, "t" },
            { KoreanLetter.SsangDigeut, "tt" },
            { KoreanLetter.Rieul, "r" },
            { KoreanLetter.Mieum, "m" },
            { KoreanLetter.Bieup, "p" },
            { KoreanLetter.SsangBieup, "pp" },
            { KoreanLetter.Shiot, "s" },
            { KoreanLetter.SsangShiot, "ts" },
            { KoreanLetter.Ieung, "" },
            { KoreanLetter.Jieut, "ch" },
            { KoreanLetter.SsangJieut, "tch" },
            { KoreanLetter.Chieut, "ch" },
            { KoreanLetter.Kieuk, "k" },
            { KoreanLetter.Tieut, "t" },
            { KoreanLetter.Pieup, "p" },
            { KoreanLetter.Hieut, "h" }
        };

        var InitialPronunciationChangeRomanizationRulesList = new PronunciationChangeRomanizationRuleList()
        {
            { KoreanLetter.GiyeokBatchim, KoreanLetter.Rieul, "n" },
            { KoreanLetter.GiyeokBatchim, KoreanLetter.Hieut, "" },

            { KoreanLetter.SsangGiyeokBatchim, KoreanLetter.Rieul, "n" },
            { KoreanLetter.SsangGiyeokBatchim, KoreanLetter.Hieut, "" },

            { KoreanLetter.NieunBatchim, KoreanLetter.Giyeok, "'g" },
            { KoreanLetter.NieunBatchim, KoreanLetter.Digeut, "d" },
            { KoreanLetter.NieunBatchim, KoreanLetter.Rieul, "l" },
            { KoreanLetter.NieunBatchim, KoreanLetter.Bieup, "b" },
            { KoreanLetter.NieunBatchim, KoreanLetter.Jieut, "j" },
            { KoreanLetter.NieunBatchim, KoreanLetter.Hieut, "" },

            { KoreanLetter.DigeutBatchim, KoreanLetter.Rieul, "n" },
            { KoreanLetter.DigeutBatchim, KoreanLetter.Hieut, "" },

            { KoreanLetter.RieulBatchim, KoreanLetter.Giyeok, "g" },
            { KoreanLetter.RieulBatchim, KoreanLetter.Nieun, "l" },
            { KoreanLetter.RieulBatchim, KoreanLetter.Digeut, "d" },
            { KoreanLetter.RieulBatchim, KoreanLetter.Rieul, "l" },
            { KoreanLetter.RieulBatchim, KoreanLetter.Bieup, "b" },
            { KoreanLetter.RieulBatchim, KoreanLetter.Ieung, "" },
            { KoreanLetter.RieulBatchim, KoreanLetter.Jieut, "j" },
            { KoreanLetter.RieulBatchim, KoreanLetter.Hieut, "" },

            { KoreanLetter.MieumBatchim, KoreanLetter.Giyeok, "g" },
            { KoreanLetter.MieumBatchim, KoreanLetter.Digeut, "d" },
            { KoreanLetter.MieumBatchim, KoreanLetter.Rieul, "n" },
            { KoreanLetter.MieumBatchim, KoreanLetter.Bieup, "b" },
            { KoreanLetter.MieumBatchim, KoreanLetter.Jieut, "j" },
            { KoreanLetter.MieumBatchim, KoreanLetter.Hieut, "" },

            { KoreanLetter.BieupBatchim, KoreanLetter.Rieul, "n" },
            { KoreanLetter.BieupBatchim, KoreanLetter.Hieut, "" },

            { KoreanLetter.ShiotBatchim, KoreanLetter.Rieul, "n" },
            { KoreanLetter.ShiotBatchim, KoreanLetter.Hieut, "" },

            { KoreanLetter.SsangShiotBatchim, KoreanLetter.Rieul, "n" },
            { KoreanLetter.SsangShiotBatchim, KoreanLetter.Hieut, "" },

            { KoreanLetter.IeungBatchim, KoreanLetter.Giyeok, "g" },
            { KoreanLetter.IeungBatchim, KoreanLetter.Digeut, "d" },
            { KoreanLetter.IeungBatchim, KoreanLetter.Rieul, "n" },
            { KoreanLetter.IeungBatchim, KoreanLetter.Bieup, "b" },
            { KoreanLetter.IeungBatchim, KoreanLetter.Ieung, "'" },
            { KoreanLetter.IeungBatchim, KoreanLetter.Jieut, "j" },

            { KoreanLetter.JieutBatchim, KoreanLetter.Rieul, "n" },
            { KoreanLetter.JieutBatchim, KoreanLetter.Hieut, "" },

            { KoreanLetter.ChieutBatchim, KoreanLetter.Rieul, "n" },
            { KoreanLetter.ChieutBatchim, KoreanLetter.Hieut, "" },

            { KoreanLetter.KieukBatchim, KoreanLetter.Rieul, "n" },
            { KoreanLetter.KieukBatchim, KoreanLetter.Hieut, "" },

            { KoreanLetter.TieutBatchim, KoreanLetter.Rieul, "n" },
            { KoreanLetter.TieutBatchim, KoreanLetter.Hieut, "" },

            { KoreanLetter.PieupBatchim, KoreanLetter.Rieul, "n" },
            { KoreanLetter.PieupBatchim, KoreanLetter.Hieut, "" },

            { KoreanLetter.HieutBatchim, KoreanLetter.Rieul, "n" },
            { KoreanLetter.HieutBatchim, KoreanLetter.Hieut, "" }
        };

        var MedialRomanizationRulesList = new RomanizationRuleList()
        {
            { KoreanLetter.A, "a" },
            { KoreanLetter.Ae, "e" },
            { KoreanLetter.Ya, "ya" },
            { KoreanLetter.Yae, "ye" },
            { KoreanLetter.Eo, "o" },
            { KoreanLetter.E, "ei" },
            { KoreanLetter.Yeo, "yo" },
            { KoreanLetter.Ye, "yei" },
            { KoreanLetter.O, "o" },
            { KoreanLetter.Wa, "wa" },
            { KoreanLetter.Wae, "we" },
            { KoreanLetter.Oe, "we" },
            { KoreanLetter.Yo, "yo" },
            { KoreanLetter.U, "oo" },
            { KoreanLetter.Wo, "wo" },
            { KoreanLetter.We, "wei" },
            { KoreanLetter.Wi, "wi" },
            { KoreanLetter.Yu, "yoo" },
            { KoreanLetter.Eu, "u" },
            { KoreanLetter.Ui, "ui" },
            { KoreanLetter.I, "i" }
        };

        var FinalRomanizationRulesList = new RomanizationRuleList()
        {
            { KoreanLetter.GiyeokBatchim, "k" },
            { KoreanLetter.SsangGiyeokBatchim, "k" },
            { KoreanLetter.NieunBatchim, "n" },
            { KoreanLetter.DigeutBatchim, "t" },
            { KoreanLetter.RieulBatchim, "l" },
            { KoreanLetter.MieumBatchim, "m" },
            { KoreanLetter.BieupBatchim, "p" },
            { KoreanLetter.ShiotBatchim, "t" },
            { KoreanLetter.SsangShiotBatchim, "t" },
            { KoreanLetter.IeungBatchim, "ng" },
            { KoreanLetter.JieutBatchim, "t" },
            { KoreanLetter.ChieutBatchim, "t" },
            { KoreanLetter.KieukBatchim, "k" },
            { KoreanLetter.TieutBatchim, "t" },
            { KoreanLetter.PieupBatchim, "p" },
            { KoreanLetter.HieutBatchim, "t" }
        };

        var FinalPronunciationChangeRomanizationRulesList = new PronunciationChangeRomanizationRuleList()
        {
            { KoreanLetter.GiyeokBatchim, KoreanLetter.SsangGiyeok, "" },
            { KoreanLetter.GiyeokBatchim, KoreanLetter.Nieun, "ng" },
            { KoreanLetter.GiyeokBatchim, KoreanLetter.Rieul, "ng" },
            { KoreanLetter.GiyeokBatchim, KoreanLetter.Mieum, "ng" },
            { KoreanLetter.GiyeokBatchim, KoreanLetter.Ieung, "g" },

            { KoreanLetter.SsangGiyeokBatchim, KoreanLetter.SsangGiyeok, "" },
            { KoreanLetter.SsangGiyeokBatchim, KoreanLetter.Nieun, "ng" },
            { KoreanLetter.SsangGiyeokBatchim, KoreanLetter.Rieul, "ng" },
            { KoreanLetter.SsangGiyeokBatchim, KoreanLetter.Mieum, "ng" },
            { KoreanLetter.SsangGiyeokBatchim, KoreanLetter.Ieung, "kk" },

            { KoreanLetter.NieunBatchim, KoreanLetter.Rieul, "l" },

            { KoreanLetter.DigeutBatchim, KoreanLetter.Nieun, "n" },
            { KoreanLetter.DigeutBatchim, KoreanLetter.SsangDigeut, "" },
            { KoreanLetter.DigeutBatchim, KoreanLetter.Rieul, "n" },
            { KoreanLetter.DigeutBatchim, KoreanLetter.Mieum, "n" },
            { KoreanLetter.DigeutBatchim, KoreanLetter.Ieung, "d" },

            { KoreanLetter.RieulBatchim, KoreanLetter.Ieung, "r" },
            { KoreanLetter.RieulBatchim, KoreanLetter.Hieut, "r" },

            { KoreanLetter.BieupBatchim, KoreanLetter.Nieun, "m" },
            { KoreanLetter.BieupBatchim, KoreanLetter.Rieul, "m" },
            { KoreanLetter.BieupBatchim, KoreanLetter.Mieum, "m" },
            { KoreanLetter.BieupBatchim, KoreanLetter.SsangBieup, "" },
            { KoreanLetter.BieupBatchim, KoreanLetter.Ieung, "b" },

            { KoreanLetter.ShiotBatchim, KoreanLetter.Nieun, "n" },
            { KoreanLetter.ShiotBatchim, KoreanLetter.SsangDigeut, "" },
            { KoreanLetter.ShiotBatchim, KoreanLetter.Rieul, "n" },
            { KoreanLetter.ShiotBatchim, KoreanLetter.Mieum, "n" },
            { KoreanLetter.ShiotBatchim, KoreanLetter.Shiot, "s" },
            { KoreanLetter.ShiotBatchim, KoreanLetter.Ieung, "s" },

            { KoreanLetter.SsangShiotBatchim, KoreanLetter.Nieun, "n" },
            { KoreanLetter.SsangShiotBatchim, KoreanLetter.SsangDigeut, "" },
            { KoreanLetter.SsangShiotBatchim, KoreanLetter.Rieul, "n" },
            { KoreanLetter.SsangShiotBatchim, KoreanLetter.Mieum, "n" },
            { KoreanLetter.SsangShiotBatchim, KoreanLetter.Shiot, "s" },
            { KoreanLetter.SsangShiotBatchim, KoreanLetter.Ieung, "ts" },

            { KoreanLetter.JieutBatchim, KoreanLetter.Nieun, "n" },
            { KoreanLetter.JieutBatchim, KoreanLetter.SsangDigeut, "" },
            { KoreanLetter.JieutBatchim, KoreanLetter.Rieul, "n" },
            { KoreanLetter.JieutBatchim, KoreanLetter.Mieum, "n" },
            { KoreanLetter.JieutBatchim, KoreanLetter.Ieung, "j" },

            { KoreanLetter.ChieutBatchim, KoreanLetter.Nieun, "n" },
            { KoreanLetter.ChieutBatchim, KoreanLetter.SsangDigeut, "" },
            { KoreanLetter.ChieutBatchim, KoreanLetter.Rieul, "n" },
            { KoreanLetter.ChieutBatchim, KoreanLetter.Mieum, "n" },
            { KoreanLetter.ChieutBatchim, KoreanLetter.Ieung, "ch" },

            { KoreanLetter.KieukBatchim, KoreanLetter.SsangGiyeok, "" },
            { KoreanLetter.KieukBatchim, KoreanLetter.Nieun, "ng" },
            { KoreanLetter.KieukBatchim, KoreanLetter.Rieul, "ng" },
            { KoreanLetter.KieukBatchim, KoreanLetter.Mieum, "ng" },

            { KoreanLetter.TieutBatchim, KoreanLetter.Nieun, "n" },
            { KoreanLetter.TieutBatchim, KoreanLetter.SsangDigeut, "" },
            { KoreanLetter.TieutBatchim, KoreanLetter.Rieul, "n" },
            { KoreanLetter.TieutBatchim, KoreanLetter.Mieum, "n" },

            { KoreanLetter.PieupBatchim, KoreanLetter.Nieun, "m" },
            { KoreanLetter.PieupBatchim, KoreanLetter.Rieul, "m" },
            { KoreanLetter.PieupBatchim, KoreanLetter.Mieum, "m" },
            { KoreanLetter.PieupBatchim, KoreanLetter.SsangBieup, "" },

            { KoreanLetter.HieutBatchim, KoreanLetter.Nieun, "n" },
            { KoreanLetter.HieutBatchim, KoreanLetter.SsangDigeut, "" },
            { KoreanLetter.HieutBatchim, KoreanLetter.Rieul, "n" },
            { KoreanLetter.HieutBatchim, KoreanLetter.Mieum, "n" },
            { KoreanLetter.HieutBatchim, KoreanLetter.Ieung, "h" }
        };

        InitialRomanizationRules = InitialRomanizationRulesList.ToInitialRomanizationRules();
        InitialPronunciationChangeRomanizationRules = InitialPronunciationChangeRomanizationRulesList.ToInitialPronunciationChangeRomanizationRules();

        MedialRomanizationRules = MedialRomanizationRulesList.ToMedialRomanizationRules();

        FinalRomanizationRules = FinalRomanizationRulesList.ToFinalRomanizationRules();
        FinalPronunciationChangeRomanizationRules = FinalPronunciationChangeRomanizationRulesList.ToFinalPronunciationChangeRomanizationRules();
    }

    public override string RomanizeSyllable(KoreanSyllable Syllable, KoreanSyllable? PrecedingSyllable = null, KoreanSyllable? SucceedingSyllable = null)
    {
        var StringBuilder1 = new StringBuilder();

        StringBuilder1.Append(RomanizeInitial(Syllable, PrecedingSyllable, SucceedingSyllable));
        StringBuilder1.Append(RomanizeMedial(Syllable, PrecedingSyllable, SucceedingSyllable));
        StringBuilder1.Append(RomanizeFinal(Syllable, PrecedingSyllable, SucceedingSyllable));

        return StringBuilder1.ToString();
    }

    private string RomanizeInitial(KoreanSyllable Syllable, KoreanSyllable? PrecedingSyllable, KoreanSyllable? SucceedingSyllable)
    {
        if (PrecedingSyllable != null)
        {
            var PronunciationChangeRomanizationRule = InitialPronunciationChangeRomanizationRules.FirstOrDefault(r => r.PrecedingFinal == PrecedingSyllable.Value.Final && r.Initial == Syllable.Initial);

            if (PronunciationChangeRomanizationRule != null)
            {
                return PronunciationChangeRomanizationRule.Romanization;
            }
        }

        var IsSInitial = (Syllable.Initial == KoreanLetter.Shiot || Syllable.Initial == KoreanLetter.SsangShiot);

        if (UseSh && IsSInitial && IsIMedial(Syllable.Medial))
        {
            return "sh";
        }

        return InitialRomanizationRules.First(r => r.Initial == Syllable.Initial).Romanization;
    }

    private string RomanizeMedial(KoreanSyllable Syllable, KoreanSyllable? PrecedingSyllable, KoreanSyllable? SucceedingSyllable)
    {
        return MedialRomanizationRules.First(r => r.Medial == Syllable.Medial).Romanization;
    }

    private string RomanizeFinal(KoreanSyllable Syllable, KoreanSyllable? PrecedingSyllable, KoreanSyllable? SucceedingSyllable)
    {
        if (Syllable.HasFinal)
        {
            if (SucceedingSyllable != null)
            {
                var PronunciationChangeRomanizationRule = FinalPronunciationChangeRomanizationRules.FirstOrDefault(r => r.Final == Syllable.Final && r.SucceedingInitial == SucceedingSyllable.Value.Initial);

                if (PronunciationChangeRomanizationRule != null)
                {
                    return PronunciationChangeRomanizationRule.Romanization;
                }
            }

            return FinalRomanizationRules.First(r => r.Final == Syllable.Final).Romanization;
        }

        return "";
    }

    public override string RomanizeLetter(KoreanLetter Letter)
    {
        throw new NotImplementedException();
    }
}
