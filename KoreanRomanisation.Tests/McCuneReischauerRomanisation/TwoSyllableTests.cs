﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace KoreanRomanisation.Tests.McCuneReischauerRomanisation
{
    public class TwoSyllableTests
    {
        private readonly KoreanRomanisation.McCuneReischauerRomanisation McCuneReischauerRomanisation1;

        public TwoSyllableTests()
        {
            McCuneReischauerRomanisation1 = new KoreanRomanisation.McCuneReischauerRomanisation();
        }

        [Theory]
        [InlineData("아", "a")]
        [InlineData("어", "ŏ")]
        [InlineData("이", "i")]
        [InlineData("애", "ae")]
        [InlineData("에", "e")]
        [InlineData("오", "o")]
        [InlineData("우", "u")]
        [InlineData("으", "ŭ")]
        [InlineData("야", "ya")]
        [InlineData("여", "yŏ")]
        [InlineData("얘", "yae")]
        [InlineData("예", "ye")]
        [InlineData("요", "yo")]
        [InlineData("유", "yu")]
        [InlineData("와", "wa")]
        [InlineData("워", "wŏ")]
        [InlineData("왜", "wae")]
        [InlineData("웨", "we")]
        [InlineData("외", "oe")]
        [InlineData("의", "ŭi")]
        [InlineData("위", "wi")]
        [InlineData("아에", "aë")]
        [InlineData("오에", "oë")]
        [InlineData("가", "ka")]
        [InlineData("까", "kka")]
        [InlineData("나", "na")]
        [InlineData("다", "ta")]
        [InlineData("따", "tta")]
        [InlineData("라", "ra")]
        [InlineData("마", "ma")]
        [InlineData("바", "pa")]
        [InlineData("빠", "ppa")]
        [InlineData("사", "sa")]
        [InlineData("싸", "ssa")]
        [InlineData("자", "cha")]
        [InlineData("짜", "tcha")]
        [InlineData("차", "ch'a")]
        [InlineData("카", "k'a")]
        [InlineData("타", "t'a")]
        [InlineData("파", "p'a")]
        [InlineData("하", "ha")]
        [InlineData("각", "kak")]
        [InlineData("갂", "kak")]
        [InlineData("간", "kan")]
        [InlineData("갇", "kat")]
        [InlineData("갈", "kal")]
        [InlineData("감", "kam")]
        [InlineData("갑", "kap")]
        [InlineData("갓", "kat")]
        [InlineData("갔", "kat")]
        [InlineData("강", "kang")]
        [InlineData("갖", "kat")]
        [InlineData("갗", "kat")]
        [InlineData("갘", "kak")]
        [InlineData("같", "kat")]
        [InlineData("갚", "kap")]
        [InlineData("갛", "kat")]
        [InlineData("각가", "kakka")]
        [InlineData("갂가", "kakka")]
        [InlineData("간가", "kan'ga")]
        [InlineData("갇가", "katka")]
        [InlineData("갈가", "kalga")]
        [InlineData("감가", "kamga")]
        [InlineData("갑가", "kapka")]
        [InlineData("갓가", "katka")]
        [InlineData("갔가", "katka")]
        [InlineData("강가", "kangga")]
        [InlineData("갖가", "katka")]
        [InlineData("갗가", "katka")]
        [InlineData("갘가", "kakka")]
        [InlineData("같가", "katka")]
        [InlineData("갚가", "kapka")]
        [InlineData("갛가", "katka")]
        [InlineData("각까", "kakka")]
        [InlineData("갂까", "kakka")]
        [InlineData("간까", "kankka")]
        [InlineData("갇까", "katkka")]
        [InlineData("갈까", "kalkka")]
        [InlineData("감까", "kamkka")]
        [InlineData("갑까", "kapkka")]
        [InlineData("갓까", "katkka")]
        [InlineData("갔까", "katkka")]
        [InlineData("강까", "kangkka")]
        [InlineData("갖까", "katkka")]
        [InlineData("갗까", "katkka")]
        [InlineData("갘까", "kakka")]
        [InlineData("같까", "katkka")]
        [InlineData("갚까", "kapkka")]
        [InlineData("갛까", "katkka")]
        [InlineData("각나", "kangna")]
        [InlineData("갂나", "kangna")]
        [InlineData("간나", "kanna")]
        [InlineData("갇나", "kanna")]
        [InlineData("갈나", "kalla")]
        [InlineData("감나", "kamna")]
        [InlineData("갑나", "kamna")]
        [InlineData("갓나", "kanna")]
        [InlineData("갔나", "kanna")]
        [InlineData("강나", "kangna")]
        [InlineData("갖나", "kanna")]
        [InlineData("갗나", "kanna")]
        [InlineData("갘나", "kangna")]
        [InlineData("같나", "kanna")]
        [InlineData("갚나", "kamna")]
        [InlineData("갛나", "kanna")]
        [InlineData("각다", "kakta")]
        [InlineData("갂다", "kakta")]
        [InlineData("간다", "kanda")]
        [InlineData("갇다", "katta")]
        [InlineData("갈다", "kalda")]
        [InlineData("감다", "kamda")]
        [InlineData("갑다", "kapta")]
        [InlineData("갓다", "katta")]
        [InlineData("갔다", "katta")]
        [InlineData("강다", "kangda")]
        [InlineData("갖다", "katta")]
        [InlineData("갗다", "katta")]
        [InlineData("갘다", "kakta")]
        [InlineData("같다", "katta")]
        [InlineData("갚다", "kapta")]
        [InlineData("갛다", "katta")]
        [InlineData("각따", "kaktta")]
        [InlineData("갂따", "kaktta")]
        [InlineData("간따", "kantta")]
        [InlineData("갇따", "katta")]
        [InlineData("갈따", "kaltta")]
        [InlineData("감따", "kamtta")]
        [InlineData("갑따", "kaptta")]
        [InlineData("갓따", "katta")]
        [InlineData("갔따", "katta")]
        [InlineData("강따", "kangtta")]
        [InlineData("갖따", "katta")]
        [InlineData("갗따", "katta")]
        [InlineData("갘따", "kaktta")]
        [InlineData("같따", "katta")]
        [InlineData("갚따", "kaptta")]
        [InlineData("갛따", "katta")]
        [InlineData("각라", "kangna")]
        [InlineData("갂라", "kangna")]
        [InlineData("간라", "kalla")]
        [InlineData("갇라", "kanna")]
        [InlineData("갈라", "kalla")]
        [InlineData("감라", "kamna")]
        [InlineData("갑라", "kamna")]
        [InlineData("갓라", "kanna")]
        [InlineData("갔라", "kanna")]
        [InlineData("강라", "kangna")]
        [InlineData("갖라", "kanna")]
        [InlineData("갗라", "kanna")]
        [InlineData("갘라", "kangna")]
        [InlineData("같라", "kanna")]
        [InlineData("갚라", "kamna")]
        [InlineData("갛라", "kanna")]
        [InlineData("각마", "kangma")]
        [InlineData("갂마", "kangma")]
        [InlineData("간마", "kanma")]
        [InlineData("갇마", "kanma")]
        [InlineData("갈마", "kalma")]
        [InlineData("감마", "kamma")]
        [InlineData("갑마", "kamma")]
        [InlineData("갓마", "kanma")]
        [InlineData("갔마", "kanma")]
        [InlineData("강마", "kangma")]
        [InlineData("갖마", "kanma")]
        [InlineData("갗마", "kanma")]
        [InlineData("갘마", "kangma")]
        [InlineData("같마", "kanma")]
        [InlineData("갚마", "kamma")]
        [InlineData("갛마", "kanma")]
        [InlineData("각바", "kakpa")]
        [InlineData("갂바", "kakpa")]
        [InlineData("간바", "kanba")]
        [InlineData("갇바", "katpa")]
        [InlineData("갈바", "kalba")]
        [InlineData("감바", "kamba")]
        [InlineData("갑바", "kappa")]
        [InlineData("갓바", "katpa")]
        [InlineData("갔바", "katpa")]
        [InlineData("강바", "kangba")]
        [InlineData("갖바", "katpa")]
        [InlineData("갗바", "katpa")]
        [InlineData("갘바", "kakpa")]
        [InlineData("같바", "katpa")]
        [InlineData("갚바", "kappa")]
        [InlineData("갛바", "katpa")]
        [InlineData("각빠", "kakppa")]
        [InlineData("갂빠", "kakppa")]
        [InlineData("간빠", "kanppa")]
        [InlineData("갇빠", "katppa")]
        [InlineData("갈빠", "kalppa")]
        [InlineData("감빠", "kamppa")]
        [InlineData("갑빠", "kappa")]
        [InlineData("갓빠", "katppa")]
        [InlineData("갔빠", "katppa")]
        [InlineData("강빠", "kangppa")]
        [InlineData("갖빠", "katppa")]
        [InlineData("갗빠", "katppa")]
        [InlineData("갘빠", "kakppa")]
        [InlineData("같빠", "katppa")]
        [InlineData("갚빠", "kappa")]
        [InlineData("갛빠", "katppa")]
        [InlineData("각사", "kaksa")]
        [InlineData("갂사", "kaksa")]
        [InlineData("간사", "kansa")]
        [InlineData("갇사", "katsa")]
        [InlineData("갈사", "kalsa")]
        [InlineData("감사", "kamsa")]
        [InlineData("갑사", "kapsa")]
        [InlineData("갓사", "kassa")]
        [InlineData("갔사", "kassa")]
        [InlineData("강사", "kangsa")]
        [InlineData("갖사", "katsa")]
        [InlineData("갗사", "katsa")]
        [InlineData("갘사", "kaksa")]
        [InlineData("같사", "katsa")]
        [InlineData("갚사", "kapsa")]
        [InlineData("갛사", "katsa")]
        [InlineData("각싸", "kakssa")]
        [InlineData("갂싸", "kakssa")]
        [InlineData("간싸", "kanssa")]
        [InlineData("갇싸", "katssa")]
        [InlineData("갈싸", "kalssa")]
        [InlineData("감싸", "kamssa")]
        [InlineData("갑싸", "kapssa")]
        [InlineData("갓싸", "kassa")]
        [InlineData("갔싸", "kassa")]
        [InlineData("강싸", "kangssa")]
        [InlineData("갖싸", "katssa")]
        [InlineData("갗싸", "katssa")]
        [InlineData("갘싸", "kakssa")]
        [InlineData("같싸", "katssa")]
        [InlineData("갚싸", "kapssa")]
        [InlineData("갛싸", "katssa")]
        [InlineData("각아", "kaga")]
        [InlineData("갂아", "kakka")]
        [InlineData("간아", "kana")]
        [InlineData("갇아", "kada")]
        [InlineData("갈아", "kara")]
        [InlineData("감아", "kama")]
        [InlineData("갑아", "kaba")]
        [InlineData("갓아", "kasa")]
        [InlineData("갔아", "kassa")]
        [InlineData("강아", "kang'a")]
        [InlineData("갖아", "kaja")]
        [InlineData("갗아", "kach'a")]
        [InlineData("갘아", "kak'a")]
        [InlineData("같아", "kat'a")]
        [InlineData("갚아", "kap'a")]
        [InlineData("갛아", "kaha")]
        [InlineData("각자", "kakcha")]
        [InlineData("갂자", "kakcha")]
        [InlineData("간자", "kanja")]
        [InlineData("갇자", "katcha")]
        [InlineData("갈자", "kalja")]
        [InlineData("감자", "kamja")]
        [InlineData("갑자", "kapcha")]
        [InlineData("갓자", "katcha")]
        [InlineData("갔자", "katcha")]
        [InlineData("강자", "kangja")]
        [InlineData("갖자", "katcha")]
        [InlineData("갗자", "katcha")]
        [InlineData("갘자", "kakcha")]
        [InlineData("같자", "katcha")]
        [InlineData("갚자", "kapcha")]
        [InlineData("갛자", "katcha")]
        [InlineData("각짜", "kaktcha")]
        [InlineData("갂짜", "kaktcha")]
        [InlineData("간짜", "kantcha")]
        [InlineData("갇짜", "katcha")]
        [InlineData("갈짜", "kaltcha")]
        [InlineData("감짜", "kamtcha")]
        [InlineData("갑짜", "kaptcha")]
        [InlineData("갓짜", "katcha")]
        [InlineData("갔짜", "katcha")]
        [InlineData("강짜", "kangtcha")]
        [InlineData("갖짜", "katcha")]
        [InlineData("갗짜", "katcha")]
        [InlineData("갘짜", "kaktcha")]
        [InlineData("같짜", "katcha")]
        [InlineData("갚짜", "kaptcha")]
        [InlineData("갛짜", "katcha")]
        [InlineData("각차", "kakch'a")]
        [InlineData("갂차", "kakch'a")]
        [InlineData("간차", "kanch'a")]
        [InlineData("갇차", "katch'a")]
        [InlineData("갈차", "kalch'a")]
        [InlineData("감차", "kamch'a")]
        [InlineData("갑차", "kapch'a")]
        [InlineData("갓차", "katch'a")]
        [InlineData("갔차", "katch'a")]
        [InlineData("강차", "kangch'a")]
        [InlineData("갖차", "katch'a")]
        [InlineData("갗차", "katch'a")]
        [InlineData("갘차", "kakch'a")]
        [InlineData("같차", "katch'a")]
        [InlineData("갚차", "kapch'a")]
        [InlineData("갛차", "katch'a")]
        [InlineData("각카", "kakk'a")]
        [InlineData("갂카", "kakk'a")]
        [InlineData("간카", "kank'a")]
        [InlineData("갇카", "katk'a")]
        [InlineData("갈카", "kalk'a")]
        [InlineData("감카", "kamk'a")]
        [InlineData("갑카", "kapk'a")]
        [InlineData("갓카", "katk'a")]
        [InlineData("갔카", "katk'a")]
        [InlineData("강카", "kangk'a")]
        [InlineData("갖카", "katk'a")]
        [InlineData("갗카", "katk'a")]
        [InlineData("갘카", "kakk'a")]
        [InlineData("같카", "katk'a")]
        [InlineData("갚카", "kapk'a")]
        [InlineData("갛카", "katk'a")]
        [InlineData("각타", "kakt'a")]
        [InlineData("갂타", "kakt'a")]
        [InlineData("간타", "kant'a")]
        [InlineData("갇타", "katt'a")]
        [InlineData("갈타", "kalt'a")]
        [InlineData("감타", "kamt'a")]
        [InlineData("갑타", "kapt'a")]
        [InlineData("갓타", "katt'a")]
        [InlineData("갔타", "katt'a")]
        [InlineData("강타", "kangt'a")]
        [InlineData("갖타", "katt'a")]
        [InlineData("갗타", "katt'a")]
        [InlineData("갘타", "kakt'a")]
        [InlineData("같타", "katt'a")]
        [InlineData("갚타", "kapt'a")]
        [InlineData("갛타", "katt'a")]
        [InlineData("각파", "kakp'a")]
        [InlineData("갂파", "kakp'a")]
        [InlineData("간파", "kanp'a")]
        [InlineData("갇파", "katp'a")]
        [InlineData("갈파", "kalp'a")]
        [InlineData("감파", "kamp'a")]
        [InlineData("갑파", "kapp'a")]
        [InlineData("갓파", "katp'a")]
        [InlineData("갔파", "katp'a")]
        [InlineData("강파", "kangp'a")]
        [InlineData("갖파", "katp'a")]
        [InlineData("갗파", "katp'a")]
        [InlineData("갘파", "kakp'a")]
        [InlineData("같파", "katp'a")]
        [InlineData("갚파", "kapp'a")]
        [InlineData("갛파", "katp'a")]
        [InlineData("각하", "kakha")]
        [InlineData("갂하", "kakha")]
        [InlineData("간하", "kanha")]
        [InlineData("갇하", "katha")]
        [InlineData("갈하", "karha")]
        [InlineData("감하", "kamha")]
        [InlineData("갑하", "kapha")]
        [InlineData("갓하", "katha")]
        [InlineData("갔하", "katha")]
        [InlineData("강하", "kangha")]
        [InlineData("갖하", "katha")]
        [InlineData("갗하", "katha")]
        [InlineData("갘하", "kakha")]
        [InlineData("같하", "katha")]
        [InlineData("갚하", "kapha")]
        [InlineData("갛하", "katha")]
        public void Romanise(string Korean, string Romanisation)
        {
            Assert.Equal(Romanisation, McCuneReischauerRomanisation1.Romanise(Korean));
        }
    }
}