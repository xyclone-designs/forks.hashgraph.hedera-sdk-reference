using Hiero.Reference.Core;
using Hiero.Reference.Cryptocurrency;

namespace Hiero.Reference.LiveHash
{
    public interface ILiveHashDeleteTransaction : ITransaction
    {
        IAccountId AccountId { get; }
        byte[] Hash { get; }
    }
}
