
namespace Hiero.Reference.Hook
{
    public interface IHookCall
    {
        byte[] Data { get; }
        ulong GasLimit { get; }
    }
    public interface IHookCall<TSelf> : IHookCall where TSelf : IHookCall<TSelf>
    {
        abstract static TSelf CTOR(byte[] data, ulong gasLimit);
    }
}
