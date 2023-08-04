# PlayFab Async SDK
The PlayFab SDK, but async.
Async functions are way easier to read and understand, and from my experience they are also more robust.
PlayFabServerAPI and PlayFabClientAPI both support async functions too, so it's logical that it should exist for the client SDK.

Therefore, I made a codegen (software that generates code) that turned the PlayFabClientAPI into PlayFabAsyncClientAPI.
However, you still need the normal SDK installed for this to function correctly.

# Documentation
The difference between making an API request with the regular PlayFab SDK and the Async SDK is rather simple.
Instead of using the callbacks/delegates, you just simply call the async function, and await it.
```cs
var result = await PlayFabAsyncClientAPI.LoginWithCustomIDAsync(new LoginWithCustomIDRequest
{
    CustomId = "My-Custom-Id",
    CreateAccount = true
});
```

After it's done, you can get data from the result.
```cs
if (result.IsError)
{
    Debug.LogError("Oh no! Something went wrong when trying to login. "  + result.Error.ErrorMessage);
}
else
{
    Debug.Log("Hurray! It all went according to plan! Logged in as " + loginResult.Result.PlayFabId);
}
```
