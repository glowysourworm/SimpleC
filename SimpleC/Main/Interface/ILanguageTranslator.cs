using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleC.Main.Interface
{
    public interface ILanguageTranslator
    {
        // 1) Preprocessor:  compiles preprocessor directives, substitutes headers, and removes comments
        // 2) Compiler:      produces assembler for all C code
        // 3) Assembler:     Produces machine code for asm, blocks of which have translatable addresses (all indexed at 0)
        // 4) Linker:        Produces final output (translation units)
    }
}
