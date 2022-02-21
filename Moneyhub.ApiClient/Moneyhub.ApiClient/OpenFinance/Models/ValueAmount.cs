using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Appmilla.Moneyhub.Refit.OpenFinance
{
    /// <summary>
    /// ValueAmount
    /// </summary>    
    public class ValueAmount
    {
        /// <summary>
        /// The target amount in minor unit in minor units of the currency, eg. pennies for GBP.
        /// </summary>
        [Range(1, int.MaxValue)]
        [AliasAs("value")]
        public int Value { get; set; }

    }
}