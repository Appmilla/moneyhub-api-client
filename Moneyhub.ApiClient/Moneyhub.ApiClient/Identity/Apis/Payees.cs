using System.Threading.Tasks;
using System.Collections.Generic;
using Refit;

namespace Appmilla.Moneyhub.Refit.Identity
{
    public interface IPayees
    {
        /// <summary>
        /// Retrieve all payees created by an API client
        /// </summary>
        /// <param name="limit">The total number of records to retrieve</param>
        /// <param name="offset">The offset at which to start retrieving records</param>
        /// <param name="userId">The user ID to query payees on</param>
        /// <param name="hasUserId">Determine if you want to return payees with user ID of not</param>
        /// <returns>Successful Payee Response</returns>
        [Get("/payees")]
        [Headers()] 
        Task<PayeesGetAllResponse> PayeesGetAllAsync([Query][AliasAs("limit")] int? limit,[Query][AliasAs("offset")] int? offset,[Query][AliasAs("userId")] string userId,[Query][AliasAs("hasUserId")] bool? hasUserId);

        /// <summary>
        /// Create a payee
        /// </summary>
        /// <returns>Successful Payee Response</returns>
        [Post("/payees")]
        [Headers()] 
        Task<PayeesCreateResponse> PayeesCreateAsync([Body][AliasAs("body")] PayeeCreateRequest payeeCreateRequest);

        /// <summary>
        /// Retrieve one payee created by an API client
        /// </summary>
        /// <param name="payeeId">The payee Id</param>
        /// <returns>Successful Payee Response</returns>
        [Get("/payees/{payeeId}")]
        [Headers()] 
        Task<PayeesGetResponse> PayeesGetAsync([AliasAs("payeeId")] System.Guid payeeId);

    }
}