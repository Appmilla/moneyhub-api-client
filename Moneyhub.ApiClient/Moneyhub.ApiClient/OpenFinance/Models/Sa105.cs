using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Appmilla.Moneyhub.Refit.OpenFinance
{
    /// <summary>
    /// Sa105
    /// </summary>    
    public class Sa105
    {

        /// <summary>
        /// Income
        /// </summary> 
        [Required]
        [AliasAs("income")]
        public Income Income { get; set; } = new Income();


        /// <summary>
        /// Expenditure
        /// </summary> 
        [Required]
        [AliasAs("expenditure")]
        public Expenditure Expenditure { get; set; } = new Expenditure();


        /// <summary>
        /// TaxableIncome
        /// </summary> 
        [Required]
        [AliasAs("taxableIncome")]
        public TaxableIncome TaxableIncome { get; set; } = new TaxableIncome();

    }
}