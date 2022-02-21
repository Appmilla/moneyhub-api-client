using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Appmilla.Moneyhub.Refit.OpenFinance
{
    /// <summary>
    /// ProjectUpdateRequest
    /// </summary>    
    public class ProjectUpdateRequest
    {
        /// <summary>
        /// The name of the project
        /// </summary>
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
        [AliasAs("type")]
        public ProjectPatchType? Type { get; set; }

        /// <summary>
        /// Flag to determine if project is archived or not
        /// </summary>
        [AliasAs("archived")]
        public bool? Archived { get; set; }

    }
}