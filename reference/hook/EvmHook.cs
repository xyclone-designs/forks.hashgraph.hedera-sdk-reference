using Hiero.Reference.Contract;

using System.Collections.Generic;

namespace Hiero.Reference.Hook
{
    public interface IEvmHook : IEvmHookSpec
    {
        IReadOnlyList<IEvmHookStorageUpdate> StorageUpdates { get; }
    }
    public interface IEvmHook<TSelf> : IEvmHook, IEvmHookSpec<TSelf> where TSelf : IEvmHook<TSelf>
    {
        abstract static TSelf CTOR(IContractId contractId, IReadOnlyList<IEvmHookStorageUpdate> evmHookStorageUpdates);
    }
}
