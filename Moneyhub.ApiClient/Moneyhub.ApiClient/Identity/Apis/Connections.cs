using System.Threading.Tasks;
using System.Collections.Generic;
using Refit;

namespace Appmilla.Moneyhub.Refit.Identity
{
    public interface IConnections
    {
        /// <summary>
        /// Retrieve all connections
        /// </summary>
        /// <returns>Successful Response</returns>
        [Get("/oidc/.well-known/all-connections")]
        [Headers()] 
        Task<AllConnectionsResponse> AllConnectionsAsync();

        /// <summary>
        /// Retrieve all api connections
        /// </summary>
        /// <returns>Successful Response</returns>
        [Get("/oidc/.well-known/api-connections")]
        [Headers()] 
        Task<ApiConnectionsResponse> ApiConnectionsAsync();

        /// <summary>
        /// Retrieve all legacy connections
        /// </summary>
        /// <returns>Successful Response</returns>
        [Get("/oidc/.well-known/legacy-connections")]
        [Headers()] 
        Task<LegacyConnectionsResponse> LegacyConnectionsAsync();

        /// <summary>
        /// Retrieve all test connections
        /// </summary>
        /// <returns>Successful Response</returns>
        [Get("/oidc/.well-known/test-connections")]
        [Headers()] 
        Task<TestConnectionsResponse> TestConnectionsAsync();

        /// <summary>
        /// Retrieve a user connections
        /// </summary>
        /// <param name="userId">The user Id</param>
        /// <returns>Successful User Response</returns>
        [Get("/users/{userId}/connections")]
        [Headers()] 
        Task<ConnectionsResponse> ConnectionsAsync([AliasAs("userId")] string userId);

        /// <summary>
        /// Deletes a single user connection
        /// </summary>
        /// <param name="userId">The user Id</param>
        /// <param name="connectionId">The connection id</param>
        /// <returns>Successful Response</returns>
        [Delete("/users/{userId}/connection/{connectionId}")]
        [Headers()] 
        Task ConnectionAsync([AliasAs("userId")] string userId,[AliasAs("connectionId")] string connectionId);

    }
}