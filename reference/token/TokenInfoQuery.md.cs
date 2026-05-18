using Hiero.Reference.Core;

namespace Hiero.Reference.Token
{
    public interface ITokenInfoQuery : IQuery<ITokenInfo>
    {
        ITokenId TokenId { get; }
    }
}
