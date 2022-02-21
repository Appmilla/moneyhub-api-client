using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Appmilla.Moneyhub.Refit.OpenFinance
{
    /// <summary>
    /// ProprietaryTransactionCode
    /// </summary>    
    public class ProprietaryTransactionCode
    {
        /// <summary>
        /// Proprietary bank transaction code to identify the underlying transaction.
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [AliasAs("code")]
        public string Code { get; set; }

        /// <summary>
        /// Identification of the issuer of the proprietary bank transaction code.
        /// </summary>
        [AliasAs("issuer")]
        public string Issuer { get; set; }

    }
}