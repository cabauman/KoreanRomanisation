﻿using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KoreanRomanisation
{
    /// <summary>
    /// A base class for classes that can romanise Korean text according to their own internal romanisation rules.
    /// </summary>
    public abstract class Romanisation : IRomanisation
    {
        #region Properties

        public bool PreserveNonKoreanText { get; set; }
        public bool UseSh { get; set; }
        public bool UseOi { get; set; }

        protected IEnumerable<InitialRomanisationRule> InitialRomanisationRules;
        protected IEnumerable<InitialPronunciationChangeRomanisationRule> InitialPronunciationChangeRomanisationRules;

        protected IEnumerable<MedialRomanisationRule> MedialRomanisationRules;

        protected IEnumerable<FinalRomanisationRule> FinalRomanisationRules;
        protected IEnumerable<FinalPronunciationChangeRomanisationRule> FinalPronunciationChangeRomanisationRules;

        #endregion

        #region Constructors

        public Romanisation()
        {
            PreserveNonKoreanText = true;
            UseSh = true;
            UseOi = false;
        }

        /// <summary>
        /// Sets the rules of the romanisation system. In this library, romanisation rules are hard-coded, since they rarely change - this function is where they are set.
        /// </summary>
        protected abstract void SetRules();

        #endregion

        #region Romanisation Functions

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

                    if (NonKoreanTextSection1.Content != "")
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

            if (NonKoreanTextSection1.Content != "")
            {
                TextBlock1.TextSections.Add(NonKoreanTextSection1);
            }

            if (KoreanTextSection1.Syllables.Any())
            {
                TextBlock1.TextSections.Add(KoreanTextSection1);
            }

            return TextBlock1;
        }

        /// <summary>
        /// Returns whether or not the given letter is an 'i' medial, which is useful for romanising the letters shiot and ssangshiot.
        /// </summary>
        /// <param name="Letter"></param>
        /// <returns></returns>
        protected bool IsIMedial(KoreanLetter Letter)
        {
            var IMedials = new List<KoreanLetter>() { KoreanLetter.I, KoreanLetter.Ya, KoreanLetter.Yae, KoreanLetter.Yeo, KoreanLetter.Ye, KoreanLetter.Yo, KoreanLetter.Yu };

            return IMedials.Any(m => m == Letter);
        }

        public string RomaniseText(string Text)
        {
            var TextBlock1 = GetTextBlock(Text);

            return RomaniseTextBlock(TextBlock1);
        }

        public string RomaniseTextBlock(TextBlock TextBlock1)
        {
            var StringBuilder1 = new StringBuilder();

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

                            var RomanisedText = "";

                            if (i > 0)
                            {
                                PrecedingSyllable = Syllables[i - 1];
                            }
                            else if (i < Syllables.Length - 1)
                            {
                                SucceedingSyllable = Syllables[i + 1];
                            }

                            RomanisedText = RomaniseSyllable(Syllable, PrecedingSyllable, SucceedingSyllable);

                            StringBuilder1.Append(RomanisedText);
                        }
                    }
                    else if (Syllables.Length == 1)
                    {
                        var RomanisedText = RomaniseSyllable(Syllables[0]);

                        StringBuilder1.Append(RomanisedText);
                    }
                }
                else if (TextSection is NonKoreanTextSection)
                {
                    var Content = (TextSection as NonKoreanTextSection).Content;

                    StringBuilder1.Append(Content);
                }
            }

            return StringBuilder1.ToString();
        }

        public abstract string RomaniseSyllable(KoreanSyllable Syllable, KoreanSyllable? PrecedingSyllable = null, KoreanSyllable? SucceedingSyllable = null);
        public abstract string RomaniseLetter(KoreanLetter Letter);

        #endregion
    }
}
