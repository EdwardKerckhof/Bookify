namespace Bookify.Application.Exceptions;

public class ValidationException : Exception
{
    public IEnumerable<ValidationError> Errors { get; }

    public ValidationException(List<ValidationError> errors)
    {
        Errors = errors;
    }
}