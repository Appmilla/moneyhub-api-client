using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Appmilla.Moneyhub.Refit.OpenFinance
{
    /// <summary>
    /// EnhancedCategories
    /// </summary>    
    public class EnhancedCategories
    {
        /// <summary>
        /// The UK HMRC Tax category to aid in tax return queries
        /// </summary>
        [AliasAs("uk-tax-hmrc")]
        public string UkTaxHmrc { get; set; }

    }
}