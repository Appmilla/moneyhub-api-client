using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Appmilla.Moneyhub.Refit.OpenFinance
{
    /// <summary>
    /// Payee
    /// </summary>    
    public class Payee
    {
        /// <summary>
        /// The name or names of the account owner(s)
        /// </summary>
        [AliasAs("name")]
        public string Name { get; set; }

        /// <summary>
        /// For cash accounts. Populated with the 6 digit Sort Code and 8 digit Account Number.
        /// </summary>
        [StringLength(20, MinimumLength = 14)]
        [AliasAs("sortCodeAccountNumber")]
        public string SortCodeAccountNumber { get; set; }

        /// <summary>
        /// For cash accounts. Populated with the full IBAN number.
        /// </summary>
        [StringLength(34, MinimumLength = 18)]
        [AliasAs("iban")]
        public string Iban { get; set; }

        /// <summary>
        /// For card accounts. Populated with the Primary Account Number.
        /// </summary>
        [AliasAs("pan")]
        public string Pan { get; set; }

    }
}