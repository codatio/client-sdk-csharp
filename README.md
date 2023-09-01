<div align="center">
    <picture>
        <source srcset="https://user-images.githubusercontent.com/6267663/221800355-0995e4ad-a386-4943-a4c2-e620341a5155.svg" media="(prefers-color-scheme: dark)">
        <img src="https://user-images.githubusercontent.com/6267663/221800359-b7f7776c-a44f-4384-8dd0-d9f7d5caef7d.svg">
    </picture>
    <h1>Codat C#</h1>
        <p><strong>The universal API for small business data</strong></p>
        <p>Codat solves the connectivity challenge for developers building the next generation of financial products for small businesses. We're experts in how your application interacts with the other software your customer use, so you can focus on what makes you superior.</p>
    <a href="https://docs.codat.io/using-the-api/overview"><img src="https://img.shields.io/static/v1?label=Docs&message=API Ref&color=4c2cec&style=for-the-badge" /></a>
    <a href="https://opensource.org/licenses/MIT"><img src="https://img.shields.io/badge/License-MIT-blue.svg?style=for-the-badge" /></a>
</div>

> **Beta Release**
> 
> Exciting news! Our first C# library beta release is here, simplifying your development workflow with an effortless build process.

## Authentication

Codat uses API keys to control access to the API.

You must keep the API key secret, so make sure it isn't available in publicly accessible areas, such as GitHub and client-side code. Codat recommends the API key is only inserted at release time, and the number of people at your organization with access to your API key is minimised.

Codat expects the API key to be included in all API requests to the server, Base64 encoded within an 'Authorization' header.

```bash
Authorization: Basic YOUR_ENCODED_API_KEY
```

### Getting your Authorization Header

To get your authorization header from the Codat Portal:

1. In the navigation bar, click **Developers > API keys**.
2. In the **API Keys** section, copy your authorization header rather than the API key itself.

## Client Libraries

| Library | Description | NuGet |
| :- | :- | :- |
| **[Bank Feeds](https://github.com/codatio/client-sdk-csharp/tree/main/bank-feeds)** | Set up bank feeds from accounts in your application to supported accounting platforms. | [Codat.BankFeeds](https://www.nuget.org/packages/Codat.BankFeeds) || **[Sync for Commerce](https://github.com/codatio/client-sdk-csharp/tree/main/sync-for-commerce)** | Push merchants' data from your ecommerce or point-of-sale (POS) platform into your merchants' accounting platform. | [Codat.Sync.Commerce](https://www.nuget.org/packages/Codat.Sync.Commerce) || **[Sync for Expenses](https://github.com/codatio/client-sdk-csharp/tree/main/sync-for-expenses)** | Push expenses to accounting platforms. | [Codat.Sync.Expenses](https://www.nuget.org/packages/Codat.Sync.Expenses) |

