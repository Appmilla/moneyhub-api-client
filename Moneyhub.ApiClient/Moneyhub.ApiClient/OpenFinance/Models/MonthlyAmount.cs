using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Appmilla.Moneyhub.Refit.OpenFinance
{
    /// <summary>
    /// MonthlyAmount
    /// </summary>    
    public class MonthlyAmount
    {
        /// <summary>
        /// The predicted monthly amount for this counterparty, regardless of how many transactions in minor units of the currency, eg. pennies for GBP.
        /// </summary>
        [AliasAs("value")]
        public int Value { get; set; }

        /// <summary>
        /// The currency of the monthly amount taken from the account
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [AliasAs("currency")]
        public string Currency { get; set; }

    }
}