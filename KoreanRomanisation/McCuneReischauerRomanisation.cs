﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoreanRomanisation
{
    public sealed class McCuneReischauerRomanisation : Romanisation
    {
        private InitialRomanisationRule[] InitialRomanisationRules;
        private InitialPronunciationChangeRomanisationRule[] InitialPronunciationChangesRomanisationRules;
        private MedialRomanisationRule[] MedialRomanisationRules;
        private FinalRomanisationRule[] FinalRomanisationRules;
        private FinalPronunciationChangeRomanisationRule[] FinalPronunciationChangesRomanisationRules;

        public McCuneReischauerRomanisation()
        {
            InitialRomanisationRules = new InitialRomanisationRule[] {
                new InitialRomanisationRule(Jamo.Giyeok, "k"),
                new InitialRomanisationRule(Jamo.SsangGiyeok, "kk"),
                new InitialRomanisationRule(Jamo.Nieun, "n"),
                new InitialRomanisationRule(Jamo.Digeut, "t"),
                new InitialRomanisationRule(Jamo.SsangDigeut, "tt"),
                new InitialRomanisationRule(Jamo.Rieul, "r"),
                new InitialRomanisationRule(Jamo.Mieum, "m"),
                new InitialRomanisationRule(Jamo.Bieup, "p"),
                new InitialRomanisationRule(Jamo.SsangBieup, "pp"),
                new InitialRomanisationRule(Jamo.Shiot, "s"),
                new InitialRomanisationRule(Jamo.SsangShiot, "ss"),
                new InitialRomanisationRule(Jamo.Ieung, ""),
                new InitialRomanisationRule(Jamo.Jieut, "ch"),
                new InitialRomanisationRule(Jamo.SsangJieut, "tch"),
                new InitialRomanisationRule(Jamo.Chieut, "ch'"),
                new InitialRomanisationRule(Jamo.Kieuk, "k'"),
                new InitialRomanisationRule(Jamo.Tieut, "t'"),
                new InitialRomanisationRule(Jamo.Pieup, "p'"),
                new InitialRomanisationRule(Jamo.Hieut, "h")
            };

            InitialPronunciationChangesRomanisationRules = new InitialPronunciationChangeRomanisationRule[]  {
                new InitialPronunciationChangeRomanisationRule ( Jamo.GiyeokBatchim, Jamo.Rieul, "n" ),
                new InitialPronunciationChangeRomanisationRule ( Jamo.NieunBatchim, Jamo.Giyeok, "'g" ),
                new InitialPronunciationChangeRomanisationRule ( Jamo.NieunBatchim, Jamo.Digeut, "d" ),
                new InitialPronunciationChangeRomanisationRule ( Jamo.NieunBatchim, Jamo.Rieul, "l" ),
                new InitialPronunciationChangeRomanisationRule ( Jamo.NieunBatchim, Jamo.Bieup, "b" ),
                new InitialPronunciationChangeRomanisationRule ( Jamo.NieunBatchim, Jamo.Jieut, "j" ),
                new InitialPronunciationChangeRomanisationRule ( Jamo.RieulBatchim, Jamo.Giyeok, "g" ),
                new InitialPronunciationChangeRomanisationRule ( Jamo.RieulBatchim, Jamo.Nieun, "l" ),
                new InitialPronunciationChangeRomanisationRule ( Jamo.RieulBatchim, Jamo.Digeut, "d" ),
                new InitialPronunciationChangeRomanisationRule ( Jamo.RieulBatchim, Jamo.Rieul, "l" ),
                new InitialPronunciationChangeRomanisationRule ( Jamo.RieulBatchim, Jamo.Bieup, "b" ),
                new InitialPronunciationChangeRomanisationRule ( Jamo.RieulBatchim, Jamo.Jieut, "j" ),
                new InitialPronunciationChangeRomanisationRule ( Jamo.MieumBatchim, Jamo.Giyeok, "g" ),
                new InitialPronunciationChangeRomanisationRule ( Jamo.MieumBatchim, Jamo.Digeut, "d" ),
                new InitialPronunciationChangeRomanisationRule ( Jamo.MieumBatchim, Jamo.Rieul, "n" ),
                new InitialPronunciationChangeRomanisationRule ( Jamo.MieumBatchim, Jamo.Bieup, "b" ),
                new InitialPronunciationChangeRomanisationRule ( Jamo.MieumBatchim, Jamo.Jieut, "j" ),
                new InitialPronunciationChangeRomanisationRule ( Jamo.BieupBatchim, Jamo.Rieul, "n" ),
                new InitialPronunciationChangeRomanisationRule ( Jamo.IeungBatchim, Jamo.Giyeok, "g" ),
                new InitialPronunciationChangeRomanisationRule ( Jamo.IeungBatchim, Jamo.Digeut, "d" ),
                new InitialPronunciationChangeRomanisationRule ( Jamo.IeungBatchim, Jamo.Rieul, "n" ),
                new InitialPronunciationChangeRomanisationRule ( Jamo.IeungBatchim, Jamo.Bieup, "b" ),
                new InitialPronunciationChangeRomanisationRule ( Jamo.IeungBatchim, Jamo.Jieut, "j" ) };

            MedialRomanisationRules = new MedialRomanisationRule[] {
                new MedialRomanisationRule(Jamo.A, "a"),
                new MedialRomanisationRule(Jamo.Ae, "ae"),
                new MedialRomanisationRule(Jamo.Ya, "ya"),
                new MedialRomanisationRule(Jamo.Yae, "yae"),
                new MedialRomanisationRule(Jamo.Eo, "ŏ"),
                new MedialRomanisationRule(Jamo.E, "e"),
                new MedialRomanisationRule(Jamo.Yeo, "yŏ"),
                new MedialRomanisationRule(Jamo.Ye, "ye"),
                new MedialRomanisationRule(Jamo.O, "o"),
                new MedialRomanisationRule(Jamo.Wa, "wa"),
                new MedialRomanisationRule(Jamo.Wae, "wae"),
                new MedialRomanisationRule(Jamo.Oe, "oe"),
                new MedialRomanisationRule(Jamo.Yo, "yo"),
                new MedialRomanisationRule(Jamo.U, "u"),
                new MedialRomanisationRule(Jamo.Wo, "wŏ"),
                new MedialRomanisationRule(Jamo.We, "we"),
                new MedialRomanisationRule(Jamo.Wi, "wi"),
                new MedialRomanisationRule(Jamo.Yu, "yu"),
                new MedialRomanisationRule(Jamo.Eu, "ŭ"),
                new MedialRomanisationRule(Jamo.Ui, "ŭi"),
                new MedialRomanisationRule(Jamo.I, "i")
            };

            FinalRomanisationRules = new FinalRomanisationRule[] {
                new FinalRomanisationRule(Jamo.GiyeokBatchim, "k"),
                new FinalRomanisationRule(Jamo.SsangGiyeokBatchim, "k"),
                new FinalRomanisationRule(Jamo.NieunBatchim, "n"),
                new FinalRomanisationRule(Jamo.DigeutBatchim, "t"),
                new FinalRomanisationRule(Jamo.RieulBatchim, "l"),
                new FinalRomanisationRule(Jamo.MieumBatchim, "m"),
                new FinalRomanisationRule(Jamo.BieupBatchim, "p"),
                new FinalRomanisationRule(Jamo.ShiotBatchim, "t"),
                new FinalRomanisationRule(Jamo.SsangShiotBatchim, "t"),
                new FinalRomanisationRule(Jamo.IeungBatchim, "ng"),
                new FinalRomanisationRule(Jamo.JieutBatchim, "t"),
                new FinalRomanisationRule(Jamo.ChieutBatchim, "t"),
                new FinalRomanisationRule(Jamo.KieukBatchim, "k"),
                new FinalRomanisationRule(Jamo.TieutBatchim, "t"),
                new FinalRomanisationRule(Jamo.PieupBatchim, "p"),
                new FinalRomanisationRule(Jamo.HieutBatchim, "t")
            };

            FinalPronunciationChangesRomanisationRules = new FinalPronunciationChangeRomanisationRule[] {

                new FinalPronunciationChangeRomanisationRule ( Jamo.GiyeokBatchim, Jamo.Ieung, "g" ),
                new FinalPronunciationChangeRomanisationRule ( Jamo.GiyeokBatchim, Jamo.Nieun, "ng" ),
                new FinalPronunciationChangeRomanisationRule ( Jamo.GiyeokBatchim, Jamo.Mieum, "ng" ),
                new FinalPronunciationChangeRomanisationRule ( Jamo.NieunBatchim, Jamo.Rieul, "l" ),
                new FinalPronunciationChangeRomanisationRule ( Jamo.RieulBatchim, Jamo.Ieung, "r" ),
                new FinalPronunciationChangeRomanisationRule ( Jamo.RieulBatchim, Jamo.Hieut, "r" ),
                new FinalPronunciationChangeRomanisationRule ( Jamo.BieupBatchim, Jamo.Ieung, "b" ),
                new FinalPronunciationChangeRomanisationRule ( Jamo.BieupBatchim, Jamo.Nieun, "m" ),
                new FinalPronunciationChangeRomanisationRule ( Jamo.BieupBatchim, Jamo.Rieul, "m" ),
                new FinalPronunciationChangeRomanisationRule ( Jamo.BieupBatchim, Jamo.Mieum, "m" )
            };

        }

        public override string Romanise(Syllable Syllable1, Syllable? PrecedingSyllable = null, Syllable? SucceedingSyllable = null)
        {
            var StringBuilder1 = new StringBuilder();

            StringBuilder1.Append(RomaniseInitial(Syllable1, PrecedingSyllable, SucceedingSyllable));
            StringBuilder1.Append(RomaniseMedial(Syllable1, PrecedingSyllable, SucceedingSyllable));
            StringBuilder1.Append(RomaniseFinal(Syllable1, PrecedingSyllable, SucceedingSyllable));

            return StringBuilder1.ToString();
        }

        private string RomaniseInitial(Syllable Syllable1, Syllable? PrecedingSyllable, Syllable? SucceedingSyllable)
        {
            if (PrecedingSyllable != null)
            {
                if (InitialPronunciationChangesRomanisationRules.Any(c => c.PrecedingFinal == PrecedingSyllable.Value.Final && c.Initial == Syllable1.Initial))
                {
                    return InitialPronunciationChangesRomanisationRules.First(c => c.PrecedingFinal == PrecedingSyllable.Value.Final && c.Initial == Syllable1.Initial).Romanisation;
                }
            }

            if (PrecedingSyllable == null)
            {
                var IsIMedial = (Syllable1.Medial == Jamo.I || Syllable1.Medial == Jamo.Ya || Syllable1.Medial == Jamo.Yae || Syllable1.Medial == Jamo.Yeo || Syllable1.Medial == Jamo.Ye || Syllable1.Medial == Jamo.Yo || Syllable1.Medial == Jamo.Yu);

                if (UseSh && Syllable1.Initial == Jamo.Shiot && IsIMedial)
                {
                    return "sh";
                }
                if (UseSh && Syllable1.Initial == Jamo.SsangShiot && IsIMedial)
                {
                    return "ssh";
                }
            }

            return InitialRomanisationRules.First(r => r.Initial == Syllable1.Initial).Romanisation;
        }

        private string RomaniseMedial(Syllable Syllable1, Syllable? PrecedingSyllable, Syllable? SucceedingSyllable)
        {
            if (PrecedingSyllable != null && (PrecedingSyllable.Value.Medial == Jamo.A || PrecedingSyllable.Value.Medial == Jamo.O) && !PrecedingSyllable.Value.HasFinal && Syllable1.Initial == Jamo.Ieung && Syllable1.Medial == Jamo.E)
            {
                return "ë";
            }

            return MedialRomanisationRules.First(m => m.Jamo == Syllable1.Medial).Romanisation;
        }

        private string RomaniseFinal(Syllable Syllable1, Syllable? PrecedingSyllable, Syllable? SucceedingSyllable)
        {
            if (Syllable1.HasFinal)
            {
                if (SucceedingSyllable != null)
                {
                    if (FinalPronunciationChangesRomanisationRules.Any(c => c.Final == Syllable1.Final && c.SucceedingInitial == SucceedingSyllable.Value.Initial))
                    {
                        return FinalPronunciationChangesRomanisationRules.First(c => c.Final == Syllable1.Final && c.SucceedingInitial == SucceedingSyllable.Value.Initial).Romanisation;

                    }
                }

                return FinalRomanisationRules.First(f => f.Final == Syllable1.Final).Romanisation;
            }

            return "";
        }

        public override string Romanise(Jamo Jamo1)
        {
            throw new NotImplementedException();
        }
    }
}
