// SPDX-License-Identifier: Apache-2.0
using Hiero.Reference.Cryptocurrency;

namespace Hiero.Reference
{
    public interface ITransfer
    {
        IAccountId AccountId { get; }
        IHbar Amount { get; }
    }
}
