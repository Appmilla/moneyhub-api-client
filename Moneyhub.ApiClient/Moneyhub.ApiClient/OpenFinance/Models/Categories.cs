using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Appmilla.Moneyhub.Refit.OpenFinance
{
    /// <summary>
    /// Categories
    /// </summary>    
    public class Categories
    {
        /// <summary>
        /// Category Id
        /// </summary>
        [AliasAs("categoryId")]
        public string CategoryId { get; set; }

        /// <summary>
        /// Category group where the category group belongs to
        /// </summary>
        [AliasAs("categoryGroup")]
        public string CategoryGroup { get; set; }

    }
}