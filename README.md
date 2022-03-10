# Moneyhub Api Client

Moneyhub.ApiClient is a client SDK library for accessing Moneyhub's Data and Identity API's using ReactiveUI.Refit

https://www.moneyhub.com/home
https://api.moneyhub.co.uk/
https://identity.moneyhub.co.uk

Registering Moneyhubs interfaces can be done in a number of ways, one of these is detailed below using Autofac:

var builder = new ContainerBuilder();

var services = new ServiceCollection();

services.AddRefitClient<IAccounts>(refitSettings)
    .ConfigureHttpClient(httpClient =>
    {
        httpClient.BaseAddress = new Uri("https://api.moneyhub.co.uk/v2.0");
    });
  
builder.Populate(services);

builder.Build();
  
Once an interface is registered you can create an instance and use the IAccount object to access the range of different methods available from account section of Moneyhubs API.
  
All current API's and methods should be available as detailed in their SwaggerUI definitions for Moneyhubs data and identity endpoints
  
https://api.moneyhub.co.uk/swagger.json
https://identity.moneyhub.co.uk/swagger.json
