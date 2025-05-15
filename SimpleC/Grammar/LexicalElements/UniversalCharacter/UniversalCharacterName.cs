using SimpleC.Base.Standard;
using SimpleC.Code;
using SimpleC.Code.Attribute;

namespace SimpleC.Grammar.LexicalElements.UniversalCharacter
{
    [Grammar(Name = "universal-character-name (base)",
             Description = "(base) universal-character-name: (2 variants)",
             Section = ISOCStandardAnnexSection.A_1,
             SubSection = ISOCStandardAnnexSubSection.A_1_4,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_4_3)]
    public abstract class UniversalCharacterName : GrammarBase
    {
        public UniversalCharacterName(CodeRefBase codeRef) : base(codeRef) { }
    }

    [Grammar(Name = "universal-character-name (variant 1)",
             Description = "universal-character-name: \\u hex-quad",
             Section = ISOCStandardAnnexSection.A_1,
             SubSection = ISOCStandardAnnexSubSection.A_1_4,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_4_3)]
    public class UniversalCharacterName_V1 : GrammarBase
    {
        public const string UnicodePrefix = GrammarCEscapeSequences.UnicodePrefix1;
        public HexQuad HexQuad;

        public UniversalCharacterName_V1(CodeRefBase codeRef) : base(codeRef) { }
    }

    [Grammar(Name = "universal-character-name (variant 2)",
             Description = "universal-character-name: \\U hex-quad hex-quad",
             Section = ISOCStandardAnnexSection.A_1,
             SubSection = ISOCStandardAnnexSubSection.A_1_4,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_4_3)]
    public class UniversalCharacterName_V2 : GrammarBase
    {
        public const string UnicodePrefix = GrammarCEscapeSequences.UnicodePrefix2;
        public HexQuad HexQuad1;
        public HexQuad HexQuad2;

        public UniversalCharacterName_V2(CodeRefBase codeRef) : base(codeRef) { }
    }
}
