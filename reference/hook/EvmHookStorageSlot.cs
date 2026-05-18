using Hiero.Reference.Contract;

namespace Hiero.Reference.Hook
{
    public interface IEvmHookStorageSlot : IEvmHookStorageUpdate
    {
        byte[] Key { get; }
        byte[] Value { get; }
    }
    public interface IEvmHookStorageSlot<TSelf> : IEvmHookStorageSlot, IEvmHookStorageUpdate<TSelf> where TSelf : IEvmHookStorageSlot<TSelf>
    {
        abstract static TSelf CTOR(byte[] key, byte[]? value);
    }
}
