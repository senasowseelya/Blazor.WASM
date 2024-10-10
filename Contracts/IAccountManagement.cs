using Blazor.WASM.Common.Models;

namespace Blazor.WASM.Contracts
{
    public interface IAccountManagement
    {
        Task<AuthenticationResult> LoginAsync(LoginRequest request);
        Task LogoutAsync();
        Task<bool> CheckAuthenticatedAsync();
    }
}
