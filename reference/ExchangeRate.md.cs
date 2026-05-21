using System;

namespace Hiero.Reference
{
    public interface IExchangeRate
    {
        IHbar IHbars { get; }
        int Cents { get; }
        NodaTime.Instant ExpirationTime { get; }
    }
}
