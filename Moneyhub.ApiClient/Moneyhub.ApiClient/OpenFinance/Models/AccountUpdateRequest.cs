using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Appmilla.Moneyhub.Refit.OpenFinance
{
    /// <summary>
    /// AccountPatch
    /// </summary>    
    public class AccountUpdateRequest
    {
        /// <summary>
        /// The name of the account
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [AliasAs("accountName")]
        public string AccountName { get; set; }

        /// <summary>
        /// The name of the provider of the account.
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [AliasAs("providerName")]
        public string ProviderName { get; set; }


        /// <summary>
        /// Details
        /// </summary> 

        [AliasAs("details")]
        public AccountRequestDetails Details { get; set; }

    }
}