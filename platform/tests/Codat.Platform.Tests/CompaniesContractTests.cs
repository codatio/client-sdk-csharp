using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Codat.Platform;
using Codat.Platform.Models.Requests;
using Codat.Platform.Tests.TestDoubles;
using Xunit;

namespace Codat.Platform.Tests;

public class CompaniesContractTests
{
    private const string ListCompaniesResponseBody = """
    {
      "results": [],
      "pageNumber": 1,
      "pageSize": 100,
      "totalResults": 0,
      "_links": { "self": { "href": "/companies" }, "current": { "href": "/companies?page=1&pageSize=100" } }
    }
    """;

    [Fact]
    public async Task ListCompanies_emits_expected_request_and_deserialises_response()
    {
        var http = new TestSpeakeasyHttpClient();
        http.Handler.Setup(
            r => r.Method == HttpMethod.Get && r.RequestUri!.AbsolutePath == "/companies",
            HttpStatusCode.OK,
            ListCompaniesResponseBody);

        var sdk = new CodatPlatform(authHeader: "Basic not-a-real-credential", serverUrl: "http://localhost", client: http);

        var res = await sdk.Companies.ListAsync(new ListCompaniesRequest { Page = 1, PageSize = 100 });

        Assert.Equal(200, res.StatusCode);
        Assert.NotNull(res.Companies);
        Assert.NotNull(res.Companies!.Results);
        Assert.Empty(res.Companies.Results);

        var sent = Assert.Single(http.Handler.Requests);
        Assert.Equal("/companies", sent.RequestUri!.AbsolutePath);
        Assert.Contains("page=1", sent.RequestUri.Query);
        Assert.Contains("pageSize=100", sent.RequestUri.Query);
        Assert.True(sent.Headers.Contains("Authorization"));
    }
}
