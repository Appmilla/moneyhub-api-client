using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Appmilla.Moneyhub.Refit.Identity
{
    /// <summary>
    /// Response3
    /// </summary>    
    public class LegacyConnectionsResponse
    {

        /// <summary>
        /// Data
        /// </summary> 

        [AliasAs("data")]
        public List<WellknownConnection> Data { get; set; }

    }
}