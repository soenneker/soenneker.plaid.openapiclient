[![](https://img.shields.io/nuget/v/soenneker.plaid.openapiclient.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.plaid.openapiclient/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.plaid.openapiclient/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.plaid.openapiclient/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.plaid.openapiclient.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.plaid.openapiclient/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.plaid.openapiclient/codeql.yml?style=for-the-badge&label=codeql)](https://github.com/soenneker/soenneker.plaid.openapiclient/actions/workflows/codeql.yml)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.Plaid.OpenApiClient

Generated request builders and models for Plaid products including Accounts, Auth, Identity, Institutions, Investments, Link, Transactions, Transfer, and Sandbox.

## Installation

```bash
dotnet add package Soenneker.Plaid.OpenApiClient
```

## Usage

```csharp
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;
using Soenneker.Plaid.OpenApiClient;
using Soenneker.Plaid.OpenApiClient.Models;

using var httpClient = new HttpClient();
httpClient.DefaultRequestHeaders.Add("PLAID-CLIENT-ID", clientId);
httpClient.DefaultRequestHeaders.Add("PLAID-SECRET", secret);

var adapter = new HttpClientRequestAdapter(
    new AnonymousAuthenticationProvider(),
    httpClient: httpClient)
{
    BaseUrl = "https://sandbox.plaid.com"
};

var client = new PlaidOpenApiClient(adapter);
var institutions = await client.Institutions.Get.PostAsync(
    new InstitutionsGetRequest
    {
        Count = 10,
        Offset = 0,
        CountryCodes = [CountryCode.US]
    },
    cancellationToken: cancellationToken);
```

Change `BaseUrl` to `https://development.plaid.com` or `https://production.plaid.com` when using credentials for those environments. Item-specific operations also require the appropriate Plaid access token in their request model.
