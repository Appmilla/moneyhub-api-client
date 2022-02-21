using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Appmilla.Moneyhub.Refit.OpenFinance
{
    /// <summary>
    /// AmountDetails
    /// </summary>    
    public class AmountDetails
    {
        /// <summary>
        /// The category the detail belongs to
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [AliasAs("category")]
        public string Category { get; set; }


        /// <summary>
        /// Amount
        /// </summary> 
        [Required]
        [AliasAs("amount")]
        public Amount Amount { get; set; } = new Amount();

    }
}