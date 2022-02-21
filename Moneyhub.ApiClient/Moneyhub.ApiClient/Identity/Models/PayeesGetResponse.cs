using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Appmilla.Moneyhub.Refit.Identity
{
    /// <summary>
    /// Response12
    /// </summary>    
    public class PayeesGetResponse
    {

        /// <summary>
        /// Data
        /// </summary> 

        [AliasAs("data")]
        public Payee Data { get; set; }


        /// <summary>
        /// Meta
        /// </summary> 

        [AliasAs("meta")]
        public object Meta { get; set; }

    }
}