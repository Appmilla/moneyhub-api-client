using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Appmilla.Moneyhub.Refit.OpenFinance
{
    /// <summary>
    /// BalancePost
    /// </summary>    
    public class BalanceAddRequest
    {

        /// <summary>
        /// Amount
        /// </summary> 
        [Required]

        [AliasAs("amount")]
        public ValueAmount Amount { get; set; } = new ValueAmount();

        /// <summary>
        /// The date of the balance
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [AliasAs("date")]
        public System.DateTimeOffset Date { get; set; }

    }
}