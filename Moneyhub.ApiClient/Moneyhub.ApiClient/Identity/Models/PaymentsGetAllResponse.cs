using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Appmilla.Moneyhub.Refit.Identity
{
    /// <summary>
    /// Response13
    /// </summary>    
    public class PaymentsGetAllResponse
    {

        /// <summary>
        /// Data
        /// </summary> 

        [AliasAs("data")]
        public List<Payment> Data { get; set; }


        /// <summary>
        /// Meta
        /// </summary> 

        [AliasAs("meta")]
        public Meta Meta { get; set; }

    }
}