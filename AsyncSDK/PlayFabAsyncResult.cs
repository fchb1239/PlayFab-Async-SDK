using PlayFab;

public class PlayFabAsyncResult<T>
{
    public bool IsError { get { return Error != null; } }
    public T Result;
    public PlayFabError Error;

    public PlayFabAsyncResult(T r, PlayFabError e)
    {
        Result = r;
        Error = e;
    }
}