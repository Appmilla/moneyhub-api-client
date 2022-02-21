using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Appmilla.Moneyhub.Refit.Identity
{
    /// <summary>
    /// Response4
    /// </summary>    
    public class TestConnectionsResponse
    {

        /// <summary>
        /// Data
        /// </summary> 

        [AliasAs("data")]
        public List<WellknownConnection> Data { get; set; }

    }
}