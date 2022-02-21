using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Appmilla.Moneyhub.Refit.Identity
{
    /// <summary>
    /// Response5
    /// </summary>    
    public class ConnectionsResponse
    {

        /// <summary>
        /// Data
        /// </summary> 

        [AliasAs("data")]
        public Connection Data { get; set; }


        /// <summary>
        /// Meta
        /// </summary> 

        [AliasAs("meta")]
        public object Meta { get; set; }

    }
}