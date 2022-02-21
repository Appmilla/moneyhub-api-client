using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Appmilla.Moneyhub.Refit.OpenFinance
{
    /// <summary>
    /// RegularTransactions
    /// </summary>    
    public class RegularTransactions
    {
        /// <summary>
        /// The unique identity of the series.
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [AliasAs("seriesId")]
        public string SeriesId { get; set; }

        /// <summary>
        /// The unique identity of the account.
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [AliasAs("accountId")]
        public string AccountId { get; set; }

        /// <summary>
        /// Whether the transaction is income or payment
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [AliasAs("type")]
        public RegularTransactionsType Type { get; set; }

        /// <summary>
        /// The full text description of the transactions - often as it is represented on the users bank statement
        /// </summary>
        [AliasAs("description")]
        public string Description { get; set; }

        /// <summary>
        /// A cleaned up and shorter description of the transaction, this can be edited
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [AliasAs("cleanedDescription")]
        public string CleanedDescription { get; set; }

        /// <summary>
        /// A matching id of the counterparty of the series
        /// </summary>
        [AliasAs("counterpartyId")]
        public string CounterpartyId { get; set; }

        /// <summary>
        /// The time between payments in the series
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [AliasAs("frequency")]
        public RegularTransactionsFrequency Frequency { get; set; }

        /// <summary>
        /// The count of the transactions in the series
        /// </summary>
        [AliasAs("numTxMatchedInSeries")]
        public int NumTxMatchedInSeries { get; set; }

        /// <summary>
        /// The count of expected dates with no corresponding transactions
        /// </summary>
        [AliasAs("gapLengthInFreqUnits")]
        public int? GapLengthInFreqUnits { get; set; }

        /// <summary>
        /// The count of transactions which occurred outside the predicted date range
        /// </summary>
        [AliasAs("dateAnomaliesCount")]
        public int? DateAnomaliesCount { get; set; }

        /// <summary>
        /// The count of transactions we have detected were returned (reversed/declined)
        /// </summary>
        [AliasAs("numReturnedTxs")]
        public int? NumReturnedTxs { get; set; }

        /// <summary>
        /// Date on which the most recent transaction in the series occured
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [AliasAs("lastDate")]
        public System.DateTimeOffset LastDate { get; set; }

        /// <summary>
        /// Predicted date the next transactions is most likely to occur
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [AliasAs("predictedDate")]
        public System.DateTimeOffset PredictedDate { get; set; }

        /// <summary>
        /// Earliest predicted date of the next transaction in the series
        /// </summary>
        [AliasAs("predictedDateEarliest")]
        public System.DateTimeOffset? PredictedDateEarliest { get; set; }

        /// <summary>
        /// Lastest predicted date of the next transaction in the series
        /// </summary>
        [AliasAs("predictedDateLatest")]
        public System.DateTimeOffset? PredictedDateLatest { get; set; }

        /// <summary>
        /// Is the predicted payment late or not detected?
        /// </summary>
        [AliasAs("predictedTxLateOrNotDetected")]
        public bool? PredictedTxLateOrNotDetected { get; set; }

        /// <summary>
        /// Predicted amount of the next transaction
        /// </summary>
        [Required]
        [AliasAs("predictedAmount")]
        public PredictedAmount PredictedAmount { get; set; } = new PredictedAmount();

        /// <summary>
        /// The smallest amount predicted for the next transaction
        /// </summary>
        [AliasAs("predictedAmountLower")]
        public PredictedAmountLower PredictedAmountLower { get; set; }

        /// <summary>
        /// The largest amount predicted for the next transaction
        /// </summary>
        [AliasAs("predictedAmountUpper")]
        public PredictedAmountUpper PredictedAmountUpper { get; set; }

        /// <summary>
        /// The category id. Standard categories are prefixed with 'std', custom categories are prefixed with 'cus'
        /// </summary>
        [AliasAs("predictedCategoryId")]
        public string PredictedCategoryId { get; set; }

        /// <summary>
        /// An array of transaction IDs
        /// </summary>
        [Required]
        [AliasAs("transactions")]
        public List<string> Transactions { get; set; } = new List<string>();

    }
}