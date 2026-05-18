using Hiero.Reference.Cryptocurrency;
using Hiero.Reference.Token.Nft;

namespace Hiero.Reference.Token.Airdrop
{
    public interface IPendingAirdropId
    {
        IAccountId Sender { get; set; }
        IAccountId Receiver { get; set; }
        ITokenId? TokenId { get; set; }
        INftId? NftId { get; set; }
    }
    public interface IPendingAirdropId<TSelf> : IPendingAirdropId where TSelf : IPendingAirdropId<TSelf>
    {
        abstract static TSelf CTOR(IAccountId sender, IAccountId receiver, ITokenId tokenId);
        abstract static TSelf CTOR(IAccountId sender, IAccountId receiver, INftId nftId);
    }
}
