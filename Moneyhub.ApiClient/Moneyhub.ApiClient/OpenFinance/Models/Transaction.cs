using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Appmilla.Moneyhub.Refit.OpenFinance
{
    /// <summary>
    /// Transaction
    /// </summary>    
    public class Transaction
    {
        /// <summary>
        /// The id of the account the transaction belongs to
        /// </summary>
        [AliasAs("accountId")]
        public string AccountId { get; set; }


        /// <summary>
        /// Amount
        /// </summary> 
        [Required]
        [AliasAs("amount")]
        public Amount Amount { get; set; } = new Amount();

        /// <summary>
        /// The category id. Standard categories are prefixed with 'std', custom categories are prefixed with 'cus'
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [AliasAs("categoryId")]
        public string CategoryId { get; set; }

        /// <summary>
        /// Flag indicating whether the user has confirmed the category id as correct
        /// </summary>
        [AliasAs("categoryIdConfirmed")]
        public bool CategoryIdConfirmed { get; set; }

        /// <summary>
        /// The date that the transaction occurred. Where available this will contain an accurate time, where the time is not available it will default to midday.
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [AliasAs("date")]
        public System.DateTimeOffset Date { get; set; }

        /// <summary>
        /// The date the transaction was modified - this could be when it was added, or a category changed, or when notes were added
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [AliasAs("dateModified")]
        public System.DateTimeOffset DateModified { get; set; }

        /// <summary>
        /// The unique id of the transaction
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [AliasAs("id")]
        public string Id { get; set; }

        /// <summary>
        /// The full text description of the transactions - often as it is represented on the users bank statement
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [AliasAs("longDescription")]
        public string LongDescription { get; set; }

        /// <summary>
        /// The id of the transaction the banking provider uses
        /// </summary>
        [AliasAs("providerId")]
        public string ProviderId { get; set; }

        /// <summary>
        /// Arbitrary text that a user can add about a transaction
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [AliasAs("notes")]
        public string Notes { get; set; } = "";

        /// <summary>
        /// A cleaned up and shorter description of the transaction, this can be edited
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [AliasAs("shortDescription")]
        public string ShortDescription { get; set; }

        /// <summary>
        /// An identifier for the counterparty
        /// </summary>
        [AliasAs("counterpartyId")]
        public string CounterpartyId { get; set; }

        /// <summary>
        /// Whether the transaction has been posted (booked) or is still a pending transaction. During the transition from pending to posted the description will normally change.
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [AliasAs("status")]
        public TransactionStatus Status { get; set; }

        /// <summary>
        /// The project ID the transaction belongs to
        /// </summary>
        [AliasAs("projectId")]
        public string ProjectId { get; set; }

        /// <summary>
        /// Categories to enrich a transaction with
        /// </summary>
        [AliasAs("enhancedCategories")]
        public EnhancedCategories EnhancedCategories { get; set; }

        /// <summary>
        /// List of transaction splits
        /// </summary>
        [AliasAs("splits")]
        public List<Splits> Splits { get; set; }

        /// <summary>
        /// The ISO transaction code
        /// </summary>
        [AliasAs("transactionCode")]
        public TransactionCode TransactionCode { get; set; }

        /// <summary>
        /// Set of elements to fully identify a proprietary bank transaction code.
        /// </summary>
        [AliasAs("proprietaryTransactionCode")]
        public ProprietaryTransactionCode ProprietaryTransactionCode { get; set; }

        /// <summary>
        /// Set of elements to describe the card instrument used in the transaction.
        /// </summary>
        [AliasAs("cardInstrument")]
        public CardInstrument CardInstrument { get; set; }

        /// <summary>
        /// Unambiguous identification of the account of the creditor, in the case of a debit transaction.
        /// </summary>
        [AliasAs("creditorAccount")]
        public CreditorAccount CreditorAccount { get; set; }

        /// <summary>
        /// Financial institution servicing an account for the creditor.
        /// </summary>
        [AliasAs("creditorAgent")]
        public CreditorAgent CreditorAgent { get; set; }

    }
}