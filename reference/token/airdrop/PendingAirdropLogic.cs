using Hiero.Reference.Core;

using System.Collections.Generic;

namespace Hiero.Reference.Token.Airdrop
{
    public interface IPendingAirdropLogic : ITransaction
    {
        IList<IPendingAirdropId> PendingAirdropIds { get; }
    }
}
