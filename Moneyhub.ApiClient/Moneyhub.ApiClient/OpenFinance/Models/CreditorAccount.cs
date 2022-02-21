using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Appmilla.Moneyhub.Refit.OpenFinance
{
    /// <summary>
    /// CreditorAccount
    /// </summary>    
    public class CreditorAccount
    {
        /// <summary>
        /// The account name is the name or names of the account owner(s) represented at an account level, as displayed by the ASPSP's online channels.
        /// </summary>
        [AliasAs("name")]
        public string Name { get; set; }

        /// <summary>
        /// The sort code of the creditor account
        /// </summary>
        [AliasAs("sortCode")]
        public string SortCode { get; set; }

        /// <summary>
        /// The account number of the creditor account
        /// </summary>
        [AliasAs("accountNumber")]
        public string AccountNumber { get; set; }

        /// <summary>
        /// The IBAN of the creditor account
        /// </summary>
        [AliasAs("iban")]
        public string Iban { get; set; }

        /// <summary>
        /// The PAN of the creditor account
        /// </summary>
        [AliasAs("pan")]
        public string Pan { get; set; }

    }
}