using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Appmilla.Moneyhub.Refit.OpenFinance
{
    /// <summary>
    /// TaxableIncome
    /// </summary>    
    public class TaxableIncome
    {

        /// <summary>
        /// Total
        /// </summary> 
        [Required]
        [AliasAs("total")]
        public Total Total { get; set; } = new Total();

    }
}