using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Appmilla.Moneyhub.Refit.OpenFinance
{
    /// <summary>
    /// TaxReturn
    /// </summary>    
    public class TaxReturn
    {

        /// <summary>
        /// Sa105
        /// </summary> 

        [AliasAs("sa105")]
        public Sa105 Sa105 { get; set; }

    }
}