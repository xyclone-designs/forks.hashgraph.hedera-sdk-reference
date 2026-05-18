using Hiero.Reference.Core;
using Hiero.Reference.Fee;

using System.Collections.Generic;

namespace Hiero.Reference.Token
{
    public interface ITokenFeeScheduleUpdateTransaction : ITransaction
    {
        ITokenId? TokenId { get; }
        IList<ICustomFee> CustomFees { get; }
    }
}
