using System.Threading.Tasks;
using System.Collections.Generic;
using Refit;

namespace Appmilla.Moneyhub.Refit.OpenFinance
{
    public interface IAccounts
    {
        /// <summary>
        /// Retrieve all accounts for a user
        /// </summary>
        /// <param name="limit">The total number of records to retrieve</param>
        /// <param name="offset">The offset at which to start retrieving records</param>
        /// <returns>Successful Accounts Response</returns>
        [Get("/accounts")]
        [Headers()] 
        Task<AccountsGetAllResponse> AccountsGetAllAsync([Query][AliasAs("limit")] int? limit,[Query][AliasAs("offset")] int? offset, [Header("Authorization")] string bearerToken);

        /// <summary>
        /// Create a single account for a user
        /// </summary>
        /// <returns>Successful Account Response</returns>
        [Post("/accounts")]
        [Headers()] 
        Task<AccountsCreateResponse> AccountsCreateAsync([Body][AliasAs("body")] AccountCreateRequest accountCreateRequest, [Header("Authorization")] string bearerToken);

        /// <summary>
        /// Retrieve a single account
        /// </summary>
        /// <param name="accountId">The Account Id</param>
        /// <returns>Successful Account Response</returns>
        [Get("/accounts/{accountId}")]
        [Headers()] 
        Task<AccountsGetResponse> AccountsGetAsync([AliasAs("accountId")] System.Guid accountId, [Header("Authorization")] string bearerToken);

        /// <summary>
        /// Update a single account
        /// </summary>
        /// <param name="accountId">The Account Id</param>
        /// <returns>Successful Account Response</returns>

        [Headers()] 
        Task<AccountsUpdateResponse> AccountsUpdateAsync([AliasAs("accountId")] System.Guid accountId,[Body][AliasAs("body")] AccountUpdateRequest accountUpdateRequest, [Header("Authorization")] string bearerToken);

        /// <summary>
        /// Delete a single account
        /// </summary>
        /// <param name="accountId">The Account Id</param>
        /// <returns>Successful Response</returns>
        [Delete("/accounts/{accountId}")]
        [Headers()] 
        Task AccountsDeleteAsync([AliasAs("accountId")] System.Guid accountId, [Header("Authorization")] string bearerToken);

        /// <summary>
        /// Retrieve the historical balances for an account
        /// </summary>
        /// <param name="accountId">The Account Id</param>
        /// <returns>Successful Balances Response</returns>
        [Get("/accounts/{accountId}/balances")]
        [Headers()] 
        Task<BalancesGetAllResponse> BalancesGetAllAsync([AliasAs("accountId")] System.Guid accountId, [Header("Authorization")] string bearerToken);

        /// <summary>
        /// Add a new balance for an account
        /// </summary>
        /// <param name="accountId">The Account Id</param>
        /// <returns>Successful Balance Response</returns>
        [Post("/accounts/{accountId}/balances")]
        [Headers()] 
        Task<BalancesAddResponse> BalancesAddAsync([AliasAs("accountId")] System.Guid accountId,[Body][AliasAs("body")] BalanceAddRequest balanceAddRequest, [Header("Authorization")] string bearerToken);

        /// <summary>
        /// Create an estimate of the recurring transactions for an account
        /// </summary>
        /// <param name="accountId">The Account Id</param>
        /// <returns>Successful Recurring Transactions Response</returns>
        [Post("/accounts/{accountId}/recurring-transactions")]
        [Headers()] 
        Task<RecurringTransactionsGetAllResponse> RecurringTransactionsGetAllAsync([AliasAs("accountId")] System.Guid accountId, [Header("Authorization")] string bearerToken);

    }
}