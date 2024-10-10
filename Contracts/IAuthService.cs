using Blazor.WASM.Common.Models;

namespace Blazor.WASM.Contracts
{
    public interface IAuthService
    {
        Task<ApiResponse<LoginResult>> LoginAsync(LoginRequest loginModel);
        Task<ApiResponse<bool?>> LogoutAsync();
        Task<ApiResponse<UserContext>> GetUserContextAsync();
    }
}
