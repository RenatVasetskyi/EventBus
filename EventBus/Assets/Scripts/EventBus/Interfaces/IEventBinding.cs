using System;

namespace EventBus.Interfaces
{
    public interface IEventBinding<T>
    {
        public Action<T> OnEvent { get; set; }
        public Action OnEventNoArgs { get; set; }
    }
}