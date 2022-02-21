using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Appmilla.Moneyhub.Refit.OpenFinance
{
    /// <summary>
    /// Total
    /// </summary>    
    public class Total
    {
        /// <summary>
        /// The value of the total in minor units of the currency, eg. pennies for GBP.
        /// </summary>
        [AliasAs("value")]
        public double Value { get; set; }

        /// <summary>
        /// The currency of the total.
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [AliasAs("currency")]
        public string Currency { get; set; }

    }
}