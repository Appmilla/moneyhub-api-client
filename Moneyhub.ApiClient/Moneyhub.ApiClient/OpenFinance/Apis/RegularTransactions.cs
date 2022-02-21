using System.Threading.Tasks;
using System.Collections.Generic;
using Refit;

namespace Appmilla.Moneyhub.Refit.OpenFinance
{
    public interface IRegularTransactions
    {
        /// <summary>
        /// Retrieve regular transactions
        /// </summary>
        /// <param name="accountId">The Account Id</param>
        /// <returns>Successful Regular Transactions Response</returns>
        [Get("/regular-transactions")]
        [Headers()] 
        Task<RegularTransactionsGetAllResponse> RegularTransactionsGetAllAsync([Query][AliasAs("accountId")] System.Guid? accountId, [Header("Authorization")] string bearerToken);
    }
}