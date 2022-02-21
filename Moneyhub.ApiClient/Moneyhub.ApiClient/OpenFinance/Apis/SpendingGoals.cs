using System.Threading.Tasks;
using System.Collections.Generic;
using Refit;

namespace Appmilla.Moneyhub.Refit.OpenFinance
{
    public interface ISpendingGoals
    {
        /// <summary>
        /// Retrieve all spending goals for a user
        /// </summary>
        /// <param name="limit">The total number of records to retrieve</param>
        /// <param name="offset">The offset at which to start retrieving records</param>
        /// <returns>Successful Spending Goals Response</returns>
        [Get("/spending-goals")]
        [Headers()] 
        Task<SpendingGoalsGetAllResponse> SpendingGoalsGetAllAsync([Query][AliasAs("limit")] int? limit,[Query][AliasAs("offset")] int? offset, [Header("Authorization")] string bearerToken);

        /// <summary>
        /// Create a single spending goal for a user
        /// </summary>
        /// <returns>Successful Spending Goal Response</returns>
        [Post("/spending-goals")]
        [Headers()] 
        Task<SpendingGoalsCreateResponse> SpendingGoalsCreateAsync([Body][AliasAs("body")] SpendingGoalCreateRequest spendingGoalCreateRequest, [Header("Authorization")] string bearerToken);

        /// <summary>
        /// Retrieve a single spending goal
        /// </summary>
        /// <param name="goalId">The Goal Id</param>
        /// <returns>Successful Spending Goal Response</returns>
        [Get("/spending-goals/{goalId}")]
        [Headers()] 
        Task<SpendingGoalsGetResponse> SpendingGoalsGetAsync([AliasAs("goalId")] System.Guid goalId, [Header("Authorization")] string bearerToken);

        /// <summary>
        /// Update a single spending goal
        /// </summary>
        /// <param name="goalId">The Goal Id</param>
        /// <returns>Successful Spending Goal Response</returns>
        [Headers()] 
        Task<SpendingGoalsUpdateResponse> SpendingGoalsUpdateAsync([AliasAs("goalId")] System.Guid goalId,[Body][AliasAs("body")] SpendingGoalUpdateRequest spendingGoalUpdateRequest, [Header("Authorization")] string bearerToken);

        /// <summary>
        /// Delete a single spending goal
        /// </summary>
        /// <param name="goalId">The Goal Id</param>
        /// <returns>Successful Spending Goal Response</returns>
        [Delete("/spending-goals/{goalId}")]
        [Headers()] 
        Task SpendingGoalsDeleteAsync([AliasAs("goalId")] System.Guid goalId, [Header("Authorization")] string bearerToken);

    }
}