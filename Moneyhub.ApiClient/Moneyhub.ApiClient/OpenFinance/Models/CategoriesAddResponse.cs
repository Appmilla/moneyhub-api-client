using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Appmilla.Moneyhub.Refit.OpenFinance
{
    /// <summary>
    /// Response31
    /// </summary>    
    public class CategoriesAddResponse
    {

        /// <summary>
        /// Data
        /// </summary> 

        [AliasAs("data")]
        public Category Data { get; set; }


        /// <summary>
        /// Links
        /// </summary> 

        [AliasAs("links")]
        public Links Links { get; set; }


        /// <summary>
        /// Meta
        /// </summary> 

        [AliasAs("meta")]
        public object Meta { get; set; }

    }
}