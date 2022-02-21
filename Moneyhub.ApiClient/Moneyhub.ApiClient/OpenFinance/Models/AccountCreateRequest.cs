using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Appmilla.Moneyhub.Refit.OpenFinance
{
    /// <summary>
    /// AccountCreateRequest
    /// </summary>    
    public class AccountCreateRequest
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
        /// The type of account - this will determine the data available in the details field
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [AliasAs("type")]
        public AccountPostType Type { get; set; }

        /// <summary>
        /// The type of account (personal/business)
        /// </summary>
        [AliasAs("accountType")]
        public AccountEntityType? AccountType { get; set; } = AccountEntityType.Personal;


        /// <summary>
        /// Balance
        /// </summary> 
        [Required]
        [AliasAs("balance")]
        public AccountRequestBalance Balance { get; set; } = new AccountRequestBalance();


        /// <summary>
        /// Details
        /// </summary> 
        [AliasAs("details")]
        public AccountRequestDetails Details { get; set; }

    }
}