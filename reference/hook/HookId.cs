using System;

namespace Hiero.Reference.Hook
{
    public interface IHookId { }
    public interface IHookId<TSelf> : IHookId where TSelf : IHookId<TSelf> { }
}
