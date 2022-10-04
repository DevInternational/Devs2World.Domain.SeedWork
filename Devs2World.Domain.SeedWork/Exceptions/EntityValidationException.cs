using Devs2World.Domain.SeedWork.Validations;

namespace Devs2World.Domain.SeedWork.Exceptions;

public class EntityValidationException : DomainException
{
    public IReadOnlyCollection<ValidationError>? Errors { get; }

    public EntityValidationException(
        string? message,
        IReadOnlyCollection<ValidationError>? errors = null
    ) : base(message)
        => Errors = errors;
}
