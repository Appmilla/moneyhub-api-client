using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Appmilla.Moneyhub.Refit.OpenFinance
{
    /// <summary>
    /// Data
    /// </summary>    
    public class Data
    {
        /// <summary>
        /// The unique id of the transaction
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [AliasAs("id")]
        public System.Guid Id { get; set; }

    }
}