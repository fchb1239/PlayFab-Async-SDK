using PlayFab.ClientModels;
using System.Threading.Tasks;
using UnityEngine;

public class AsyncLoginExample : MonoBehaviour
{
    async void Start()
    {
        await Login();
    }

    // A function to login. createAccount is set to true by default
    public async Task Login(bool createAccount = true)
    {
        string customId = SystemInfo.deviceUniqueIdentifier; // ID to login with

        // Request to PlayFab using the async API
        var result = await PlayFabAsyncClientAPI.LoginWithCustomIDAsync(new LoginWithCustomIDRequest
        {
            CustomId = customId,
            CreateAccount = createAccount
        });

        // Handle error
        if (result.IsError)
        {
            Debug.LogError("Failed to login: " + result.Error.ErrorMessage);
            return;
        }

        // If we successfully logged in

        Debug.Log("Logged in as: " + result.Result.PlayFabId);

        // Do something
    }
}
