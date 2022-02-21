using System;
namespace Moneyhub.ApiClient.Config
{
    public class MoneyhubConfiguration
    {
        public string ClientId { get; set; }
        public string ClientSecret { get; set; }

        public MoneyhubConfiguration()
        {
        }

        public string GetAuthorization()
        {
            return Base64Encode(ClientId + ":" + ClientSecret);
        }

        public static string Base64Encode(string text)
        {
            var textByte = System.Text.Encoding.UTF8.GetBytes(text);
            return System.Convert.ToBase64String(textByte);
        }
    }
}
