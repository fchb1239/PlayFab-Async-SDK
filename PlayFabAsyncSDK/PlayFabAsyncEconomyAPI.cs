using System.Collections.Generic;
using System.Threading.Tasks;
using PlayFab;
using PlayFab.EconomyModels;

public class PlayFabAsyncEconomyAPI
{
    public static Task<PlayFabAsyncResult<AddInventoryItemsResponse>> AddInventoryItemsAsync(AddInventoryItemsRequest request, object customData = null, Dictionary<string, string> extraHeaders = null)
    {
        TaskCompletionSource<PlayFabAsyncResult<AddInventoryItemsResponse>> tcs = new TaskCompletionSource<PlayFabAsyncResult<AddInventoryItemsResponse>>();

        PlayFabEconomyAPI.AddInventoryItems(request, result =>
        {
            tcs.TrySetResult(new PlayFabAsyncResult<AddInventoryItemsResponse>(result, null));
        }, error =>
        {
            tcs.TrySetResult(new PlayFabAsyncResult<AddInventoryItemsResponse>(null, error));
        }, customData, extraHeaders);

        return tcs.Task;
    }
    public static Task<PlayFabAsyncResult<CreateDraftItemResponse>> CreateDraftItemAsync(CreateDraftItemRequest request, object customData = null, Dictionary<string, string> extraHeaders = null)
    {
        TaskCompletionSource<PlayFabAsyncResult<CreateDraftItemResponse>> tcs = new TaskCompletionSource<PlayFabAsyncResult<CreateDraftItemResponse>>();

        PlayFabEconomyAPI.CreateDraftItem(request, result =>
        {
            tcs.TrySetResult(new PlayFabAsyncResult<CreateDraftItemResponse>(result, null));
        }, error =>
        {
            tcs.TrySetResult(new PlayFabAsyncResult<CreateDraftItemResponse>(null, error));
        }, customData, extraHeaders);

        return tcs.Task;
    }
    public static Task<PlayFabAsyncResult<CreateUploadUrlsResponse>> CreateUploadUrlsAsync(CreateUploadUrlsRequest request, object customData = null, Dictionary<string, string> extraHeaders = null)
    {
        TaskCompletionSource<PlayFabAsyncResult<CreateUploadUrlsResponse>> tcs = new TaskCompletionSource<PlayFabAsyncResult<CreateUploadUrlsResponse>>();

        PlayFabEconomyAPI.CreateUploadUrls(request, result =>
        {
            tcs.TrySetResult(new PlayFabAsyncResult<CreateUploadUrlsResponse>(result, null));
        }, error =>
        {
            tcs.TrySetResult(new PlayFabAsyncResult<CreateUploadUrlsResponse>(null, error));
        }, customData, extraHeaders);

        return tcs.Task;
    }
    public static Task<PlayFabAsyncResult<DeleteEntityItemReviewsResponse>> DeleteEntityItemReviewsAsync(DeleteEntityItemReviewsRequest request, object customData = null, Dictionary<string, string> extraHeaders = null)
    {
        TaskCompletionSource<PlayFabAsyncResult<DeleteEntityItemReviewsResponse>> tcs = new TaskCompletionSource<PlayFabAsyncResult<DeleteEntityItemReviewsResponse>>();

        PlayFabEconomyAPI.DeleteEntityItemReviews(request, result =>
        {
            tcs.TrySetResult(new PlayFabAsyncResult<DeleteEntityItemReviewsResponse>(result, null));
        }, error =>
        {
            tcs.TrySetResult(new PlayFabAsyncResult<DeleteEntityItemReviewsResponse>(null, error));
        }, customData, extraHeaders);

        return tcs.Task;
    }
    public static Task<PlayFabAsyncResult<DeleteInventoryCollectionResponse>> DeleteInventoryCollectionAsync(DeleteInventoryCollectionRequest request, object customData = null, Dictionary<string, string> extraHeaders = null)
    {
        TaskCompletionSource<PlayFabAsyncResult<DeleteInventoryCollectionResponse>> tcs = new TaskCompletionSource<PlayFabAsyncResult<DeleteInventoryCollectionResponse>>();

        PlayFabEconomyAPI.DeleteInventoryCollection(request, result =>
        {
            tcs.TrySetResult(new PlayFabAsyncResult<DeleteInventoryCollectionResponse>(result, null));
        }, error =>
        {
            tcs.TrySetResult(new PlayFabAsyncResult<DeleteInventoryCollectionResponse>(null, error));
        }, customData, extraHeaders);

        return tcs.Task;
    }
    public static Task<PlayFabAsyncResult<DeleteInventoryItemsResponse>> DeleteInventoryItemsAsync(DeleteInventoryItemsRequest request, object customData = null, Dictionary<string, string> extraHeaders = null)
    {
        TaskCompletionSource<PlayFabAsyncResult<DeleteInventoryItemsResponse>> tcs = new TaskCompletionSource<PlayFabAsyncResult<DeleteInventoryItemsResponse>>();

        PlayFabEconomyAPI.DeleteInventoryItems(request, result =>
        {
            tcs.TrySetResult(new PlayFabAsyncResult<DeleteInventoryItemsResponse>(result, null));
        }, error =>
        {
            tcs.TrySetResult(new PlayFabAsyncResult<DeleteInventoryItemsResponse>(null, error));
        }, customData, extraHeaders);

        return tcs.Task;
    }
    public static Task<PlayFabAsyncResult<DeleteItemResponse>> DeleteItemAsync(DeleteItemRequest request, object customData = null, Dictionary<string, string> extraHeaders = null)
    {
        TaskCompletionSource<PlayFabAsyncResult<DeleteItemResponse>> tcs = new TaskCompletionSource<PlayFabAsyncResult<DeleteItemResponse>>();

        PlayFabEconomyAPI.DeleteItem(request, result =>
        {
            tcs.TrySetResult(new PlayFabAsyncResult<DeleteItemResponse>(result, null));
        }, error =>
        {
            tcs.TrySetResult(new PlayFabAsyncResult<DeleteItemResponse>(null, error));
        }, customData, extraHeaders);

        return tcs.Task;
    }
    public static Task<PlayFabAsyncResult<ExecuteInventoryOperationsResponse>> ExecuteInventoryOperationsAsync(ExecuteInventoryOperationsRequest request, object customData = null, Dictionary<string, string> extraHeaders = null)
    {
        TaskCompletionSource<PlayFabAsyncResult<ExecuteInventoryOperationsResponse>> tcs = new TaskCompletionSource<PlayFabAsyncResult<ExecuteInventoryOperationsResponse>>();

        PlayFabEconomyAPI.ExecuteInventoryOperations(request, result =>
        {
            tcs.TrySetResult(new PlayFabAsyncResult<ExecuteInventoryOperationsResponse>(result, null));
        }, error =>
        {
            tcs.TrySetResult(new PlayFabAsyncResult<ExecuteInventoryOperationsResponse>(null, error));
        }, customData, extraHeaders);

        return tcs.Task;
    }
    public static Task<PlayFabAsyncResult<GetCatalogConfigResponse>> GetCatalogConfigAsync(GetCatalogConfigRequest request, object customData = null, Dictionary<string, string> extraHeaders = null)
    {
        TaskCompletionSource<PlayFabAsyncResult<GetCatalogConfigResponse>> tcs = new TaskCompletionSource<PlayFabAsyncResult<GetCatalogConfigResponse>>();

        PlayFabEconomyAPI.GetCatalogConfig(request, result =>
        {
            tcs.TrySetResult(new PlayFabAsyncResult<GetCatalogConfigResponse>(result, null));
        }, error =>
        {
            tcs.TrySetResult(new PlayFabAsyncResult<GetCatalogConfigResponse>(null, error));
        }, customData, extraHeaders);

        return tcs.Task;
    }
    public static Task<PlayFabAsyncResult<GetDraftItemResponse>> GetDraftItemAsync(GetDraftItemRequest request, object customData = null, Dictionary<string, string> extraHeaders = null)
    {
        TaskCompletionSource<PlayFabAsyncResult<GetDraftItemResponse>> tcs = new TaskCompletionSource<PlayFabAsyncResult<GetDraftItemResponse>>();

        PlayFabEconomyAPI.GetDraftItem(request, result =>
        {
            tcs.TrySetResult(new PlayFabAsyncResult<GetDraftItemResponse>(result, null));
        }, error =>
        {
            tcs.TrySetResult(new PlayFabAsyncResult<GetDraftItemResponse>(null, error));
        }, customData, extraHeaders);

        return tcs.Task;
    }
    public static Task<PlayFabAsyncResult<GetDraftItemsResponse>> GetDraftItemsAsync(GetDraftItemsRequest request, object customData = null, Dictionary<string, string> extraHeaders = null)
    {
        TaskCompletionSource<PlayFabAsyncResult<GetDraftItemsResponse>> tcs = new TaskCompletionSource<PlayFabAsyncResult<GetDraftItemsResponse>>();

        PlayFabEconomyAPI.GetDraftItems(request, result =>
        {
            tcs.TrySetResult(new PlayFabAsyncResult<GetDraftItemsResponse>(result, null));
        }, error =>
        {
            tcs.TrySetResult(new PlayFabAsyncResult<GetDraftItemsResponse>(null, error));
        }, customData, extraHeaders);

        return tcs.Task;
    }
    public static Task<PlayFabAsyncResult<GetEntityDraftItemsResponse>> GetEntityDraftItemsAsync(GetEntityDraftItemsRequest request, object customData = null, Dictionary<string, string> extraHeaders = null)
    {
        TaskCompletionSource<PlayFabAsyncResult<GetEntityDraftItemsResponse>> tcs = new TaskCompletionSource<PlayFabAsyncResult<GetEntityDraftItemsResponse>>();

        PlayFabEconomyAPI.GetEntityDraftItems(request, result =>
        {
            tcs.TrySetResult(new PlayFabAsyncResult<GetEntityDraftItemsResponse>(result, null));
        }, error =>
        {
            tcs.TrySetResult(new PlayFabAsyncResult<GetEntityDraftItemsResponse>(null, error));
        }, customData, extraHeaders);

        return tcs.Task;
    }
    public static Task<PlayFabAsyncResult<GetEntityItemReviewResponse>> GetEntityItemReviewAsync(GetEntityItemReviewRequest request, object customData = null, Dictionary<string, string> extraHeaders = null)
    {
        TaskCompletionSource<PlayFabAsyncResult<GetEntityItemReviewResponse>> tcs = new TaskCompletionSource<PlayFabAsyncResult<GetEntityItemReviewResponse>>();

        PlayFabEconomyAPI.GetEntityItemReview(request, result =>
        {
            tcs.TrySetResult(new PlayFabAsyncResult<GetEntityItemReviewResponse>(result, null));
        }, error =>
        {
            tcs.TrySetResult(new PlayFabAsyncResult<GetEntityItemReviewResponse>(null, error));
        }, customData, extraHeaders);

        return tcs.Task;
    }
    public static Task<PlayFabAsyncResult<GetInventoryCollectionIdsResponse>> GetInventoryCollectionIdsAsync(GetInventoryCollectionIdsRequest request, object customData = null, Dictionary<string, string> extraHeaders = null)
    {
        TaskCompletionSource<PlayFabAsyncResult<GetInventoryCollectionIdsResponse>> tcs = new TaskCompletionSource<PlayFabAsyncResult<GetInventoryCollectionIdsResponse>>();

        PlayFabEconomyAPI.GetInventoryCollectionIds(request, result =>
        {
            tcs.TrySetResult(new PlayFabAsyncResult<GetInventoryCollectionIdsResponse>(result, null));
        }, error =>
        {
            tcs.TrySetResult(new PlayFabAsyncResult<GetInventoryCollectionIdsResponse>(null, error));
        }, customData, extraHeaders);

        return tcs.Task;
    }
    public static Task<PlayFabAsyncResult<GetInventoryItemsResponse>> GetInventoryItemsAsync(GetInventoryItemsRequest request, object customData = null, Dictionary<string, string> extraHeaders = null)
    {
        TaskCompletionSource<PlayFabAsyncResult<GetInventoryItemsResponse>> tcs = new TaskCompletionSource<PlayFabAsyncResult<GetInventoryItemsResponse>>();

        PlayFabEconomyAPI.GetInventoryItems(request, result =>
        {
            tcs.TrySetResult(new PlayFabAsyncResult<GetInventoryItemsResponse>(result, null));
        }, error =>
        {
            tcs.TrySetResult(new PlayFabAsyncResult<GetInventoryItemsResponse>(null, error));
        }, customData, extraHeaders);

        return tcs.Task;
    }
    public static Task<PlayFabAsyncResult<GetItemResponse>> GetItemAsync(GetItemRequest request, object customData = null, Dictionary<string, string> extraHeaders = null)
    {
        TaskCompletionSource<PlayFabAsyncResult<GetItemResponse>> tcs = new TaskCompletionSource<PlayFabAsyncResult<GetItemResponse>>();

        PlayFabEconomyAPI.GetItem(request, result =>
        {
            tcs.TrySetResult(new PlayFabAsyncResult<GetItemResponse>(result, null));
        }, error =>
        {
            tcs.TrySetResult(new PlayFabAsyncResult<GetItemResponse>(null, error));
        }, customData, extraHeaders);

        return tcs.Task;
    }
    public static Task<PlayFabAsyncResult<GetItemContainersResponse>> GetItemContainersAsync(GetItemContainersRequest request, object customData = null, Dictionary<string, string> extraHeaders = null)
    {
        TaskCompletionSource<PlayFabAsyncResult<GetItemContainersResponse>> tcs = new TaskCompletionSource<PlayFabAsyncResult<GetItemContainersResponse>>();

        PlayFabEconomyAPI.GetItemContainers(request, result =>
        {
            tcs.TrySetResult(new PlayFabAsyncResult<GetItemContainersResponse>(result, null));
        }, error =>
        {
            tcs.TrySetResult(new PlayFabAsyncResult<GetItemContainersResponse>(null, error));
        }, customData, extraHeaders);

        return tcs.Task;
    }
    public static Task<PlayFabAsyncResult<GetItemModerationStateResponse>> GetItemModerationStateAsync(GetItemModerationStateRequest request, object customData = null, Dictionary<string, string> extraHeaders = null)
    {
        TaskCompletionSource<PlayFabAsyncResult<GetItemModerationStateResponse>> tcs = new TaskCompletionSource<PlayFabAsyncResult<GetItemModerationStateResponse>>();

        PlayFabEconomyAPI.GetItemModerationState(request, result =>
        {
            tcs.TrySetResult(new PlayFabAsyncResult<GetItemModerationStateResponse>(result, null));
        }, error =>
        {
            tcs.TrySetResult(new PlayFabAsyncResult<GetItemModerationStateResponse>(null, error));
        }, customData, extraHeaders);

        return tcs.Task;
    }
    public static Task<PlayFabAsyncResult<GetItemPublishStatusResponse>> GetItemPublishStatusAsync(GetItemPublishStatusRequest request, object customData = null, Dictionary<string, string> extraHeaders = null)
    {
        TaskCompletionSource<PlayFabAsyncResult<GetItemPublishStatusResponse>> tcs = new TaskCompletionSource<PlayFabAsyncResult<GetItemPublishStatusResponse>>();

        PlayFabEconomyAPI.GetItemPublishStatus(request, result =>
        {
            tcs.TrySetResult(new PlayFabAsyncResult<GetItemPublishStatusResponse>(result, null));
        }, error =>
        {
            tcs.TrySetResult(new PlayFabAsyncResult<GetItemPublishStatusResponse>(null, error));
        }, customData, extraHeaders);

        return tcs.Task;
    }
    public static Task<PlayFabAsyncResult<GetItemReviewsResponse>> GetItemReviewsAsync(GetItemReviewsRequest request, object customData = null, Dictionary<string, string> extraHeaders = null)
    {
        TaskCompletionSource<PlayFabAsyncResult<GetItemReviewsResponse>> tcs = new TaskCompletionSource<PlayFabAsyncResult<GetItemReviewsResponse>>();

        PlayFabEconomyAPI.GetItemReviews(request, result =>
        {
            tcs.TrySetResult(new PlayFabAsyncResult<GetItemReviewsResponse>(result, null));
        }, error =>
        {
            tcs.TrySetResult(new PlayFabAsyncResult<GetItemReviewsResponse>(null, error));
        }, customData, extraHeaders);

        return tcs.Task;
    }
    public static Task<PlayFabAsyncResult<GetItemReviewSummaryResponse>> GetItemReviewSummaryAsync(GetItemReviewSummaryRequest request, object customData = null, Dictionary<string, string> extraHeaders = null)
    {
        TaskCompletionSource<PlayFabAsyncResult<GetItemReviewSummaryResponse>> tcs = new TaskCompletionSource<PlayFabAsyncResult<GetItemReviewSummaryResponse>>();

        PlayFabEconomyAPI.GetItemReviewSummary(request, result =>
        {
            tcs.TrySetResult(new PlayFabAsyncResult<GetItemReviewSummaryResponse>(result, null));
        }, error =>
        {
            tcs.TrySetResult(new PlayFabAsyncResult<GetItemReviewSummaryResponse>(null, error));
        }, customData, extraHeaders);

        return tcs.Task;
    }
    public static Task<PlayFabAsyncResult<GetItemsResponse>> GetItemsAsync(GetItemsRequest request, object customData = null, Dictionary<string, string> extraHeaders = null)
    {
        TaskCompletionSource<PlayFabAsyncResult<GetItemsResponse>> tcs = new TaskCompletionSource<PlayFabAsyncResult<GetItemsResponse>>();

        PlayFabEconomyAPI.GetItems(request, result =>
        {
            tcs.TrySetResult(new PlayFabAsyncResult<GetItemsResponse>(result, null));
        }, error =>
        {
            tcs.TrySetResult(new PlayFabAsyncResult<GetItemsResponse>(null, error));
        }, customData, extraHeaders);

        return tcs.Task;
    }
    public static Task<PlayFabAsyncResult<GetMicrosoftStoreAccessTokensResponse>> GetMicrosoftStoreAccessTokensAsync(GetMicrosoftStoreAccessTokensRequest request, object customData = null, Dictionary<string, string> extraHeaders = null)
    {
        TaskCompletionSource<PlayFabAsyncResult<GetMicrosoftStoreAccessTokensResponse>> tcs = new TaskCompletionSource<PlayFabAsyncResult<GetMicrosoftStoreAccessTokensResponse>>();

        PlayFabEconomyAPI.GetMicrosoftStoreAccessTokens(request, result =>
        {
            tcs.TrySetResult(new PlayFabAsyncResult<GetMicrosoftStoreAccessTokensResponse>(result, null));
        }, error =>
        {
            tcs.TrySetResult(new PlayFabAsyncResult<GetMicrosoftStoreAccessTokensResponse>(null, error));
        }, customData, extraHeaders);

        return tcs.Task;
    }
    public static Task<PlayFabAsyncResult<GetTransactionHistoryResponse>> GetTransactionHistoryAsync(GetTransactionHistoryRequest request, object customData = null, Dictionary<string, string> extraHeaders = null)
    {
        TaskCompletionSource<PlayFabAsyncResult<GetTransactionHistoryResponse>> tcs = new TaskCompletionSource<PlayFabAsyncResult<GetTransactionHistoryResponse>>();

        PlayFabEconomyAPI.GetTransactionHistory(request, result =>
        {
            tcs.TrySetResult(new PlayFabAsyncResult<GetTransactionHistoryResponse>(result, null));
        }, error =>
        {
            tcs.TrySetResult(new PlayFabAsyncResult<GetTransactionHistoryResponse>(null, error));
        }, customData, extraHeaders);

        return tcs.Task;
    }
    public static Task<PlayFabAsyncResult<PublishDraftItemResponse>> PublishDraftItemAsync(PublishDraftItemRequest request, object customData = null, Dictionary<string, string> extraHeaders = null)
    {
        TaskCompletionSource<PlayFabAsyncResult<PublishDraftItemResponse>> tcs = new TaskCompletionSource<PlayFabAsyncResult<PublishDraftItemResponse>>();

        PlayFabEconomyAPI.PublishDraftItem(request, result =>
        {
            tcs.TrySetResult(new PlayFabAsyncResult<PublishDraftItemResponse>(result, null));
        }, error =>
        {
            tcs.TrySetResult(new PlayFabAsyncResult<PublishDraftItemResponse>(null, error));
        }, customData, extraHeaders);

        return tcs.Task;
    }
    public static Task<PlayFabAsyncResult<PurchaseInventoryItemsResponse>> PurchaseInventoryItemsAsync(PurchaseInventoryItemsRequest request, object customData = null, Dictionary<string, string> extraHeaders = null)
    {
        TaskCompletionSource<PlayFabAsyncResult<PurchaseInventoryItemsResponse>> tcs = new TaskCompletionSource<PlayFabAsyncResult<PurchaseInventoryItemsResponse>>();

        PlayFabEconomyAPI.PurchaseInventoryItems(request, result =>
        {
            tcs.TrySetResult(new PlayFabAsyncResult<PurchaseInventoryItemsResponse>(result, null));
        }, error =>
        {
            tcs.TrySetResult(new PlayFabAsyncResult<PurchaseInventoryItemsResponse>(null, error));
        }, customData, extraHeaders);

        return tcs.Task;
    }
    public static Task<PlayFabAsyncResult<RedeemAppleAppStoreInventoryItemsResponse>> RedeemAppleAppStoreInventoryItemsAsync(RedeemAppleAppStoreInventoryItemsRequest request, object customData = null, Dictionary<string, string> extraHeaders = null)
    {
        TaskCompletionSource<PlayFabAsyncResult<RedeemAppleAppStoreInventoryItemsResponse>> tcs = new TaskCompletionSource<PlayFabAsyncResult<RedeemAppleAppStoreInventoryItemsResponse>>();

        PlayFabEconomyAPI.RedeemAppleAppStoreInventoryItems(request, result =>
        {
            tcs.TrySetResult(new PlayFabAsyncResult<RedeemAppleAppStoreInventoryItemsResponse>(result, null));
        }, error =>
        {
            tcs.TrySetResult(new PlayFabAsyncResult<RedeemAppleAppStoreInventoryItemsResponse>(null, error));
        }, customData, extraHeaders);

        return tcs.Task;
    }
    public static Task<PlayFabAsyncResult<RedeemGooglePlayInventoryItemsResponse>> RedeemGooglePlayInventoryItemsAsync(RedeemGooglePlayInventoryItemsRequest request, object customData = null, Dictionary<string, string> extraHeaders = null)
    {
        TaskCompletionSource<PlayFabAsyncResult<RedeemGooglePlayInventoryItemsResponse>> tcs = new TaskCompletionSource<PlayFabAsyncResult<RedeemGooglePlayInventoryItemsResponse>>();

        PlayFabEconomyAPI.RedeemGooglePlayInventoryItems(request, result =>
        {
            tcs.TrySetResult(new PlayFabAsyncResult<RedeemGooglePlayInventoryItemsResponse>(result, null));
        }, error =>
        {
            tcs.TrySetResult(new PlayFabAsyncResult<RedeemGooglePlayInventoryItemsResponse>(null, error));
        }, customData, extraHeaders);

        return tcs.Task;
    }
    public static Task<PlayFabAsyncResult<RedeemMicrosoftStoreInventoryItemsResponse>> RedeemMicrosoftStoreInventoryItemsAsync(RedeemMicrosoftStoreInventoryItemsRequest request, object customData = null, Dictionary<string, string> extraHeaders = null)
    {
        TaskCompletionSource<PlayFabAsyncResult<RedeemMicrosoftStoreInventoryItemsResponse>> tcs = new TaskCompletionSource<PlayFabAsyncResult<RedeemMicrosoftStoreInventoryItemsResponse>>();

        PlayFabEconomyAPI.RedeemMicrosoftStoreInventoryItems(request, result =>
        {
            tcs.TrySetResult(new PlayFabAsyncResult<RedeemMicrosoftStoreInventoryItemsResponse>(result, null));
        }, error =>
        {
            tcs.TrySetResult(new PlayFabAsyncResult<RedeemMicrosoftStoreInventoryItemsResponse>(null, error));
        }, customData, extraHeaders);

        return tcs.Task;
    }
    public static Task<PlayFabAsyncResult<RedeemNintendoEShopInventoryItemsResponse>> RedeemNintendoEShopInventoryItemsAsync(RedeemNintendoEShopInventoryItemsRequest request, object customData = null, Dictionary<string, string> extraHeaders = null)
    {
        TaskCompletionSource<PlayFabAsyncResult<RedeemNintendoEShopInventoryItemsResponse>> tcs = new TaskCompletionSource<PlayFabAsyncResult<RedeemNintendoEShopInventoryItemsResponse>>();

        PlayFabEconomyAPI.RedeemNintendoEShopInventoryItems(request, result =>
        {
            tcs.TrySetResult(new PlayFabAsyncResult<RedeemNintendoEShopInventoryItemsResponse>(result, null));
        }, error =>
        {
            tcs.TrySetResult(new PlayFabAsyncResult<RedeemNintendoEShopInventoryItemsResponse>(null, error));
        }, customData, extraHeaders);

        return tcs.Task;
    }
    public static Task<PlayFabAsyncResult<RedeemPlayStationStoreInventoryItemsResponse>> RedeemPlayStationStoreInventoryItemsAsync(RedeemPlayStationStoreInventoryItemsRequest request, object customData = null, Dictionary<string, string> extraHeaders = null)
    {
        TaskCompletionSource<PlayFabAsyncResult<RedeemPlayStationStoreInventoryItemsResponse>> tcs = new TaskCompletionSource<PlayFabAsyncResult<RedeemPlayStationStoreInventoryItemsResponse>>();

        PlayFabEconomyAPI.RedeemPlayStationStoreInventoryItems(request, result =>
        {
            tcs.TrySetResult(new PlayFabAsyncResult<RedeemPlayStationStoreInventoryItemsResponse>(result, null));
        }, error =>
        {
            tcs.TrySetResult(new PlayFabAsyncResult<RedeemPlayStationStoreInventoryItemsResponse>(null, error));
        }, customData, extraHeaders);

        return tcs.Task;
    }
    public static Task<PlayFabAsyncResult<RedeemSteamInventoryItemsResponse>> RedeemSteamInventoryItemsAsync(RedeemSteamInventoryItemsRequest request, object customData = null, Dictionary<string, string> extraHeaders = null)
    {
        TaskCompletionSource<PlayFabAsyncResult<RedeemSteamInventoryItemsResponse>> tcs = new TaskCompletionSource<PlayFabAsyncResult<RedeemSteamInventoryItemsResponse>>();

        PlayFabEconomyAPI.RedeemSteamInventoryItems(request, result =>
        {
            tcs.TrySetResult(new PlayFabAsyncResult<RedeemSteamInventoryItemsResponse>(result, null));
        }, error =>
        {
            tcs.TrySetResult(new PlayFabAsyncResult<RedeemSteamInventoryItemsResponse>(null, error));
        }, customData, extraHeaders);

        return tcs.Task;
    }
    public static Task<PlayFabAsyncResult<ReportItemResponse>> ReportItemAsync(ReportItemRequest request, object customData = null, Dictionary<string, string> extraHeaders = null)
    {
        TaskCompletionSource<PlayFabAsyncResult<ReportItemResponse>> tcs = new TaskCompletionSource<PlayFabAsyncResult<ReportItemResponse>>();

        PlayFabEconomyAPI.ReportItem(request, result =>
        {
            tcs.TrySetResult(new PlayFabAsyncResult<ReportItemResponse>(result, null));
        }, error =>
        {
            tcs.TrySetResult(new PlayFabAsyncResult<ReportItemResponse>(null, error));
        }, customData, extraHeaders);

        return tcs.Task;
    }
    public static Task<PlayFabAsyncResult<ReportItemReviewResponse>> ReportItemReviewAsync(ReportItemReviewRequest request, object customData = null, Dictionary<string, string> extraHeaders = null)
    {
        TaskCompletionSource<PlayFabAsyncResult<ReportItemReviewResponse>> tcs = new TaskCompletionSource<PlayFabAsyncResult<ReportItemReviewResponse>>();

        PlayFabEconomyAPI.ReportItemReview(request, result =>
        {
            tcs.TrySetResult(new PlayFabAsyncResult<ReportItemReviewResponse>(result, null));
        }, error =>
        {
            tcs.TrySetResult(new PlayFabAsyncResult<ReportItemReviewResponse>(null, error));
        }, customData, extraHeaders);

        return tcs.Task;
    }
    public static Task<PlayFabAsyncResult<ReviewItemResponse>> ReviewItemAsync(ReviewItemRequest request, object customData = null, Dictionary<string, string> extraHeaders = null)
    {
        TaskCompletionSource<PlayFabAsyncResult<ReviewItemResponse>> tcs = new TaskCompletionSource<PlayFabAsyncResult<ReviewItemResponse>>();

        PlayFabEconomyAPI.ReviewItem(request, result =>
        {
            tcs.TrySetResult(new PlayFabAsyncResult<ReviewItemResponse>(result, null));
        }, error =>
        {
            tcs.TrySetResult(new PlayFabAsyncResult<ReviewItemResponse>(null, error));
        }, customData, extraHeaders);

        return tcs.Task;
    }
    public static Task<PlayFabAsyncResult<SearchItemsResponse>> SearchItemsAsync(SearchItemsRequest request, object customData = null, Dictionary<string, string> extraHeaders = null)
    {
        TaskCompletionSource<PlayFabAsyncResult<SearchItemsResponse>> tcs = new TaskCompletionSource<PlayFabAsyncResult<SearchItemsResponse>>();

        PlayFabEconomyAPI.SearchItems(request, result =>
        {
            tcs.TrySetResult(new PlayFabAsyncResult<SearchItemsResponse>(result, null));
        }, error =>
        {
            tcs.TrySetResult(new PlayFabAsyncResult<SearchItemsResponse>(null, error));
        }, customData, extraHeaders);

        return tcs.Task;
    }
    public static Task<PlayFabAsyncResult<SetItemModerationStateResponse>> SetItemModerationStateAsync(SetItemModerationStateRequest request, object customData = null, Dictionary<string, string> extraHeaders = null)
    {
        TaskCompletionSource<PlayFabAsyncResult<SetItemModerationStateResponse>> tcs = new TaskCompletionSource<PlayFabAsyncResult<SetItemModerationStateResponse>>();

        PlayFabEconomyAPI.SetItemModerationState(request, result =>
        {
            tcs.TrySetResult(new PlayFabAsyncResult<SetItemModerationStateResponse>(result, null));
        }, error =>
        {
            tcs.TrySetResult(new PlayFabAsyncResult<SetItemModerationStateResponse>(null, error));
        }, customData, extraHeaders);

        return tcs.Task;
    }
    public static Task<PlayFabAsyncResult<SubmitItemReviewVoteResponse>> SubmitItemReviewVoteAsync(SubmitItemReviewVoteRequest request, object customData = null, Dictionary<string, string> extraHeaders = null)
    {
        TaskCompletionSource<PlayFabAsyncResult<SubmitItemReviewVoteResponse>> tcs = new TaskCompletionSource<PlayFabAsyncResult<SubmitItemReviewVoteResponse>>();

        PlayFabEconomyAPI.SubmitItemReviewVote(request, result =>
        {
            tcs.TrySetResult(new PlayFabAsyncResult<SubmitItemReviewVoteResponse>(result, null));
        }, error =>
        {
            tcs.TrySetResult(new PlayFabAsyncResult<SubmitItemReviewVoteResponse>(null, error));
        }, customData, extraHeaders);

        return tcs.Task;
    }
    public static Task<PlayFabAsyncResult<SubtractInventoryItemsResponse>> SubtractInventoryItemsAsync(SubtractInventoryItemsRequest request, object customData = null, Dictionary<string, string> extraHeaders = null)
    {
        TaskCompletionSource<PlayFabAsyncResult<SubtractInventoryItemsResponse>> tcs = new TaskCompletionSource<PlayFabAsyncResult<SubtractInventoryItemsResponse>>();

        PlayFabEconomyAPI.SubtractInventoryItems(request, result =>
        {
            tcs.TrySetResult(new PlayFabAsyncResult<SubtractInventoryItemsResponse>(result, null));
        }, error =>
        {
            tcs.TrySetResult(new PlayFabAsyncResult<SubtractInventoryItemsResponse>(null, error));
        }, customData, extraHeaders);

        return tcs.Task;
    }
    public static Task<PlayFabAsyncResult<TakedownItemReviewsResponse>> TakedownItemReviewsAsync(TakedownItemReviewsRequest request, object customData = null, Dictionary<string, string> extraHeaders = null)
    {
        TaskCompletionSource<PlayFabAsyncResult<TakedownItemReviewsResponse>> tcs = new TaskCompletionSource<PlayFabAsyncResult<TakedownItemReviewsResponse>>();

        PlayFabEconomyAPI.TakedownItemReviews(request, result =>
        {
            tcs.TrySetResult(new PlayFabAsyncResult<TakedownItemReviewsResponse>(result, null));
        }, error =>
        {
            tcs.TrySetResult(new PlayFabAsyncResult<TakedownItemReviewsResponse>(null, error));
        }, customData, extraHeaders);

        return tcs.Task;
    }
    public static Task<PlayFabAsyncResult<TransferInventoryItemsResponse>> TransferInventoryItemsAsync(TransferInventoryItemsRequest request, object customData = null, Dictionary<string, string> extraHeaders = null)
    {
        TaskCompletionSource<PlayFabAsyncResult<TransferInventoryItemsResponse>> tcs = new TaskCompletionSource<PlayFabAsyncResult<TransferInventoryItemsResponse>>();

        PlayFabEconomyAPI.TransferInventoryItems(request, result =>
        {
            tcs.TrySetResult(new PlayFabAsyncResult<TransferInventoryItemsResponse>(result, null));
        }, error =>
        {
            tcs.TrySetResult(new PlayFabAsyncResult<TransferInventoryItemsResponse>(null, error));
        }, customData, extraHeaders);

        return tcs.Task;
    }
    public static Task<PlayFabAsyncResult<UpdateCatalogConfigResponse>> UpdateCatalogConfigAsync(UpdateCatalogConfigRequest request, object customData = null, Dictionary<string, string> extraHeaders = null)
    {
        TaskCompletionSource<PlayFabAsyncResult<UpdateCatalogConfigResponse>> tcs = new TaskCompletionSource<PlayFabAsyncResult<UpdateCatalogConfigResponse>>();

        PlayFabEconomyAPI.UpdateCatalogConfig(request, result =>
        {
            tcs.TrySetResult(new PlayFabAsyncResult<UpdateCatalogConfigResponse>(result, null));
        }, error =>
        {
            tcs.TrySetResult(new PlayFabAsyncResult<UpdateCatalogConfigResponse>(null, error));
        }, customData, extraHeaders);

        return tcs.Task;
    }
    public static Task<PlayFabAsyncResult<UpdateDraftItemResponse>> UpdateDraftItemAsync(UpdateDraftItemRequest request, object customData = null, Dictionary<string, string> extraHeaders = null)
    {
        TaskCompletionSource<PlayFabAsyncResult<UpdateDraftItemResponse>> tcs = new TaskCompletionSource<PlayFabAsyncResult<UpdateDraftItemResponse>>();

        PlayFabEconomyAPI.UpdateDraftItem(request, result =>
        {
            tcs.TrySetResult(new PlayFabAsyncResult<UpdateDraftItemResponse>(result, null));
        }, error =>
        {
            tcs.TrySetResult(new PlayFabAsyncResult<UpdateDraftItemResponse>(null, error));
        }, customData, extraHeaders);

        return tcs.Task;
    }
    public static Task<PlayFabAsyncResult<UpdateInventoryItemsResponse>> UpdateInventoryItemsAsync(UpdateInventoryItemsRequest request, object customData = null, Dictionary<string, string> extraHeaders = null)
    {
        TaskCompletionSource<PlayFabAsyncResult<UpdateInventoryItemsResponse>> tcs = new TaskCompletionSource<PlayFabAsyncResult<UpdateInventoryItemsResponse>>();

        PlayFabEconomyAPI.UpdateInventoryItems(request, result =>
        {
            tcs.TrySetResult(new PlayFabAsyncResult<UpdateInventoryItemsResponse>(result, null));
        }, error =>
        {
            tcs.TrySetResult(new PlayFabAsyncResult<UpdateInventoryItemsResponse>(null, error));
        }, customData, extraHeaders);

        return tcs.Task;
    }
}
