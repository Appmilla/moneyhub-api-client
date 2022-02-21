using System.Threading.Tasks;
using System.Collections.Generic;
using Refit;

namespace Appmilla.Moneyhub.Refit.OpenFinance
{
    public interface ITransactions
    {
        /// <summary>
        /// Retrieve all transactions for a user
        /// </summary>
        /// <param name="ids">Filter on the transaction's Ids (maximum allowed 50)</param>
        /// <param name="limit">The total number of records to retrieve</param>
        /// <param name="offset">The offset at which to start retrieving records</param>
        /// <param name="startDate">The earliest date to receive transactions from (inclusive)</param>
        /// <param name="endDate">The latest date to receive transactions from (inclusive)</param>
        /// <param name="startDateModified">The earliest date the transactions were modified (inclusive)</param>
        /// <param name="endDateModified">The latest date the transactions were modified (inclusive)</param>
        /// <param name="text">The text to filter transactions descriptions/notes by</param>
        /// <param name="categoryId">The category id to filter transactions by</param>
        /// <param name="accountId">The account id to filter transactions by</param>
        /// <param name="accountIds">The account ids to filter transactions by</param>
        /// <param name="projectId">The project id to filter transactions by</param>
        /// <param name="projectIds">The project ids to filter transactions by</param>
        /// <param name="creditDebitIndicator">Filter transactions depending on whether they are credit or debit transactions</param>
        /// <param name="hasProject">Filter on whether transaction has an attached project</param>
        /// <param name="contains">Filter on the beginning of words of a transaction's clean description or beginning of transaction amount</param>
        /// <param name="hasEnhancedCategory">A property to check exists within a transaction</param>
        /// <param name="counterpartyIds">Filter on the transaction's counterparty Id</param>
        /// <param name="counterpartyIdsV2">Filter on the transaction's counterparty Id (Deprecated)</param>
        /// <param name="counterpartiesVersion">Counterparties version</param>
        /// <param name="enhancedCategories">An enhanced category to filter transactions by in the form of ${categoryField}:${categoryValue}</param>
        /// <returns>Successful Transactions Response</returns>
        [Get("/transactions")]
        [Headers()] 
        Task<TransactionsGetAllResponse> TransactionsGetAllAsync([Query][AliasAs("ids")] IEnumerable<System.Guid> ids,
            [Query][AliasAs("limit")] int? limit,
            [Query][AliasAs("offset")] int? offset,
            [Query][AliasAs("startDate")] System.DateTimeOffset? startDate,
            [Query][AliasAs("endDate")] System.DateTimeOffset? endDate,
            [Query][AliasAs("startDateModified")] System.DateTimeOffset? startDateModified,
            [Query][AliasAs("endDateModified")] System.DateTimeOffset? endDateModified,
            [Query][AliasAs("text")] string text,
            [Query][AliasAs("categoryId")] string categoryId,
            [Query][AliasAs("accountId")] string accountId,
            [Query][AliasAs("accountIds")] IEnumerable<string> accountIds,
            [Query][AliasAs("projectId")] string projectId,
            [Query][AliasAs("projectIds")] IEnumerable<string> projectIds,
            [Query][AliasAs("creditDebitIndicator")] string creditDebitIndicator,
            [Query][AliasAs("hasProject")] bool? hasProject,
            [Query][AliasAs("contains")] string contains,
            [Query][AliasAs("hasEnhancedCategory")] string hasEnhancedCategory,
            [Query][AliasAs("counterpartyIds")] IEnumerable<string> counterpartyIds,
            [Query][AliasAs("counterpartyIdsV2")] IEnumerable<string> counterpartyIdsV2,
            [Query][AliasAs("counterpartiesVersion")] CounterpartiesVersion? counterpartiesVersion,
            [Query][AliasAs("enhancedCategories")] string enhancedCategories,
            [Header("Authorization")] string bearerToken);

        /// <summary>
        /// Create a single transaction for a user
        /// </summary>
        /// <returns>Successful Transaction Response</returns>
        [Post("/transactions")]
        [Headers()] 
        Task<TransactionsCreateResponse> TransactionsCreateAsync([Body][AliasAs("body")] TransactionCreateRequest transactionCreateRequest, [Header("Authorization")] string bearerToken);

        /// <summary>
        /// Retrieve a single transaction
        /// </summary>
        /// <param name="transactionId">The transaction id</param>
        /// <param name="counterpartiesVersion">Counterparties version</param>
        /// <returns>Successful Transaction Response</returns>
        [Get("/transactions/{transactionId}")]
        [Headers()] 
        Task<TransactionsGetResponse> TransactionsGetAsync([AliasAs("transactionId")] System.Guid transactionId,[Query][AliasAs("counterpartiesVersion")] CounterpartiesVersion? counterpartiesVersion, [Header("Authorization")] string bearerToken);

        /// <summary>
        /// Update a single transaction
        /// </summary>
        /// <param name="transactionId">The transaction id</param>
        /// <returns>Successful Transaction Response</returns>

        [Headers()] 
        Task<TransactionsUpdateResponse> TransactionsUpdateAsync([AliasAs("transactionId")] System.Guid transactionId,[Body][AliasAs("body")] TransactionUpdateRequest transactionUpdateRequest, [Header("Authorization")] string bearerToken);

        /// <summary>
        /// Delete a single transaction
        /// </summary>
        /// <param name="transactionId">The transaction id</param>
        /// <returns>Successful Transaction Response</returns>
        [Delete("/transactions/{transactionId}")]
        [Headers()] 
        Task TransactionsDeleteAsync([AliasAs("transactionId")] System.Guid transactionId, [Header("Authorization")] string bearerToken);

        /// <summary>
        /// Create multiple transactions for a user
        /// </summary>
        /// <param name="categorise">Enable categorisation of transactions</param>
        /// <returns>Successful Transaction Response</returns>
        [Post("/transactions-collection")]
        [Headers()] 
        Task<TransactionsCreateMultipleResponse> TransactionsCreateMultipleAsync([Body][AliasAs("body")] IEnumerable<TransactionCreateRequest> body,[Query][AliasAs("categorise")] bool? categorise, [Header("Authorization")] string bearerToken);

        /// <summary>
        /// Retrieve a transactions attachments
        /// </summary>
        /// <param name="transactionId">The transaction id</param>
        /// <returns>Successful Transaction File Response</returns>
        [Get("/transactions/{transactionId}/files")]
        [Headers()] 
        Task<TransactionAttachmentGetAllResponse> TransactionAttachmentGetAllAsync([AliasAs("transactionId")] System.Guid transactionId, [Header("Authorization")] string bearerToken);

        /// <summary>
        /// Add an attachment to a transaction
        /// </summary>
        /// <param name="transactionId">The transaction id</param>
        /// <param name="file">File to upload, limit of 10MB and must be an image or PDF.</param>
        /// <returns>Successful Transaction Response</returns>
        [Post("/transactions/{transactionId}/files")]
        [Headers()] 
        Task<TransactionAttachmentAddResponse> TransactionAttachmentAddAsync([AliasAs("transactionId")] System.Guid transactionId,[AliasAs("file")] TransactionFile file, [Header("Authorization")] string bearerToken);

        /// <summary>
        /// Retrieve a transactions attachment
        /// </summary>
        /// <param name="transactionId">The transaction id</param>
        /// <param name="fileId">The file id</param>
        /// <returns>Successful Transaction File Response</returns>
        [Get("/transactions/{transactionId}/files/{fileId}")]
        [Headers()] 
        Task<TransactionAttachmentGetResponse> TransactionAttachmentGetAsync([AliasAs("transactionId")] System.Guid transactionId,[AliasAs("fileId")] string fileId, [Header("Authorization")] string bearerToken);

        /// <summary>
        /// Delete a single attachment on a transaction
        /// </summary>
        /// <param name="transactionId">The transaction id</param>
        /// <param name="fileId">The file id</param>
        /// <returns>Successful Transaction Response</returns>
        [Delete("/transactions/{transactionId}/files/{fileId}")]
        [Headers()] 
        Task TransactionAttachmentDeleteAsync([AliasAs("transactionId")] System.Guid transactionId,[AliasAs("fileId")] string fileId, [Header("Authorization")] string bearerToken);

        /// <summary>
        /// Retrieve a transactions splits
        /// </summary>
        /// <param name="transactionId">The transaction id</param>
        /// <returns>Successful Transaction Splits Response</returns>
        [Get("/transactions/{transactionId}/splits")]
        [Headers()] 
        Task<TransactionSplitsGetAllResponse> TransactionSplitsGetAllAsync([AliasAs("transactionId")] System.Guid transactionId, [Header("Authorization")] string bearerToken);

        /// <summary>
        /// Split a transaction
        /// </summary>
        /// <param name="transactionId">The transaction id</param>
        /// <returns>Successful Transaction Splits Response</returns>
        [Post("/transactions/{transactionId}/splits")]
        [Headers()] 
        Task<SplitTransactionResponse> SplitTransactionAsync([AliasAs("transactionId")] System.Guid transactionId,[Body][AliasAs("body")] IEnumerable<TransactionSplitRequest> body, [Header("Authorization")] string bearerToken);

        /// <summary>
        /// Merge split transactions
        /// </summary>
        /// <param name="transactionId">The transaction id</param>
        /// <returns>Successful Transaction Splits Response</returns>
        [Delete("/transactions/{transactionId}/splits")]
        [Headers()] 
        Task TransactionSplitsMergeAsync([AliasAs("transactionId")] System.Guid transactionId, [Header("Authorization")] string bearerToken);

        /// <summary>
        /// Patch a transaction split
        /// </summary>
        /// <param name="transactionId">The transaction id</param>
        /// <param name="splitId">The split id</param>
        /// <returns>Successful Transaction Splits Response</returns>

        [Headers()] 
        Task<TransactionSplitsUpdateResponse> TransactionSplitsUpdateAsync([AliasAs("transactionId")] System.Guid transactionId,[AliasAs("splitId")] System.Guid splitId,[Body][AliasAs("body")] TransactionSplitUpdateRequest body, [Header("Authorization")] string bearerToken);

    }
}