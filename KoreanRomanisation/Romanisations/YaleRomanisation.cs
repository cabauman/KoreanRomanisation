﻿using System.Text;

namespace KoreanRomanisation
{
    /// <summary>
    /// A class for romanising text according to the Yale Romanisation of Korean.
    /// </summary>
    public sealed class YaleRomanisation : Romanisation
    {
        public YaleRomanisation()
        {
            SetRules();
        }

        protected override void SetRules()
        {
            var InitialRomanisationRulesList = new RomanisationRuleList()
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

            var MedialRomanisationRulesList = new RomanisationRuleList()
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

            var FinalRomanisationRulesList = new RomanisationRuleList()
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


            var FinalPronunciationChangeRomanisationRulesList = new PronunciationChangeRomanisationRuleList()
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

            InitialRomanisationRules = InitialRomanisationRulesList.ToInitialRomanisationRules();

            MedialRomanisationRules = MedialRomanisationRulesList.ToMedialRomanisationRules();

            FinalRomanisationRules = FinalRomanisationRulesList.ToFinalRomanisationRules();
            FinalPronunciationChangeRomanisationRules = FinalPronunciationChangeRomanisationRulesList.ToFinalPronunciationChangeRomanisationRules();
        }

        public override string RomaniseSyllable(KoreanSyllable Syllable, KoreanSyllable? PrecedingSyllable = null, KoreanSyllable? SucceedingSyllable = null)
        {
            var StringBuilder1 = new StringBuilder();

            StringBuilder1.Append(RomaniseInitial(Syllable));
            StringBuilder1.Append(RomaniseMedial(Syllable));
            StringBuilder1.Append(RomaniseFinal(Syllable, PrecedingSyllable, SucceedingSyllable));

            return StringBuilder1.ToString();
        }

        private string RomaniseInitial(KoreanSyllable Syllable)
        {
            return InitialRomanisationRules.First(r => r.Initial == Syllable.Initial).Romanisation;
        }

        private string RomaniseMedial(KoreanSyllable Syllable)
        {
            return MedialRomanisationRules.First(r => r.Medial == Syllable.Medial).Romanisation;
        }
                
        private string RomaniseFinal(KoreanSyllable Syllable, KoreanSyllable? PrecedingSyllable, KoreanSyllable? SucceedingSyllable)
        {
            if (Syllable.HasFinal)
            {
                if (SucceedingSyllable != null)
                {
                    var PronunciationChangeRomanisationRule = FinalPronunciationChangeRomanisationRules.FirstOrDefault(r => r.Final == Syllable.Final && r.SucceedingInitial == SucceedingSyllable.Value.Initial);

                    if (PronunciationChangeRomanisationRule != null)
                    {
                        return PronunciationChangeRomanisationRule.Romanisation;
                    }
                }

                return FinalRomanisationRules.First(r => r.Final == Syllable.Final).Romanisation;
            }

            return "";
        }

        public override string RomaniseLetter(KoreanLetter Letter)
        {
            throw new NotImplementedException();
        }
    }
}
