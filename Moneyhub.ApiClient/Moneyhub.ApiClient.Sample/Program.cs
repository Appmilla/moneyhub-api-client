using System;
using Appmilla.Moneyhub.Refit.OpenFinance;
using Autofac;
using Microsoft.Extensions.DependencyInjection;
using Autofac.Extensions.DependencyInjection;
using Refit;
using Appmilla.Moneyhub.Refit.Appmilla.Moneyhub.Identity.Apis;
using Moneyhub.ApiClient.Config;
using System.Net.Http.Headers;
using Autofac.Extras.CommonServiceLocator;
using CommonServiceLocator;
using System.Threading.Tasks;
using Appmilla.Moneyhub.Refit.Appmilla.Moneyhub.Identity.Models;

namespace Moneyhub.ApiClient.Sample
{
    class Program
    {
        static async Task Main(string[] args)
        {
            SetServices();

            await GetAccounts();
        }

        static async Task GetAccounts()
        {
            var _accessToken = ServiceLocator.Current.GetInstance<IAccessToken>();
            var _accounts = ServiceLocator.Current.GetInstance<IAccounts>();

            var response = await _accessToken.GetAccessToken(new AccessTokenRequest() { GrantType = "client_credentials", Scope = "accounts:read savings_goals:read", Sub = "61ac9b75220d4100a72e17a2" });

            var accountsResponse = await _accounts.AccountsGetAllAsync(null, null, response.bearer_token);
        }

        static void SetServices()
        {
            var builder = new ContainerBuilder();

            var services = new ServiceCollection();

            var refitSettings = new RefitSettings(new NewtonsoftJsonContentSerializer());

            services.AddRefitClient<IAccessToken>(refitSettings)
                .ConfigureHttpClient(httpClient =>
                {
                    httpClient.BaseAddress = new Uri("https://identity.moneyhub.co.uk");

                    var configuration = new MoneyhubConfiguration
                    {
                        ClientId = "{ClientId}",
                        ClientSecret = "{ClientSecret}"
                    };

                    var authToken = configuration.GetAuthorization();

                    httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", authToken);
                });

            services.AddRefitClient<IAccounts>(refitSettings)
                .ConfigureHttpClient(httpClient =>
                {
                    httpClient.BaseAddress = new Uri("https://api.moneyhub.co.uk/v2.0");
                });

            builder.Populate(services);

            var container = builder.Build();

            var csl = new AutofacServiceLocator(container);
            ServiceLocator.SetLocatorProvider(() => csl);
        }
    }
}
