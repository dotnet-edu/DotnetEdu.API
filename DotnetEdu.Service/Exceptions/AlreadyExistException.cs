namespace DotnetEdu.Service.Exceptions;

public class AlreadyExistException
{
    public AlreadyExistException() { }
    public AlreadyExistException(string message) : base(message) { }
    public AlreadyExistException(string message, Exception exception) { }

    public int StatusCode => 409;
}
