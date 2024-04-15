using System.Text;

namespace KoreanRomanization;

/// <summary>
/// A class for Romanizing text according to the Yale Romanization of Korean.
/// </summary>
public sealed class YaleRomanization : Romanization
{
    public YaleRomanization()
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
            { KoreanLetter.Rieul, "l" },
            { KoreanLetter.Mieum, "m" },
            { KoreanLetter.Bieup, "p" },
            { KoreanLetter.SsangBieup, "pp" },
            { KoreanLetter.Shiot, "s" },
            { KoreanLetter.SsangShiot, "ss" },
            { KoreanLetter.Ieung, "" },
            { KoreanLetter.Jieut, "c" },
            { KoreanLetter.SsangJieut, "cc" },
            { KoreanLetter.Chieut, "ch" },
            { KoreanLetter.Kieuk, "kh" },
            { KoreanLetter.Tieut, "th" },
            { KoreanLetter.Pieup, "ph" },
            { KoreanLetter.Hieut, "h" }
        };

        var MedialRomanizationRulesList = new RomanizationRuleList()
        {
            { KoreanLetter.A, "a" },
            { KoreanLetter.Ae, "ay" },
            { KoreanLetter.Ya, "ya" },
            { KoreanLetter.Yae, "yay" },
            { KoreanLetter.Eo, "e" },
            { KoreanLetter.E, "ey" },
            { KoreanLetter.Yeo, "ye" },
            { KoreanLetter.Ye, "yey" },
            { KoreanLetter.O, "o" },
            { KoreanLetter.Wa, "wa" },
            { KoreanLetter.Wae, "way" },
            { KoreanLetter.Oe, "oy" },
            { KoreanLetter.Yo, "yo" },
            { KoreanLetter.U, "u" },
            { KoreanLetter.Wo, "we" },
            { KoreanLetter.We, "wey" },
            { KoreanLetter.Wi, "wi" },
            { KoreanLetter.Yu, "yu" },
            { KoreanLetter.Eu, "u" },
            { KoreanLetter.Ui, "uy" },
            { KoreanLetter.I, "i" }
        };

        var FinalRomanizationRulesList = new RomanizationRuleList()
        {
            { KoreanLetter.GiyeokBatchim, "k" },
            { KoreanLetter.SsangGiyeokBatchim, "kk" },
            { KoreanLetter.GiyeokShiotBatchim, "ks" },
            { KoreanLetter.NieunBatchim, "n" },
            { KoreanLetter.NieunJieutBatchim, "nc" },
            { KoreanLetter.NieunHieutBatchim, "nh" },
            { KoreanLetter.DigeutBatchim, "t" },
            { KoreanLetter.RieulBatchim, "l" },
            { KoreanLetter.RieulGiyeokBatchim, "lk" },
            { KoreanLetter.RieulMieumBatchim, "lm" },
            { KoreanLetter.RieulBieupBatchim, "lp" },
            { KoreanLetter.RieulShiotBatchim, "ls" },
            { KoreanLetter.RieulTieutBatchim, "lth" },
            { KoreanLetter.RieulPieupBatchim, "lph" },
            { KoreanLetter.RieulHieutBatchim, "lh" },
            { KoreanLetter.MieumBatchim, "m" },
            { KoreanLetter.BieupBatchim, "p" },
            { KoreanLetter.BieupShiotBatchim, "ps" },
            { KoreanLetter.ShiotBatchim, "s" },
            { KoreanLetter.SsangShiotBatchim, "ss" },
            { KoreanLetter.IeungBatchim, "ng" },
            { KoreanLetter.JieutBatchim, "c" },
            { KoreanLetter.ChieutBatchim, "ch" },
            { KoreanLetter.KieukBatchim, "kh" },
            { KoreanLetter.TieutBatchim, "th" },
            { KoreanLetter.PieupBatchim, "ph" },
            { KoreanLetter.HieutBatchim, "h" }
        };


        var FinalPronunciationChangeRomanizationRulesList = new PronunciationChangeRomanizationRuleList()
        {
            { KoreanLetter.GiyeokShiotBatchim, KoreanLetter.Ieung, "ks." },
            { KoreanLetter.GiyeokShiotBatchim, KoreanLetter.Shiot, "ks." },

            { KoreanLetter.NieunJieutBatchim, KoreanLetter.Ieung, "nc." },
            { KoreanLetter.NieunJieutBatchim, KoreanLetter.Jieut, "nc." },
            { KoreanLetter.NieunJieutBatchim, KoreanLetter.Hieut, "nc." },

            { KoreanLetter.NieunHieutBatchim, KoreanLetter.Ieung, "nh." },

            { KoreanLetter.RieulGiyeokBatchim, KoreanLetter.Ieung, "lk." },
            { KoreanLetter.RieulGiyeokBatchim, KoreanLetter.Giyeok, "lk." },
            { KoreanLetter.RieulGiyeokBatchim, KoreanLetter.Hieut, "lk." },

            { KoreanLetter.RieulMieumBatchim, KoreanLetter.Ieung, "lm." },

            { KoreanLetter.RieulBieupBatchim, KoreanLetter.Ieung, "lp." },
            { KoreanLetter.RieulBieupBatchim, KoreanLetter.Bieup, "lp." },
            { KoreanLetter.RieulBieupBatchim, KoreanLetter.Hieut, "lp." },

            { KoreanLetter.RieulShiotBatchim, KoreanLetter.Ieung, "ls." },
            { KoreanLetter.RieulShiotBatchim, KoreanLetter.Shiot, "ls." },

            { KoreanLetter.RieulTieutBatchim, KoreanLetter.Ieung, "lth." },

            { KoreanLetter.RieulPieupBatchim, KoreanLetter.Ieung, "lph." },

            { KoreanLetter.RieulHieutBatchim, KoreanLetter.Ieung, "lh." },

            { KoreanLetter.BieupShiotBatchim, KoreanLetter.Ieung, "ps." },
            { KoreanLetter.BieupShiotBatchim, KoreanLetter.Shiot, "ps." }

        };

        InitialRomanizationRules = InitialRomanizationRulesList.ToInitialRomanizationRules();

        MedialRomanizationRules = MedialRomanizationRulesList.ToMedialRomanizationRules();

        FinalRomanizationRules = FinalRomanizationRulesList.ToFinalRomanizationRules();
        FinalPronunciationChangeRomanizationRules = FinalPronunciationChangeRomanizationRulesList.ToFinalPronunciationChangeRomanizationRules();
    }

    public override string RomanizeSyllable(KoreanSyllable Syllable, KoreanSyllable? PrecedingSyllable = null, KoreanSyllable? SucceedingSyllable = null)
    {
        var StringBuilder1 = new StringBuilder();

        StringBuilder1.Append(RomanizeInitial(Syllable));
        StringBuilder1.Append(RomanizeMedial(Syllable));
        StringBuilder1.Append(RomanizeFinal(Syllable, PrecedingSyllable, SucceedingSyllable));

        return StringBuilder1.ToString();
    }

    private string RomanizeInitial(KoreanSyllable Syllable)
    {
        return InitialRomanizationRules.First(r => r.Initial == Syllable.Initial).Romanization;
    }

    private string RomanizeMedial(KoreanSyllable Syllable)
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
