using System.Threading.Tasks;
using System.Collections.Generic;
using Refit;

namespace Appmilla.Moneyhub.Refit.OpenFinance
{
    public interface INotificationThresholds
    {
        /// <summary>
        /// Retrieve the notification thresholds for an account
        /// </summary>
        /// <param name="accountId">The Account Id</param>
        /// <returns>Successful Notification Thresholds Response</returns>
        [Get("/accounts/{accountId}/notification-thresholds")]
        [Headers()] 
        Task<NotificationThresholdsGetAllResponse> NotificationThresholdsGetAllAsync([AliasAs("accountId")] System.Guid accountId, [Header("Authorization")] string bearerToken);

        /// <summary>
        /// Add a notification threshold to an account
        /// </summary>
        /// <param name="accountId">The Account Id</param>
        /// <returns>Succesfull Notification Threshold Response</returns>
        [Post("/accounts/{accountId}/notification-thresholds")]
        [Headers()] 
        Task<NotificationThresholdsAddResponse> NotificationThresholdsAddAsync([AliasAs("accountId")] System.Guid accountId,[Body][AliasAs("body")] NotificationThreshold body, [Header("Authorization")] string bearerToken);

        /// <summary>
        /// Update a single notification threshold
        /// </summary>
        /// <param name="accountId">The Account Id</param>
        /// <param name="thresholdId">The Threshold Id</param>
        /// <returns>Succesfull Notification Threshold Response</returns>

        [Headers()] 
        Task<NotificationThresholdsUpdateResponse> NotificationThresholdsUpdateAsync([AliasAs("accountId")] System.Guid accountId,[AliasAs("thresholdId")] System.Guid thresholdId,[Body][AliasAs("body")] NotificationThreshold body, [Header("Authorization")] string bearerToken);

        /// <summary>
        /// Delete a single notification threshold
        /// </summary>
        /// <param name="accountId">The Account Id</param>
        /// <param name="thresholdId">The Threshold Id</param>
        /// <returns>Successful Transaction Response</returns>
        [Delete("/accounts/{accountId}/notification-thresholds/{thresholdId}")]
        [Headers()] 
        Task NotificationThresholdsDeleteAsync([AliasAs("accountId")] System.Guid accountId,[AliasAs("thresholdId")] System.Guid thresholdId, [Header("Authorization")] string bearerToken);

    }
}