using System.Threading.Tasks;
using System.Collections.Generic;
using Refit;

namespace Appmilla.Moneyhub.Refit.OpenFinance
{
    public interface IProjects
    {
        /// <summary>
        /// Retrieve all projects for a user
        /// </summary>
        /// <param name="limit">The total number of records to retrieve</param>
        /// <param name="offset">The offset at which to start retrieving records</param>
        /// <returns>Successful Projects Response</returns>
        [Get("/projects")]
        [Headers()] 
        Task<ProjectsGetAllResponse> ProjectsGetAllAsync([Query][AliasAs("limit")] int? limit,[Query][AliasAs("offset")] int? offset, [Header("Authorization")] string bearerToken);

        /// <summary>
        /// Create a single project for a user
        /// </summary>
        /// <returns>Successful Project Response</returns>
        [Post("/projects")]
        [Headers()] 
        Task<ProjectsCreateResponse> ProjectsCreateAsync([Body][AliasAs("body")] ProjectCreateRequest projectCreateRequest, [Header("Authorization")] string bearerToken);

        /// <summary>
        /// Retrieve a single project
        /// </summary>
        /// <param name="projectId">The Project Id</param>
        /// <returns>Successful Project Response</returns>
        [Get("/projects/{projectId}")]
        [Headers()] 
        Task<ProjectsGetResponse> ProjectsGetAsync([AliasAs("projectId")] System.Guid projectId, [Header("Authorization")] string bearerToken);

        /// <summary>
        /// Update a single project
        /// </summary>
        /// <param name="projectId">The Project Id</param>
        /// <returns>Successful Project Response</returns>

        [Headers()] 
        Task<ProjectsUpdateResponse> ProjectsUpdateAsync([AliasAs("projectId")] System.Guid projectId,[Body][AliasAs("body")] ProjectUpdateRequest projectUpdateRequest, [Header("Authorization")] string bearerToken);

        /// <summary>
        /// Delete a single project
        /// </summary>
        /// <param name="projectId">The Project Id</param>
        /// <returns>Successful Response</returns>
        [Delete("/projects/{projectId}")]
        [Headers()] 
        Task ProjectsDeleteAsync([AliasAs("projectId")] System.Guid projectId, [Header("Authorization")] string bearerToken);

    }
}