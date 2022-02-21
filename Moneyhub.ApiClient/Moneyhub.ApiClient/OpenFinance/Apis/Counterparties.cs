using System.Threading.Tasks;
using System.Collections.Generic;
using Refit;

namespace Appmilla.Moneyhub.Refit.OpenFinance
{
    public interface ICounterparties
    {
        /// <summary>
        /// Retrieve the counterparties for an account
        /// </summary>
        /// <param name="accountId">The Account Id</param>
        /// <param name="counterpartiesVersion">Counterparties version</param>
        /// <returns>Successful Counterparties Response</returns>
        [Get("/accounts/{accountId}/counterparties")]
        [Headers()] 
        Task<CounterpartiesGetAllResponse> CounterpartiesGetAllAsync([AliasAs("accountId")] System.Guid accountId,[Query][AliasAs("counterpartiesVersion")] CounterpartiesVersion? counterpartiesVersion, [Header("Authorization")] string bearerToken);

        /// <summary>
        /// Retrieve global counterparties
        /// </summary>
        /// <param name="limit">The total number of records to retrieve</param>
        /// <param name="offset">The offset at which to start retrieving records</param>
        /// <param name="counterpartiesVersion">Counterparties version</param>
        /// <returns>Successful Counterparties Response</returns>
        [Get("/global-counterparties")]
        [Headers()] 
        Task<GlobalCounterpartiesGetAllResponse> GlobalCounterpartiesGetAllAsync([Query][AliasAs("limit")] int? limit,[Query][AliasAs("offset")] int? offset,[Query][AliasAs("counterpartiesVersion")] CounterpartiesVersion? counterpartiesVersion, [Header("Authorization")] string bearerToken);

    }
}