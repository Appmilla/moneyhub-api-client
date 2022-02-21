using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Appmilla.Moneyhub.Refit.Identity
{
    /// <summary>
    /// WellknownConnection
    /// </summary>    
    public class WellknownConnection
    {
        /// <summary>
        /// Bank connection id (used to request an authorization url for a specific bank)
        /// </summary>
        [AliasAs("id")]
        public string Id { get; set; }

        /// <summary>
        /// Bank Name
        /// </summary>
        [AliasAs("name")]
        public string Name { get; set; }

        /// <summary>
        /// The type of bank connection (api, legacy or test)
        /// </summary>
        [AliasAs("type")]
        public WellknownConnectionType? Type { get; set; }

        /// <summary>
        /// Country Code
        /// </summary>
        [AliasAs("country")]
        public string Country { get; set; }

        /// <summary>
        /// This property is now deprecated. Please use bankRef instead
        /// </summary>
        [AliasAs("parentRef")]
        public string ParentRef { get; set; }

        /// <summary>
        /// Reference that uniquely identities a set of connections as being part of the same institution. It is used to group a set of connections by the banking institution they refer to. It can alse be used to retrieve the bank icon.
        /// </summary>
        [AliasAs("bankRef")]
        public string BankRef { get; set; }

        /// <summary>
        /// A beta boolean value flagging which connection is currently being developed and may not have a 100% success rate
        /// </summary>
        [AliasAs("isBeta")]
        public bool? IsBeta { get; set; }

        /// <summary>
        /// An array containing the types of accounts supported by the connection
        /// </summary>
        [AliasAs("accountTypes")]
        public List<AccountTypes> AccountTypes { get; set; }

        /// <summary>
        /// The url of the bank icon SVG. Please be aware we don’t have icons for all the connections we provide. For the missing icons you can either use your own set or use our generic bank icon found at this url: https://identity.moneyhub.co.uk/bank-icons/default
        /// </summary>
        [AliasAs("iconUrl")]
        public string IconUrl { get; set; }

        /// <summary>
        /// An array of user account types supported by the bank connection
        /// </summary>
        [AliasAs("userTypes")]
        public List<UserTypes> UserTypes { get; set; }

        /// <summary>
        /// An array of payments capabilities for thebank
        /// </summary>
        [AliasAs("payments")]
        public List<Payments> Payments { get; set; }

    }
}