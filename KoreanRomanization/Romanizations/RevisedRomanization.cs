﻿using System.Text;

namespace KoreanRomanization;

/// <summary>
/// A class for Romanizing text according to the Revised Romanization of Korean.
/// </summary>
public sealed class RevisedRomanization : Romanization
{
    public RevisedRomanization()
    {
        SetRules();
    }

    protected override void SetRules()
    {
        var InitialRomanizationRulesList = new RomanizationRuleList()
        {
            { KoreanLetter.Giyeok, "g" },
            { KoreanLetter.SsangGiyeok, "kk" },
            { KoreanLetter.Nieun, "n" },
            { KoreanLetter.Digeut, "d" },
            { KoreanLetter.SsangDigeut, "tt" },
            { KoreanLetter.Rieul, "r" },
            { KoreanLetter.Mieum, "m" },
            { KoreanLetter.Bieup, "b" },
            { KoreanLetter.SsangBieup, "pp" },
            { KoreanLetter.Shiot, "s" },
            { KoreanLetter.SsangShiot, "ss" },
            { KoreanLetter.Ieung, "" },
            { KoreanLetter.Jieut, "j" },
            { KoreanLetter.SsangJieut, "jj" },
            { KoreanLetter.Chieut, "ch" },
            { KoreanLetter.Kieuk, "k" },
            { KoreanLetter.Tieut, "t" },
            { KoreanLetter.Pieup, "p" },
            { KoreanLetter.Hieut, "h" }
        };

        var InitialPronunciationChangeRomanizationRulesList = new PronunciationChangeRomanizationRuleList()
        {
            { KoreanLetter.GiyeokBatchim, KoreanLetter.Rieul, "n" },
            { KoreanLetter.GiyeokBatchim, KoreanLetter.Kieuk, "-k" },
            { KoreanLetter.GiyeokBatchim, KoreanLetter.Hieut, "" },

            { KoreanLetter.SsangGiyeokBatchim, KoreanLetter.Rieul, "n" },
            { KoreanLetter.SsangGiyeokBatchim, KoreanLetter.Kieuk, "-k" },

            { KoreanLetter.NieunBatchim, KoreanLetter.Giyeok, "-g" },
            { KoreanLetter.NieunBatchim, KoreanLetter.Rieul, "l" },

            { KoreanLetter.DigeutBatchim, KoreanLetter.Rieul, "n" },
            { KoreanLetter.DigeutBatchim, KoreanLetter.Tieut, "-t" },

            { KoreanLetter.RieulBatchim, KoreanLetter.Nieun, "l" },
            { KoreanLetter.RieulBatchim, KoreanLetter.Rieul, "l" },

            { KoreanLetter.RieulHieutBatchim, KoreanLetter.Digeut, "t" },
            { KoreanLetter.NieunHieutBatchim, KoreanLetter.Digeut, "t" },
            //{ KoreanLetter.RieulGiyeokBatchim, KoreanLetter.Digeut, "t" },
            //{ KoreanLetter.RieulBieupBatchim, KoreanLetter.Digeut, "tt" },
            //{ KoreanLetter.NieunJieutBatchim, KoreanLetter.Digeut, "tt" },
            //{ KoreanLetter.BieupShiotBatchim, KoreanLetter.Digeut, "tt" },
            //{ KoreanLetter.RieulMieumBatchim, KoreanLetter.Digeut, "tt" },
            //{ KoreanLetter.RieulPieupBatchim, KoreanLetter.Digeut, "tt" },
            //{ KoreanLetter.RieulTieutBatchim, KoreanLetter.Digeut, "tt" },

            { KoreanLetter.MieumBatchim, KoreanLetter.Rieul, "n" },

            { KoreanLetter.BieupBatchim, KoreanLetter.Rieul, "n" },
            { KoreanLetter.BieupBatchim, KoreanLetter.Pieup, "-p" },

            { KoreanLetter.ShiotBatchim, KoreanLetter.Rieul, "n" },
            { KoreanLetter.ShiotBatchim, KoreanLetter.Tieut, "-t" },

            { KoreanLetter.SsangShiotBatchim, KoreanLetter.Rieul, "n" },
            { KoreanLetter.SsangShiotBatchim, KoreanLetter.Tieut, "-t" },

            { KoreanLetter.IeungBatchim, KoreanLetter.Ieung, "-" },
            { KoreanLetter.IeungBatchim, KoreanLetter.Rieul, "n" },

            { KoreanLetter.JieutBatchim, KoreanLetter.Rieul, "n" },
            { KoreanLetter.JieutBatchim, KoreanLetter.Tieut, "-t" },

            { KoreanLetter.ChieutBatchim, KoreanLetter.Rieul, "n" },
            { KoreanLetter.ChieutBatchim, KoreanLetter.Tieut, "-t" },

            { KoreanLetter.KieukBatchim, KoreanLetter.Rieul, "n" },
            { KoreanLetter.KieukBatchim, KoreanLetter.Kieuk, "-k" },

            { KoreanLetter.TieutBatchim, KoreanLetter.Rieul, "n" },
            { KoreanLetter.TieutBatchim, KoreanLetter.Tieut, "-t" },

            { KoreanLetter.PieupBatchim, KoreanLetter.Rieul, "n" },
            { KoreanLetter.PieupBatchim, KoreanLetter.Pieup, "-p" },

            { KoreanLetter.HieutBatchim, KoreanLetter.Rieul, "n" },
            { KoreanLetter.HieutBatchim, KoreanLetter.Tieut, "-t" }
        };

        var MedialRomanizationRulesList = new RomanizationRuleList()
        {
            { KoreanLetter.A, "a" },
            { KoreanLetter.Ae, "ae" },
            { KoreanLetter.Ya, "ya" },
            { KoreanLetter.Yae, "yae" },
            { KoreanLetter.Eo, "eo" },
            { KoreanLetter.E, "e" },
            { KoreanLetter.Yeo, "yeo" },
            { KoreanLetter.Ye, "ye" },
            { KoreanLetter.O, "o" },
            { KoreanLetter.Wa, "wa" },
            { KoreanLetter.Wae, "wae" },
            { KoreanLetter.Oe, "oe" },
            { KoreanLetter.Yo, "yo" },
            { KoreanLetter.U, "u" },
            { KoreanLetter.Wo, "wo" },
            { KoreanLetter.We, "we" },
            { KoreanLetter.Wi, "wi" },
            { KoreanLetter.Yu, "yu" },
            { KoreanLetter.Eu, "eu" },
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
            { KoreanLetter.HieutBatchim, "t" },
            { KoreanLetter.RieulGiyeokBatchim, "k" },
            { KoreanLetter.RieulHieutBatchim, "l" },
            { KoreanLetter.RieulBieupBatchim, "l" },
            { KoreanLetter.NieunJieutBatchim, "n" },
            { KoreanLetter.BieupShiotBatchim, "b" },
            { KoreanLetter.NieunHieutBatchim, "n" },
            { KoreanLetter.RieulMieumBatchim, "m" },
            { KoreanLetter.GiyeokShiotBatchim, "k" },
            { KoreanLetter.RieulShiotBatchim, "l" },
            { KoreanLetter.RieulPieupBatchim, "p" },
            { KoreanLetter.RieulTieutBatchim, "l" }
        };

        var FinalPronunciationChangeRomanizationRulesList = new PronunciationChangeRomanizationRuleList()
        {
            { KoreanLetter.GiyeokBatchim, KoreanLetter.SsangGiyeok , "" },
            { KoreanLetter.GiyeokBatchim, KoreanLetter.Ieung , "g" },
            { KoreanLetter.GiyeokBatchim, KoreanLetter.Nieun , "ng" },
            { KoreanLetter.GiyeokBatchim, KoreanLetter.Rieul , "ng" },
            { KoreanLetter.GiyeokBatchim, KoreanLetter.Mieum , "ng" },

            { KoreanLetter.SsangGiyeokBatchim, KoreanLetter.SsangGiyeok , "" },
            { KoreanLetter.SsangGiyeokBatchim, KoreanLetter.Nieun , "ng" },
            { KoreanLetter.SsangGiyeokBatchim, KoreanLetter.Rieul , "ng" },
            { KoreanLetter.SsangGiyeokBatchim, KoreanLetter.Mieum , "ng" },
            { KoreanLetter.SsangGiyeokBatchim, KoreanLetter.Ieung , "kk" },

            { KoreanLetter.NieunBatchim, KoreanLetter.Rieul , "l" },

            { KoreanLetter.DigeutBatchim, KoreanLetter.Nieun , "n" },
            { KoreanLetter.DigeutBatchim, KoreanLetter.SsangDigeut , "" },
            { KoreanLetter.DigeutBatchim, KoreanLetter.Rieul , "n" },
            { KoreanLetter.DigeutBatchim, KoreanLetter.Mieum , "n" },
            { KoreanLetter.DigeutBatchim, KoreanLetter.Ieung , "d" },

            { KoreanLetter.RieulBatchim, KoreanLetter.Ieung , "r" },

            { KoreanLetter.RieulBieupBatchim, KoreanLetter.Ieung , "lb" },

            { KoreanLetter.RieulGiyeokBatchim, KoreanLetter.Ieung , "lg" },

            { KoreanLetter.RieulHieutBatchim, KoreanLetter.Ieung , "r" },

            { KoreanLetter.NieunJieutBatchim, KoreanLetter.Ieung , "nj" },

            { KoreanLetter.BieupShiotBatchim, KoreanLetter.Ieung , "bs" },

            { KoreanLetter.RieulMieumBatchim, KoreanLetter.Ieung , "lm" },

            { KoreanLetter.GiyeokShiotBatchim, KoreanLetter.Ieung , "ks" },

            { KoreanLetter.RieulShiotBatchim, KoreanLetter.Ieung , "ls" },

            { KoreanLetter.RieulPieupBatchim, KoreanLetter.Ieung , "lp" },

            { KoreanLetter.RieulTieutBatchim, KoreanLetter.Ieung , "lt" },

            { KoreanLetter.BieupBatchim, KoreanLetter.Ieung , "b" },
            { KoreanLetter.BieupBatchim, KoreanLetter.Nieun , "m" },
            { KoreanLetter.BieupBatchim, KoreanLetter.Rieul , "m" },
            { KoreanLetter.BieupBatchim, KoreanLetter.Mieum , "m" },
            { KoreanLetter.BieupBatchim, KoreanLetter.SsangBieup , "" },

            { KoreanLetter.ShiotBatchim, KoreanLetter.SsangDigeut , "" },
            { KoreanLetter.ShiotBatchim, KoreanLetter.Ieung , "s" },
            { KoreanLetter.ShiotBatchim, KoreanLetter.Nieun , "n" },
            { KoreanLetter.ShiotBatchim, KoreanLetter.Rieul , "n" },
            { KoreanLetter.ShiotBatchim, KoreanLetter.Mieum , "n" },
            { KoreanLetter.ShiotBatchim, KoreanLetter.Shiot , "s" },

            { KoreanLetter.SsangShiotBatchim, KoreanLetter.Nieun , "n" },
            { KoreanLetter.SsangShiotBatchim, KoreanLetter.SsangDigeut , "" },
            { KoreanLetter.SsangShiotBatchim, KoreanLetter.Rieul , "n" },
            { KoreanLetter.SsangShiotBatchim, KoreanLetter.Mieum , "n" },
            { KoreanLetter.SsangShiotBatchim, KoreanLetter.Shiot , "s" },
            { KoreanLetter.SsangShiotBatchim, KoreanLetter.Ieung , "ss" },

            { KoreanLetter.JieutBatchim, KoreanLetter.Ieung , "j" },
            { KoreanLetter.JieutBatchim, KoreanLetter.Nieun , "n" },
            { KoreanLetter.JieutBatchim, KoreanLetter.SsangDigeut , "" },
            { KoreanLetter.JieutBatchim, KoreanLetter.Rieul , "n" },
            { KoreanLetter.JieutBatchim, KoreanLetter.Mieum , "n" },

            { KoreanLetter.ChieutBatchim, KoreanLetter.Nieun , "n" },
            { KoreanLetter.ChieutBatchim, KoreanLetter.SsangDigeut , "" },
            { KoreanLetter.ChieutBatchim, KoreanLetter.Rieul , "n" },
            { KoreanLetter.ChieutBatchim, KoreanLetter.Mieum , "n" },
            { KoreanLetter.ChieutBatchim, KoreanLetter.Ieung , "ch" },

            { KoreanLetter.KieukBatchim, KoreanLetter.SsangGiyeok , "" },
            { KoreanLetter.KieukBatchim, KoreanLetter.Nieun , "ng" },
            { KoreanLetter.KieukBatchim, KoreanLetter.Rieul , "ng" },
            { KoreanLetter.KieukBatchim, KoreanLetter.Mieum , "ng" },

            { KoreanLetter.TieutBatchim, KoreanLetter.SsangDigeut , "" },
            { KoreanLetter.TieutBatchim, KoreanLetter.Nieun , "n" },
            { KoreanLetter.TieutBatchim, KoreanLetter.Rieul , "n" },
            { KoreanLetter.TieutBatchim, KoreanLetter.Mieum , "n" },

            { KoreanLetter.PieupBatchim, KoreanLetter.Nieun , "m" },
            { KoreanLetter.PieupBatchim, KoreanLetter.Rieul , "m" },
            { KoreanLetter.PieupBatchim, KoreanLetter.Mieum , "m" },
            { KoreanLetter.PieupBatchim, KoreanLetter.SsangBieup , "" },

            { KoreanLetter.HieutBatchim, KoreanLetter.Ieung , "h" },
            { KoreanLetter.HieutBatchim, KoreanLetter.Nieun , "n" },
            { KoreanLetter.HieutBatchim, KoreanLetter.SsangDigeut , "" },
            { KoreanLetter.HieutBatchim, KoreanLetter.Rieul , "n" },
            { KoreanLetter.HieutBatchim, KoreanLetter.Mieum , "n" }
        };

        InitialRomanizationRules = InitialRomanizationRulesList.ToInitialRomanizationRules();
        InitialPronunciationChangeRomanizationRules = InitialPronunciationChangeRomanizationRulesList
            .ToInitialPronunciationChangeRomanizationRules();

        MedialRomanizationRules = MedialRomanizationRulesList.ToMedialRomanizationRules();

        FinalRomanizationRules = FinalRomanizationRulesList.ToFinalRomanizationRules();
        FinalPronunciationChangeRomanizationRules = FinalPronunciationChangeRomanizationRulesList
            .ToFinalPronunciationChangeRomanizationRules();
    }

    public override string RomanizeSyllable(
        KoreanSyllable Syllable,
        KoreanSyllable? PrecedingSyllable = null,
        KoreanSyllable? SucceedingSyllable = null)
    {
        _stringBuilder.Append(RomanizeInitial(Syllable, PrecedingSyllable, SucceedingSyllable));
        _stringBuilder.Append(RomanizeMedial(Syllable, PrecedingSyllable, SucceedingSyllable));
        _stringBuilder.Append(RomanizeFinal(Syllable, PrecedingSyllable, SucceedingSyllable));

        return _stringBuilder.ToString();
    }

    private string RomanizeInitial(
        KoreanSyllable Syllable,
        KoreanSyllable? PrecedingSyllable,
        KoreanSyllable? SucceedingSyllable)
    {
        if (PrecedingSyllable != null)
        {
            if (Syllable.Initial == KoreanLetter.Hieut &&
                (Syllable.Medial == KoreanLetter.I || Syllable.Medial == KoreanLetter.Yeo))
            {
                if (PrecedingSyllable.Value.Final == KoreanLetter.DigeutBatchim)
                {
                    return "ch";
                }
            }
            if ((Syllable.Initial == KoreanLetter.Ieung || Syllable.Initial == KoreanLetter.Hieut) &&
                (Syllable.Medial == KoreanLetter.I || Syllable.Medial == KoreanLetter.Yeo))
            {
                if (PrecedingSyllable.Value.Final == KoreanLetter.TieutBatchim)
                {
                    return "ch";
                }
                if (PrecedingSyllable.Value.Final == KoreanLetter.DigeutBatchim)
                {
                    return "j";
                }
            }

            var PronunciationChangeRomanizationRule = InitialPronunciationChangeRomanizationRules.FirstOrDefault(r => r.PrecedingFinal == PrecedingSyllable.Value.Final && r.Initial == Syllable.Initial);

            if (PronunciationChangeRomanizationRule != null)
            {
                return PronunciationChangeRomanizationRule.Romanization;
            }
        }

        if (UseSh && Syllable.Initial == KoreanLetter.Shiot && IsIMedial(Syllable.Medial))
        {
            return "sh";
        }
        if (UseSh && Syllable.Initial == KoreanLetter.SsangShiot && IsIMedial(Syllable.Medial))
        {
            return "ssh";
        }

        return InitialRomanizationRules.First(r => r.Initial == Syllable.Initial).Romanization;
    }

    private string RomanizeMedial(
        KoreanSyllable Syllable,
        KoreanSyllable? PrecedingSyllable,
        KoreanSyllable? SucceedingSyllable)
    {
        return MedialRomanizationRules.First(r => r.Medial == Syllable.Medial).Romanization;
    }

    private string RomanizeFinal(
        KoreanSyllable Syllable,
        KoreanSyllable? PrecedingSyllable,
        KoreanSyllable? SucceedingSyllable)
    {
        if (Syllable.HasFinal)
        {
            if (SucceedingSyllable != null)
            {
                if ((Syllable.Final == KoreanLetter.TieutBatchim || Syllable.Final == KoreanLetter.DigeutBatchim) &&
                    (SucceedingSyllable.Value.Initial == KoreanLetter.Ieung || SucceedingSyllable.Value.Initial == KoreanLetter.Hieut) &&
                    (SucceedingSyllable.Value.Medial == KoreanLetter.I || SucceedingSyllable.Value.Medial == KoreanLetter.Yeo))
                {
                    return "";
                }

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
