using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Appmilla.Moneyhub.Refit.OpenFinance
{
    /// <summary>
    /// SyncData
    /// </summary>    
    public class SyncData
    {
        /// <summary>
        /// Status of the connection
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [AliasAs("status")]
        public SyncDataStatus Status { get; set; }

    }
}