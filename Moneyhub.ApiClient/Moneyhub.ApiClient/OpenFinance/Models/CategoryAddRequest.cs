using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Appmilla.Moneyhub.Refit.OpenFinance
{
    /// <summary>
    /// CategoryPost
    /// </summary>    
    public class CategoryAddRequest
    {
        /// <summary>
        /// The id of the category group that the custom category should be part of
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [AliasAs("group")]
        public string Group { get; set; }

        /// <summary>
        /// The name of the custom category
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [AliasAs("name")]
        public string Name { get; set; }

    }
}