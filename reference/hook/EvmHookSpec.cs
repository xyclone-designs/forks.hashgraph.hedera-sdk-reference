using Hiero.Reference.Contract;

namespace Hiero.Reference.Hook
{
    public interface IEvmHookSpec
    {
        IContractId ContractId { get; }
    }
    public interface IEvmHookSpec<TSelf> : IEvmHookSpec where TSelf : IEvmHookSpec<TSelf>
    {
        abstract static TSelf CTOR(IContractId ContractId);
    }
}
