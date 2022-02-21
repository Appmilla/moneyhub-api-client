using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Appmilla.Moneyhub.Refit.OpenFinance
{
    /// <summary>
    /// Amount
    /// </summary>    
    public class Amount
    {
        /// <summary>
        /// The value of the balance in minor units of the currency, eg. pennies for GBP.
        /// </summary>
        [AliasAs("value")]
        public int Value { get; set; }

        /// <summary>
        /// The currency of the balance taken from the account
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [AliasAs("currency")]
        public string Currency { get; set; }

    }
}