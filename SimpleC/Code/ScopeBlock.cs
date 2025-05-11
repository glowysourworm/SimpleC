using SimpleC.Base;

namespace SimpleC.Code
{
    public enum ScopeBlockType
    {
        TopLevel = 0,
        Declaration,
        Body
    }

    /// <summary>
    /// This defines a block of the lexigraphical scope. The nested recursion will show 
    /// child blocks. These are defined with the Lexer components as they are parsed.
    /// </summary>
    public class ScopeBlock : ModelBase
    {
        readonly ScopeBlock? _parentBlock;
        ScopeBlock? _childBlock;

        readonly string _raw;
        ScopeBlockType _type;
        CodeString _code;

        public ScopeBlock? ParentBlock { get { return _parentBlock; } }
        public ScopeBlock? ChildBlock
        {
            get { return _childBlock; }
            set { RaiseAndSetIfChanged(ref _childBlock, value); }
        }

        public string Raw { get { return _raw; } }
        public ScopeBlockType Type
        {
            get { return _type; }
            set { RaiseAndSetIfChanged(ref _type, value); }
        }
        public CodeString Code
        {
            get { return _code; }
            set { this.RaiseAndSetIfChanged(ref _code, value); }
        }

        public ScopeBlock(ScopeBlock? parentBlock, string raw, ScopeBlockType type)
        {
            _parentBlock = parentBlock;
            _childBlock = null;
            _raw = raw;
            _code = new CodeString(raw);        // Trims the raw input
            _type = type;
        }
    }
}
