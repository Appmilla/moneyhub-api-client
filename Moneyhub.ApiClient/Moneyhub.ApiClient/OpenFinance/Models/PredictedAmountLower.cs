using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Appmilla.Moneyhub.Refit.OpenFinance
{
    /// <summary>
    /// PredictedAmountLower
    /// </summary>    
    public class PredictedAmountLower
    {
        /// <summary>
        /// The amount of the transaction in minor units of the currency, eg. pennies for GBP, negative means money going out of an account, positive means money coming into an account.
        /// </summary>
        [AliasAs("value")]
        public int Value { get; set; }

        /// <summary>
        /// The currency of the amount
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [AliasAs("currency")]
        public string Currency { get; set; }

    }
}