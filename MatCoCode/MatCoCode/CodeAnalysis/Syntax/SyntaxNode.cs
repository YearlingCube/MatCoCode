using System.Collections.Generic;

namespace MatCoCode.CodeAnalysis
{
    public abstract class SyntaxNode
    {
        public abstract SyntaxKind Kind { get; }

        abstract public IEnumerable<SyntaxNode> GetChildren();
    }
}
