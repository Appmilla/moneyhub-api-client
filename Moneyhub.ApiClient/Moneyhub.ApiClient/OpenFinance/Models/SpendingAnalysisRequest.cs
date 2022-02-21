using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Appmilla.Moneyhub.Refit.OpenFinance
{
    /// <summary>
    /// SpendingAnalysisRequest
    /// </summary>    
    public class SpendingAnalysisRequest
    {
        /// <summary>
        /// List of date ranges to calculate spending analysis for. This allows retrieving spending analysis of up to three different date ranges in one request.
        /// </summary>
        [Required]
        [MinLength(1)]
        [MaxLength(3)]
        [AliasAs("dates")]
        public List<Dates> Dates { get; set; } = new List<Dates>();


        /// <summary>
        /// AccountIds
        /// </summary> 

        [AliasAs("accountIds")]
        public List<string> AccountIds { get; set; }


        /// <summary>
        /// CategoryIds
        /// </summary> 

        [AliasAs("categoryIds")]
        public List<string> CategoryIds { get; set; }


        /// <summary>
        /// ProjectIds
        /// </summary> 

        [AliasAs("projectIds")]
        public List<string> ProjectIds { get; set; }

    }
}