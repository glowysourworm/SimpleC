using SimpleC.Base.Standard;
using SimpleC.Code;
using SimpleC.Code.Attribute;

namespace SimpleC.Grammar.PhraseStructureGrammar.Declarations
{
    [Grammar(Name = "storage-class-specifier",
             Description = "storage-class-specifier: one of (...)",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_2,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_7_1)]
    public class StorageClassSpecifier : GrammarConstant
    {
        // One of:  typedef, extern, static, auto, register
        public StorageClassSpecifier(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }
}
