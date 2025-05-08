using SimpleC.Base;

namespace SimpleC.Lexer
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
        readonly ScopeBlock _parentBlock;
        ScopeBlock? _childBlock;

        readonly string _raw;
        ScopeBlockType _type;

        public ScopeBlock ParentBlock { get { return _parentBlock; } }
        public ScopeBlock? ChildBlock
        {
            get { return _childBlock; }
            set { this.RaiseAndSetIfChanged(ref _childBlock, value); }
        }

        public string Raw { get { return _raw; } }
        public ScopeBlockType Type
        {
            get { return _type; }
            set { this.RaiseAndSetIfChanged(ref _type, value); }
        }

        public ScopeBlock(ScopeBlock parentBlock, string raw, ScopeBlockType type)
        {
            _parentBlock = parentBlock;
            _childBlock = null;
            _raw = raw;
            _type = type;
        }
    }
}
