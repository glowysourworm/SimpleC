using SimpleC.Base.Standard;
using SimpleC.Code;
using SimpleC.Code.Attribute;

namespace SimpleC.Grammar.LexicalElements.Constants
{
    [Grammar(Name = "character-constant (base)",
             Description = "character-constant: (2 variants)",
             Section = ISOCStandardAnnexSection.A_1,
             SubSection = ISOCStandardAnnexSubSection.A_1_5,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_4_4_3)]
    public abstract class CharacterConstant : GrammarBase
    {
        public CharacterConstant(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "character-constant (variant 1)",
             Description = "character-constant: ' c-char-sequence '",
             Section = ISOCStandardAnnexSection.A_1,
             SubSection = ISOCStandardAnnexSubSection.A_1_5,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_4_4_4)]
    public class CharacterConstant_V1 : CharacterConstant
    {
        const char PrefixApostrophe1 = GrammarCConstants.SingleQuote;
        public CCharSequence CCharSequence;
        const char PostfixApostrophe1 = GrammarCConstants.SingleQuote;

        public CharacterConstant_V1(CodeRefBase codeRef) : base(codeRef) 
        {
        }
    }

    [Grammar(Name = "character-constant (variant 2)",
             Description = "character-constant: L' c-char-sequence '",
             Section = ISOCStandardAnnexSection.A_1,
             SubSection = ISOCStandardAnnexSubSection.A_1_5,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_4_4_4)]
    public class CharacterConstant_V2 : Constant
    {
        const char PrefixLiteralConstant = GrammarCConstants.Letter_L;
        const char PrefixApostrophe2 = GrammarCConstants.SingleQuote;
        CCharSequence CCharSequence;
        const char PostfixApostrophe2 = GrammarCConstants.SingleQuote;

        public CharacterConstant_V2(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }
}
