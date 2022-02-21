using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Appmilla.Moneyhub.Refit.OpenFinance
{
    /// <summary>
    /// Account
    /// </summary>    
    public class Account
    {
        /// <summary>
        /// The name of the account
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [AliasAs("accountName")]
        public string AccountName { get; set; }

        /// <summary>
        /// The currency of the account
        /// </summary>
        [AliasAs("currency")]
        public string Currency { get; set; }


        /// <summary>
        /// Balance
        /// </summary> 
        [Required]
        [AliasAs("balance")]
        public Balance Balance { get; set; } = new Balance();


        /// <summary>
        /// Details
        /// </summary> 
        [Required]
        [AliasAs("details")]
        public Details Details { get; set; } = new Details();


        /// <summary>
        /// TransactionData
        /// </summary> 

        [AliasAs("transactionData")]
        public TransactionData TransactionData { get; set; }

        /// <summary>
        /// The date at which the account was added.
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [AliasAs("dateAdded")]
        public System.DateTimeOffset DateAdded { get; set; }

        /// <summary>
        /// The date at which the account was last modified
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [AliasAs("dateModified")]
        public System.DateTimeOffset DateModified { get; set; }

        /// <summary>
        /// The unique identity of the account.
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [AliasAs("id")]
        public string Id { get; set; }

        /// <summary>
        /// The name of the provider of the account.
        /// </summary>
        [AliasAs("providerName")]
        public string ProviderName { get; set; }

        /// <summary>
        /// The unique reference name of the provider of the account.
        /// </summary>
        [AliasAs("providerReference")]
        public string ProviderReference { get; set; }

        /// <summary>
        /// The id of the connection of the account. This value is not present for accounts created manually by the user.
        /// </summary>
        [AliasAs("connectionId")]
        public string ConnectionId { get; set; }

        /// <summary>
        /// The id of the provider of the account. Accounts created using the api have a value of 'API'. Accounts crated for a Test user have a value of 'DEMO'. This value is not present for accounts created manually by the user.
        /// </summary>
        [AliasAs("providerId")]
        public string ProviderId { get; set; }

        /// <summary>
        /// A reference number for the account - typically the last 4 digits of the account number
        /// </summary>
        [AliasAs("accountReference")]
        public string AccountReference { get; set; }

        /// <summary>
        /// Account Holder name. It requires the `accounts_details:read` scope.
        /// </summary>
        [AliasAs("accountHolderName")]
        public string AccountHolderName { get; set; }

        /// <summary>
        /// The type of account (personal/business)
        /// </summary>
        [AliasAs("accountType")]
        public AccountEntityType? AccountType { get; set; } = OpenFinance.AccountEntityType.Personal;

        /// <summary>
        /// The type of account - this will determine the data available in the details field
        /// </summary>        [Required(AllowEmptyStrings = true)]

        [AliasAs("type")]
        public AccountType Type { get; set; }

        /// <summary>
        /// Performance score of investment and pension accounts. Once that an account has at least 3 balances the score will be provided. Please note that this is an experimental feature.
        /// </summary>
        [AliasAs("performanceScore")]
        public PerformanceScore PerformanceScore { get; set; }

    }
}