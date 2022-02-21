using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Appmilla.Moneyhub.Refit.OpenFinance
{
    /// <summary>
    /// TransactionUpdateRequest
    /// </summary>    
    public class TransactionUpdateRequest
    {
        /// <summary>
        /// Scope 'transactions.write.all' required. The id of the account the transaction belongs to
        /// </summary>
        [AliasAs("accountId")]
        public string AccountId { get; set; }


        /// <summary>
        /// Amount
        /// </summary> 

        [AliasAs("amount")]
        public ValueAmount Amount { get; set; }

        /// <summary>
        /// The category id. Standard categories are prefixed with 'std', custom categories are prefixed with 'cus'
        /// </summary>
        [AliasAs("categoryId")]
        public string CategoryId { get; set; }

        /// <summary>
        /// Flag indicating whether the user has confirmed the category id as correct
        /// </summary>
        [AliasAs("categoryIdConfirmed")]
        public bool? CategoryIdConfirmed { get; set; }

        /// <summary>
        /// Scope 'transactions.write.all' required. The date that the transaction occurred. Where available this will contain an accurate time, where the time is not available it will default to midday.
        /// </summary>
        [AliasAs("date")]
        public System.DateTimeOffset? Date { get; set; }

        /// <summary>
        /// Scope 'transactions.write.all' required. The full text description of the transactions - often as it is represented on the users bank statement
        /// </summary>
        [AliasAs("longDescription")]
        public string LongDescription { get; set; }

        /// <summary>
        /// A cleaned up and shorter description of the transaction, this can be edited
        /// </summary>
        [AliasAs("shortDescription")]
        public string ShortDescription { get; set; }

        /// <summary>
        /// Arbitrary text that a user can add about a transaction
        /// </summary>
        [StringLength(500)]
        [AliasAs("notes")]
        public string Notes { get; set; } = "";

        /// <summary>
        /// Scope 'transactions.write.all' required. Whether the transaction has been posted (booked) or is still a pending transaction. During the transition from pending to posted the description will normally change.
        /// </summary>
        [AliasAs("status")]
        public TransactionPatchStatus? Status { get; set; }

        /// <summary>
        /// The project ID the transaction is associated with
        /// </summary>
        [AliasAs("projectId")]
        public string ProjectId { get; set; }

        /// <summary>
        /// Categories to enrich a transaction with
        /// </summary>
        [AliasAs("enhancedCategories")]
        public EnhancedCategories EnhancedCategories { get; set; }

    }
}