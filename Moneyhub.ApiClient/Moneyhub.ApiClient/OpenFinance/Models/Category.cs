using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Appmilla.Moneyhub.Refit.OpenFinance
{
    /// <summary>
    /// Category
    /// </summary>    
    public class Category
    {
        /// <summary>
        /// The id of the category. Custom categories are prefixed with 'cus:'
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [AliasAs("categoryId")]
        public string CategoryId { get; set; }

        /// <summary>
        /// The name of the category - only applicable for custom categories
        /// </summary>
        [AliasAs("name")]
        public string Name { get; set; }

        /// <summary>
        /// A text key for standard categories
        /// </summary>
        [AliasAs("key")]
        public string Key { get; set; }

        /// <summary>
        /// The category group to which the category belongs
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [AliasAs("group")]
        public string Group { get; set; }

    }
}