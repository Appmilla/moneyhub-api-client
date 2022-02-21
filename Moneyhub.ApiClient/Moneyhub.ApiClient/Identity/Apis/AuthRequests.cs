using System.Threading.Tasks;
using System.Collections.Generic;
using Refit;

namespace Appmilla.Moneyhub.Refit.Identity
{
    public interface IAuthRequests
    {
        /// <summary>
        /// Retrieve all auth requests for a user
        /// </summary>
        /// <param name="limit">The total number of records to retrieve</param>
        /// <param name="offset">The offset at which to start retrieving records</param>
        /// <returns>Succesful Account Requests Response</returns>
        [Get("/auth-requests")]
        [Headers()] 
        Task<AuthRequestsGetAllResponse> AuthRequestsGetAllAsync([Query][AliasAs("limit")] int? limit,[Query][AliasAs("offset")] int? offset);

        /// <summary>
        /// Create an auth request
        /// </summary>
        /// <returns>Succesful Auth Request Response</returns>
        [Post("/auth-requests")]
        [Headers()] 
        Task<AuthRequestsCreateResponse> AuthRequestsCreateAsync([Body][AliasAs("body")] AuthRequestCreateRequest authRequestCreateRequest);

        /// <summary>
        /// Retrieve a single auth request
        /// </summary>
        /// <param name="authRequestId">The auth request Id</param>
        /// <returns>Succesful Auth Request Response</returns>
        [Get("/auth-requests/{authRequestId}")]
        [Headers()] 
        Task<AuthRequestsGetResponse> AuthRequestsGetAsync([AliasAs("authRequestId")] System.Guid authRequestId);

        /// <summary>
        /// Update a single auth request
        /// </summary>
        /// <param name="authRequestId">The auth request Id</param>
        /// <returns>Successful Account Response</returns>
        [Headers()] 
        Task<AuthRequestsUpdateResponse> AuthRequestsUpdateAsync([AliasAs("authRequestId")] System.Guid authRequestId,[Body][AliasAs("body")] AuthRequestUpdateRequest authRequestUpdateRequest);

    }
}