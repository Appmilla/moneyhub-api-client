using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Appmilla.Moneyhub.Refit.OpenFinance
{
    /// <summary>
    /// RecurringTransactionEstimate
    /// </summary>    
    public class RecurringTransactionEstimate
    {
        /// <summary>
        /// The id of the counterparty that the estimate is for
        /// </summary>
        [AliasAs("counterpartyId")]
        public string CounterpartyId { get; set; }


        /// <summary>
        /// Amount
        /// </summary> 

        [AliasAs("amount")]
        public Amount Amount { get; set; }


        /// <summary>
        /// AmountRange
        /// </summary> 

        [AliasAs("amountRange")]
        public Amount AmountRange { get; set; }


        /// <summary>
        /// MonthlyAmount
        /// </summary> 

        [AliasAs("monthlyAmount")]
        public MonthlyAmount MonthlyAmount { get; set; }

        /// <summary>
        /// The source of the prediction
        /// </summary>
        [AliasAs("predictionSource")]
        public RecurringTransactionEstimatePredictionSource? PredictionSource { get; set; }

        /// <summary>
        /// A flag indicating whether the predictions are based only on a monthly average or not. If the predictions are based solely on monthly averages then the dates array will be defaulted to the end of the month for the next 3 motnhs.
        /// </summary>
        [AliasAs("monthlyAverageOnly")]
        public bool? MonthlyAverageOnly { get; set; }


        /// <summary>
        /// Dates
        /// </summary> 

        [AliasAs("dates")]
        public List<System.DateTimeOffset> Dates { get; set; }

    }
}