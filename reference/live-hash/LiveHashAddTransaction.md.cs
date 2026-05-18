using Hiero.Reference.Core;
using Hiero.Reference.Cryptocurrency;
using Hiero.Reference.Cryptography;

using System;

namespace Hiero.Reference.LiveHash
{
    public interface ILiveHashAddTransaction : ITransaction
    {
        IAccountId AccountId { get; }
        byte[] Hash { get; }
        IKeyList Keys { get; }
        TimeSpan TimeSpan { get; }
    }
}
