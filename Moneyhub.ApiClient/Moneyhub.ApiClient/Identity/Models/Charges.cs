using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Appmilla.Moneyhub.Refit.Identity
{
    /// <summary>
    /// Charges
    /// </summary>    
    public class Charges
    {
        /// <summary>
        /// Specifies which party/parties will bear the charges associated with the processing of the payment transaction.
        /// </summary>
        [AliasAs("bearer")]
        public ChargesBearer? Bearer { get; set; }

        /// <summary>
        /// Charge type, in a coded form.
        /// </summary>
        [AliasAs("type")]
        public ChargesType? Type { get; set; }

        /// <summary>
        /// Charge amount in minor units of the currency, eg. pennies for GBP.
        /// </summary>
        [Range(1, 1000000)]
        [AliasAs("amount")]
        public int? Amount { get; set; }

        /// <summary>
        /// Currency code
        /// </summary>
        [AliasAs("currency")]
        public string Currency { get; set; }

    }
}