using System.Net.Http;
using System.Threading.Tasks;
using Codat.Platform.Utils;

namespace Codat.Platform.Tests.TestDoubles;

public sealed class TestSpeakeasyHttpClient : SpeakeasyHttpClient
{
    private readonly HttpClient _client;

    public MockHttpMessageHandler Handler { get; }

    public TestSpeakeasyHttpClient()
    {
        Handler = new MockHttpMessageHandler();
        _client = new HttpClient(Handler);
    }

    public override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request) =>
        _client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
}
