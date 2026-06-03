using Hiero.Reference.Contract;
using Hiero.Reference.Core;
using Hiero.Reference.File;

using System;

namespace Hiero.Reference.System
{
    /// <summary>
    /// Undelete a file or smart contract that was deleted by SystemDelete; requires a Hedera
    /// administrative multisignature.
    /// </summary>
    public interface ISystemUndeleteTransaction : ITransaction
    {
        IFileId IFileId { get; }
        IContractId ContractId { get; }
        NodaTime.Instant ExpirationTime { get; }
    }
}
