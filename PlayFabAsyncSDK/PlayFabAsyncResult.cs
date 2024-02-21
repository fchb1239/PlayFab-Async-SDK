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

        if (IsError)
        {
            UnityEngine.Debug.LogError($"{e.Error}: {e.ErrorMessage}");
            if (e.ErrorDetails != null)
            {
                foreach (var kv in e.ErrorDetails)
                {
                    foreach (var v in kv.Value)
                    {
                        UnityEngine.Debug.LogError(v);
                    }
                }
            }
        }
    }
}