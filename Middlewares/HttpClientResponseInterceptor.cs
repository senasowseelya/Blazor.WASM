using System.Text;
using Blazor.WASM.Common.Models;
using Blazor.WASM.Extensions;

namespace Blazor.WASM.Middlewares;

public class HttpClientResponseInterceptor : DelegatingHandler
{
    public HttpClientResponseInterceptor()
    {
    }
    protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
    {

        var response = await base.SendAsync(request, cancellationToken);
        if (response.IsSuccessStatusCode)
        {
            return response;
        }
        var content = await response.Content.ReadAsStringAsync();
        var apiErrorResponse = content.ToObjectFromJson<ApiResponse<Dictionary<string, object>>>();
        var apiResponse = new ApiResponse<Object>
        {
            Data = null,
            ErrorResult = apiErrorResponse?.Data ?? [],
            IsSuccess = false,
            Message = apiErrorResponse?.Message ?? string.Empty,
        };
        response.Content = new StringContent(apiResponse.ToJson(), Encoding.UTF8, "application/json");
        return response;
    }
}