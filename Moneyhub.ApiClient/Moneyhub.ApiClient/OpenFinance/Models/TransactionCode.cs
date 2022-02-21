using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Appmilla.Moneyhub.Refit.OpenFinance
{
    /// <summary>
    /// TransactionCode
    /// </summary>    
    public class TransactionCode
    {
        /// <summary>
        /// Specifies the family within a domain.
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [AliasAs("code")]
        public string Code { get; set; }

        /// <summary>
        /// Specifies the sub-product family within a specific family.
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [AliasAs("subCode")]
        public string SubCode { get; set; }

    }
}