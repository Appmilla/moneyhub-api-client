using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Appmilla.Moneyhub.Refit.Identity
{
    /// <summary>
    /// Response14
    /// </summary>    
    public class PaymentsGetResponse
    {

        /// <summary>
        /// Data
        /// </summary> 

        [AliasAs("data")]
        public Payment Data { get; set; }


        /// <summary>
        /// Meta
        /// </summary> 

        [AliasAs("meta")]
        public object Meta { get; set; }

    }
}