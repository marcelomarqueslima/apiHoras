using System;

namespace ApiHorasDomain.Shared
{
    public abstract class EntityBase<T>
    {
        public virtual T Id { get; set; }
    }
}
