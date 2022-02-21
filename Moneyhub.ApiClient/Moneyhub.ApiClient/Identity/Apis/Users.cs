using System.Threading.Tasks;
using System.Collections.Generic;
using Refit;

namespace Appmilla.Moneyhub.Refit.Identity
{
    public interface IUsers
    {
        /// <summary>
        /// Retrieve all users created by an API client
        /// </summary>
        /// <param name="limit">The total number of records to retrieve</param>
        /// <param name="offset">The offset at which to start retrieving records</param>
        /// <returns>Successful User Response</returns>
        [Get("/users")]
        [Headers()] 
        Task<UsersGetAllResponse> UsersGetAllAsync([Query][AliasAs("limit")] int? limit,[Query][AliasAs("offset")] int? offset);

        /// <summary>
        /// Create a user
        /// </summary>
        /// <returns>Successful User Response</returns>
        [Post("/users")]
        [Headers()] 
        Task<User> UsersCreateAsync([Body][AliasAs("body")] UserCreateRequest userCreateRequest);

        /// <summary>
        /// Retrieve a single user
        /// </summary>
        /// <param name="userId">The user Id</param>
        /// <returns>Successful User Response</returns>
        [Get("/users/{userId}")]
        [Headers()] 
        Task<User> UsersGetAsync([AliasAs("userId")] string userId);

        /// <summary>
        /// Deletes a single user
        /// </summary>
        /// <param name="userId">The user Id</param>
        /// <returns>Successful Response</returns>
        [Delete("/users/{userId}")]
        [Headers()] 
        Task UsersDeleteAsync([AliasAs("userId")] string userId);

    }
}