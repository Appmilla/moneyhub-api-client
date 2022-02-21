using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Appmilla.Moneyhub.Refit.OpenFinance
{
    /// <summary>
    /// Price
    /// </summary>    
    public class Price
    {
        /// <summary>
        /// The unit price in minor units of the currency (e.g. pence for GBP)
        /// </summary>
        [AliasAs("value")]
        public double Value { get; set; }

        /// <summary>
        /// The currency of the matched holding
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [AliasAs("currency")]
        public string Currency { get; set; }

    }
}