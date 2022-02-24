using System;
using Refit;

namespace Appmilla.Moneyhub.Refit.Identity
{
    public class AccessTokenResponse
    {
        public string access_token { get; set; }

        public int expires_in { get; set; }

        public string token_type { get; set; }

        public string bearer_token { get => $"Bearer {access_token}"; }
    }
}
