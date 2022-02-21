using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Appmilla.Moneyhub.Refit.Identity
{
    /// <summary>
    /// Response16
    /// </summary>    
    public class StandingOrdersGetResponse
    {

        /// <summary>
        /// Data
        /// </summary> 

        [AliasAs("data")]
        public StandingOrderRequest Data { get; set; }


        /// <summary>
        /// Meta
        /// </summary> 
        [AliasAs("meta")]
        public object Meta { get; set; }

    }
}