using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleC.Grammar.LexicalElements.Constants
{
    public class IntegerConstant : GrammarBase
    {
        DecimalConstant _decimalConstant1;
        IntegerSuffix _integerSuffix1;

        OctalConstant _octalConstant2;
        IntegerSuffix _integerSuffix2;

        HexadecimalConstant _hexadecimalConstant3;
        IntegerSuffix _integerSuffix3;

        public DecimalConstant DecimalConstant1
        {
            get { return _decimalConstant1; }
            set { this.RaiseAndSetIfChanged(ref _decimalConstant1, value); }
        }
        public IntegerSuffix IntegerSuffix1
        {
            get { return _integerSuffix1; }
            set { this.RaiseAndSetIfChanged(ref _integerSuffix1, value); }
        }
        public OctalConstant OctalConstant2
        {
            get { return _octalConstant2; }
            set { this.RaiseAndSetIfChanged(ref _octalConstant2, value); }
        }
        public IntegerSuffix IntegerSuffix2
        {
            get { return _integerSuffix2; }
            set { this.RaiseAndSetIfChanged(ref _integerSuffix2, value); }
        }
        public HexadecimalConstant HexadecimalConstant3
        {
            get { return _hexadecimalConstant3; }
            set { this.RaiseAndSetIfChanged(ref _hexadecimalConstant3, value); }
        }
        public IntegerSuffix IntegerSuffix3
        {
            get { return _integerSuffix3; }
            set { this.RaiseAndSetIfChanged(ref _integerSuffix3, value); }
        }

        public IntegerConstant()
        {
            this.DecimalConstant1 = new DecimalConstant();
            this.OctalConstant2 = new OctalConstant();
            this.HexadecimalConstant3 = new HexadecimalConstant();
            this.IntegerSuffix1 = new IntegerSuffix();
            this.IntegerSuffix2 = new IntegerSuffix();
            this.IntegerSuffix3 = new IntegerSuffix();
        }
    }
}
