using Blazor.WASM.Common.Models;
using Blazor.WASM.Contracts;
using Microsoft.AspNetCore.Components.Authorization;

namespace Blazor.WASM.StateFactory
{
    public class ApiAuthStateProvider : AuthenticationStateProvider, IAccountManagement
    {
        public Task<bool> CheckAuthenticatedAsync()
        {
            throw new NotImplementedException();
        }

        public override Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            throw new NotImplementedException();
        }

        public Task<AuthenticationResult> LoginAsync(LoginRequest request)
        {
            throw new NotImplementedException();
        }

        public Task LogoutAsync()
        {
            throw new NotImplementedException();
        }
    }
}
