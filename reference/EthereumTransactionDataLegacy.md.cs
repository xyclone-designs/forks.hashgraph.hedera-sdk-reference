namespace Hiero.Reference
{
    public interface IEthereumTransactionDataLegacy : IEthereumTransactionData
    {
        byte[] Nonce { get; }
        byte[] GasPrice { get; }
        byte[] GasLimit { get; }
        byte[] To { get; }
        byte[] Value { get; }
        byte[] V { get; }
        byte[] R { get; }
        byte[] S { get; }
    }
}
