using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Appmilla.Moneyhub.Refit.OpenFinance
{
    /// <summary>
    /// Balance
    /// </summary>    
    public class Balance
    {

        /// <summary>
        /// Amount
        /// </summary> 
        [Required]

        [AliasAs("amount")]
        public Amount Amount { get; set; } = new Amount();

        /// <summary>
        /// The date of the balance
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [AliasAs("date")]
        public System.DateTimeOffset Date { get; set; }

    }
}