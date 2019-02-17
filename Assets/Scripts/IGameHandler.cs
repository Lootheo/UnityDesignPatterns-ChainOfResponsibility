
public interface IGameHandler
{
    object Handle(object request);
    IGameHandler SetNext(IGameHandler nextHandler);
}