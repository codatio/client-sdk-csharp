using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Codat.Platform.Tests.TestDoubles;

public sealed class MockHttpMessageHandler : HttpMessageHandler
{
    private readonly List<(Func<HttpRequestMessage, bool> Predicate, Func<HttpResponseMessage> Response)> _responses = new();

    public List<HttpRequestMessage> Requests { get; } = new();

    public void Setup(Func<HttpRequestMessage, bool> predicate, HttpStatusCode status, string jsonBody) =>
        _responses.Add((predicate, () => new HttpResponseMessage(status)
        {
            Content = new StringContent(jsonBody, Encoding.UTF8, "application/json"),
        }));

    protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
    {
        Requests.Add(request);
        var match = _responses.LastOrDefault(r => r.Predicate(request));
        if (match.Response is null)
        {
            throw new InvalidOperationException($"No response configured for: {request.Method} {request.RequestUri}");
        }

        return Task.FromResult(match.Response());
    }
}
