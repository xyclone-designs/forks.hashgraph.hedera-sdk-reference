using Hiero.Reference.Core;

using System;

namespace Hiero.Reference.Token.Airdrop
{
    public interface ITokenAirdropTransaction : IAbstractTokenTransferTransaction<ITokenAirdropTransaction>
    {
        static ITransaction ITransaction.FromBytes(byte[] data) => throw new NotImplementedException();
    }
}
