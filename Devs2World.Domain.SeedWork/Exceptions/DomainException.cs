using System.Runtime.Serialization;

namespace Devs2World.Domain.SeedWork.Exceptions;

public abstract class DomainException : Exception
{
    protected DomainException() {}

    protected DomainException(string? message) : base(message) {}

    protected DomainException(SerializationInfo info, StreamingContext context) : base(info, context) {}

    protected DomainException(string? message, Exception? innerException) : base(message, innerException) {}
}
