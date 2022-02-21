using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Appmilla.Moneyhub.Refit.OpenFinance
{
    /// <summary>
    /// Codes
    /// </summary>    
    public class Codes
    {

        /// <summary>
        /// Code
        /// </summary> 

        [AliasAs("code")]
        public string Code { get; set; }


        /// <summary>
        /// Type
        /// </summary> 

        [AliasAs("type")]
        public CodesType? Type { get; set; }

    }
}