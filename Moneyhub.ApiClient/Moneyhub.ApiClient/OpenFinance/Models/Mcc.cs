using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Appmilla.Moneyhub.Refit.OpenFinance
{
    /// <summary>
    /// Mcc
    /// </summary>    
    public class Mcc
    {
        /// <summary>
        /// The merchant category code (only for global counterparties)
        /// </summary>
        [AliasAs("code")]
        public string Code { get; set; }

        /// <summary>
        /// The merchant category code name (only for global counterparties)
        /// </summary>
        [AliasAs("name")]
        public string Name { get; set; }

    }
}