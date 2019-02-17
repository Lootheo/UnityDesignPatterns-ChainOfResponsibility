using UnityEngine;
/// <summary>
/// To use, inherit from it and implement the handle method.
/// </summary>
public abstract class GameHandler : MonoBehaviour, IGameHandler
{
    IGameHandler _nextHandler;

    public IGameHandler SetNext(IGameHandler handler)
    {
        this._nextHandler = handler;
        return handler;
    }
    public virtual object Handle(object request)
    {
        if (this._nextHandler != null)
        {
            return this._nextHandler.Handle(request);
        }
        else
        {
            return null;
        }
    }
}