using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Appmilla.Moneyhub.Refit.OpenFinance
{
    /// <summary>
    /// Expenditure
    /// </summary>    
    public class Expenditure
    {

        /// <summary>
        /// Total
        /// </summary> 
        [Required]

        [AliasAs("total")]
        public Total Total { get; set; } = new Total();


        /// <summary>
        /// Details
        /// </summary> 
        [Required]

        [AliasAs("details")]
        public List<AmountDetails> Details { get; set; } = new List<AmountDetails>();

    }
}