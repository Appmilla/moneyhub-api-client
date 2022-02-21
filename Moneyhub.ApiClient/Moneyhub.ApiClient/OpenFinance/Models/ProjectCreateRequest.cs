using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Appmilla.Moneyhub.Refit.OpenFinance
{
    /// <summary>
    /// ProjectPost
    /// </summary>    
    public class ProjectCreateRequest
    {
        /// <summary>
        /// The name of the project
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [AliasAs("name")]
        public string Name { get; set; }

        /// <summary>
        /// Account IDs that are associated with the project
        /// </summary>
        [AliasAs("accountIds")]
        public List<string> AccountIds { get; set; }

        /// <summary>
        /// The project type
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [AliasAs("type")]
        public ProjectPostType Type { get; set; }

    }
}