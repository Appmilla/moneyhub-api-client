using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Appmilla.Moneyhub.Refit.OpenFinance
{
    /// <summary>
    /// TransactionSplitUpdateRequest
    /// </summary>    
    public class TransactionSplitUpdateRequest
    {
        /// <summary>
        /// The category id. Standard categories are prefixed with 'std', custom categories are prefixed with 'cus'
        /// </summary>
        [AliasAs("categoryId")]
        public string CategoryId { get; set; }

        /// <summary>
        /// A description of the transaction split
        /// </summary>
        [AliasAs("description")]
        public string Description { get; set; }

        /// <summary>
        /// The project ID the transaction is associated with
        /// </summary>
        [AliasAs("projectId")]
        public string ProjectId { get; set; }

    }
}