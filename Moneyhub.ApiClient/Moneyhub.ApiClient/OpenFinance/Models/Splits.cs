using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Appmilla.Moneyhub.Refit.OpenFinance
{
    /// <summary>
    /// Splits
    /// </summary>    
    public class Splits
    {
        /// <summary>
        /// The amount of the transaction in minor units of the currency, eg. pennies for GBP, negative means money going out of an account, positive means money coming into an account.
        /// </summary>
        [AliasAs("amount")]
        public int Amount { get; set; }

        /// <summary>
        /// The category id. Standard categories are prefixed with 'std', custom categories are prefixed with 'cus'
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [AliasAs("categoryId")]
        public string CategoryId { get; set; }

        /// <summary>
        /// A description of the transaction split
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [AliasAs("description")]
        public string Description { get; set; }

        /// <summary>
        /// The unique id of the transaction split
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [AliasAs("id")]
        public string Id { get; set; }

        /// <summary>
        /// The project ID the transaction is associated with
        /// </summary>
        [AliasAs("projectId")]
        public string ProjectId { get; set; }

    }
}