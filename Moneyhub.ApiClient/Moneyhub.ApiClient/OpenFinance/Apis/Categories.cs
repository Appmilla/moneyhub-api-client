using System.Threading.Tasks;
using System.Collections.Generic;
using Refit;

namespace Appmilla.Moneyhub.Refit.OpenFinance
{
    public interface ICategories
    {
        /// <summary>
        /// Retrieve all categories for a user
        /// </summary>
        /// <param name="limit">The total number of records to retrieve</param>
        /// <param name="offset">The offset at which to start retrieving records</param>
        /// <param name="type">The types of categories to be returned</param>
        /// <returns>Successful Categories Response</returns>
        [Get("/categories")]
        [Headers()] 
        Task<CategoriesGetAllResponse> CategoriesGetAllAsync([Query][AliasAs("limit")] int? limit,[Query][AliasAs("offset")] int? offset,[Query][AliasAs("type")] CategoryType type, [Header("Authorization")] string bearerToken);

        /// <summary>
        /// Add a new custom category for a user
        /// </summary>
        /// <returns>Successful Category Response</returns>
        [Post("/categories")]
        [Headers()] 
        Task<CategoriesAddResponse> CategoriesAddAsync([Body][AliasAs("body")] CategoryAddRequest categoryAddRequest, [Header("Authorization")] string bearerToken);

        /// <summary>
        /// Retrieve a single category
        /// </summary>
        /// <param name="categoryId">The Category Id</param>
        /// <param name="type">The types of categories to be returned</param>
        /// <returns>Successful Category Response</returns>
        [Get("/categories/{categoryId}")]
        [Headers()] 
        Task<CategoriesGetResponse> CategoriesGetAsync([AliasAs("categoryId")] string categoryId,[Query][AliasAs("type")] CategoryType type, [Header("Authorization")] string bearerToken);

        /// <summary>
        /// Retrieve all category groups for a user
        /// </summary>
        /// <param name="type">The types of categories to be returned</param>
        /// <returns>Successful Category Groups Response</returns>
        [Get("/category-groups")]
        [Headers()] 
        Task<CategoryGroupsGetAllResponse> CategoryGroupsGetAllAsync([Query][AliasAs("type")] AccountEntityType type, [Header("Authorization")] string bearerToken);

    }
}