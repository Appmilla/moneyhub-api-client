using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Appmilla.Moneyhub.Refit.OpenFinance
{
    /// <summary>
    /// Accounts
    /// </summary>    
    public class Accounts
    {
        /// <summary>
        /// Id of the account
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [AliasAs("id")]
        public string Id { get; set; }

    }
}