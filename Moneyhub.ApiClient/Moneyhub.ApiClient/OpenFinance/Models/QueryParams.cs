using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Appmilla.Moneyhub.Refit.OpenFinance
{
    /// <summary>
    /// QueryParams
    /// </summary>    
    public class QueryParams
    {

        /// <summary>
        /// CategoryId
        /// </summary> 

        [AliasAs("categoryId")]
        public string CategoryId { get; set; }


        /// <summary>
        /// StartDate
        /// </summary> 

        [AliasAs("startDate")]
        public System.DateTimeOffset? StartDate { get; set; }


        /// <summary>
        /// EndDate
        /// </summary> 

        [AliasAs("endDate")]
        public System.DateTimeOffset? EndDate { get; set; }


        /// <summary>
        /// StartDateModified
        /// </summary> 

        [AliasAs("startDateModified")]
        public System.DateTimeOffset? StartDateModified { get; set; }


        /// <summary>
        /// EndDateModified
        /// </summary> 

        [AliasAs("endDateModified")]
        public System.DateTimeOffset? EndDateModified { get; set; }


        /// <summary>
        /// Limit
        /// </summary> 
        [Range(0, 1000)]
        [AliasAs("limit")]
        public int? Limit { get; set; }


        /// <summary>
        /// Offset
        /// </summary> 
        [Range(0, 1000000000)]
        [AliasAs("offset")]
        public int? Offset { get; set; }


        /// <summary>
        /// Text
        /// </summary> 
        [StringLength(100, MinimumLength = 2)]
        [AliasAs("text")]
        public string Text { get; set; }


        /// <summary>
        /// AccountId
        /// </summary> 
        [StringLength(36, MinimumLength = 36)]
        [AliasAs("accountId")]
        public string AccountId { get; set; }


        /// <summary>
        /// AccountIds
        /// </summary> 

        [AliasAs("accountIds")]
        public string AccountIds { get; set; }


        /// <summary>
        /// Type
        /// </summary> 
        [StringLength(100)]
        [AliasAs("type")]
        public string Type { get; set; }


        /// <summary>
        /// ProjectId
        /// </summary> 

        [AliasAs("projectId")]
        public string ProjectId { get; set; }


        /// <summary>
        /// ProjectIds
        /// </summary> 

        [AliasAs("projectIds")]
        public string ProjectIds { get; set; }


        /// <summary>
        /// CreditDebitIndicator
        /// </summary> 

        [AliasAs("creditDebitIndicator")]
        public string CreditDebitIndicator { get; set; }


        /// <summary>
        /// HasProject
        /// </summary> 

        [AliasAs("hasProject")]
        public bool? HasProject { get; set; }


        /// <summary>
        /// Contains
        /// </summary> 

        [AliasAs("contains")]
        public double? Contains { get; set; }


        /// <summary>
        /// HasEnhancedCategory
        /// </summary> 

        [AliasAs("hasEnhancedCategory")]
        public string HasEnhancedCategory { get; set; }


        /// <summary>
        /// EnhancedCategories
        /// </summary> 

        [AliasAs("enhancedCategories")]
        public string EnhancedCategories { get; set; }


        /// <summary>
        /// CounterpartyIdsV2
        /// </summary> 

        [AliasAs("counterpartyIdsV2")]
        public List<string> CounterpartyIdsV2 { get; set; }


        /// <summary>
        /// CounterpartyIds
        /// </summary> 

        [AliasAs("counterpartyIds")]
        public List<string> CounterpartyIds { get; set; }


        /// <summary>
        /// Ids
        /// </summary> 

        [AliasAs("ids")]
        public List<string> Ids { get; set; }


        /// <summary>
        /// IsUnique
        /// </summary> 

        [AliasAs("isUnique")]
        public bool? IsUnique { get; set; }


        /// <summary>
        /// CounterpartiesVersion
        /// </summary> 

        [AliasAs("counterpartiesVersion")]
        public QueryParamsCounterpartiesVersion? CounterpartiesVersion { get; set; }

    }
}