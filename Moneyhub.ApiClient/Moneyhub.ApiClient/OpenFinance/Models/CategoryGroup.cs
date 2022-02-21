using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Appmilla.Moneyhub.Refit.OpenFinance
{
    /// <summary>
    /// CategoryGroup
    /// </summary>    
    public class CategoryGroup
    {
        /// <summary>
        /// The id of the category group.
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [AliasAs("id")]
        public string Id { get; set; }

        /// <summary>
        /// A text key for the category group
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [AliasAs("key")]
        public string Key { get; set; }

    }
}