using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Appmilla.Moneyhub.Refit.OpenFinance
{
    /// <summary>
    /// Frequency
    /// </summary>    
    public class Frequency
    {

        /// <summary>
        /// Repeat
        /// </summary> 
        [Required(AllowEmptyStrings = true)]
        [AliasAs("repeat")]
        public FrequencyRepeat Repeat { get; set; }

        /// <summary>
        /// The number of the day on which to repeat the payment
        /// </summary>
        [AliasAs("day")]
        public double? Day { get; set; }

        /// <summary>
        /// The number of the week on which to repeat the payment
        /// </summary>
        [AliasAs("week")]
        public double? Week { get; set; }

        /// <summary>
        /// The number of the month on which to repeat the payment
        /// </summary>
        [AliasAs("month")]
        public double? Month { get; set; }

        /// <summary>
        /// Specifies whether the payment should only be made on working days
        /// </summary>
        [AliasAs("onlyWorkDays")]
        public bool? OnlyWorkDays { get; set; }

        /// <summary>
        /// The region for dates of quarterly payments
        /// </summary>
        [AliasAs("region")]
        public FrequencyRegion? Region { get; set; }

    }
}