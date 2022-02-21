using System.Threading.Tasks;
using System.Collections.Generic;
using Refit;

namespace Appmilla.Moneyhub.Refit.OpenFinance
{
    public interface ISavingsGoals
    {
        /// <summary>
        /// Retrieve all saving goals for a user
        /// </summary>
        /// <param name="limit">The total number of records to retrieve</param>
        /// <param name="offset">The offset at which to start retrieving records</param>
        /// <returns>Successful Response</returns>
        [Get("/savings-goals")]
        [Headers()] 
        Task<SavingsGoalsGetAllResponse> SavingsGoalsGetAllAsync([Query][AliasAs("limit")] int? limit,[Query][AliasAs("offset")] int? offset, [Header("Authorization")] string bearerToken);

        /// <summary>
        /// Create a single savings goal for a user
        /// </summary>
        /// <returns>Successful Response</returns>
        [Post("/savings-goals")]
        [Headers()] 
        Task<SavingsGoalsCreateResponse> SavingsGoalsCreateAsync([Body][AliasAs("body")] SavingsGoalsCreateRequest savingsGoalsCreateRequest, [Header("Authorization")] string bearerToken);

        /// <summary>
        /// Retrieve a single savings goal
        /// </summary>
        /// <param name="goalId">The Goal Id</param>
        /// <returns>Successful Spending Goal Response</returns>
        [Get("/savings-goals/{goalId}")]
        [Headers()] 
        Task<SavingsGoalsGetResponse> SavingsGoalsGetAsync([AliasAs("goalId")] System.Guid goalId, [Header("Authorization")] string bearerToken);

        /// <summary>
        /// Update a single savings goal
        /// </summary>
        /// <param name="goalId">The Goal Id</param>
        /// <returns>Successful Response</returns>

        [Headers()] 
        Task<SavingsGoalsUpdateResponse> SavingsGoalsUpdateAsync([AliasAs("goalId")] System.Guid goalId,[Body][AliasAs("body")] SavingsGoalsUpdateRequest savingsGoalsUpdateRequest, [Header("Authorization")] string bearerToken);

        /// <summary>
        /// Delete a single savings goal
        /// </summary>
        /// <param name="goalId">The Goal Id</param>
        /// <returns>Successful Response</returns>
        [Delete("/savings-goals/{goalId}")]
        [Headers()] 
        Task SavingsGoalsDeleteAsync([AliasAs("goalId")] System.Guid goalId, [Header("Authorization")] string bearerToken);

    }
}