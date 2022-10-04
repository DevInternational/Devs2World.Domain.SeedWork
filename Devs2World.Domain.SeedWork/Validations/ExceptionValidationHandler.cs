using Devs2World.Domain.SeedWork.Exceptions;

namespace Devs2World.Domain.SeedWork.Validations;

public class ExceptionValidationHandler : ValidationHandler
{
    public override void HandleError(ValidationError error) => throw new EntityValidationException(error.Message);
}