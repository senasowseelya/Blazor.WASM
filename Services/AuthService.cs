﻿using Blazor.WASM.Common;
using Blazor.WASM.Common.Models;
using Blazor.WASM.Contracts;

namespace Blazor.WASM.Services
{
    public class AuthService : BaseService, IAuthService
    {
        public AuthService(IHttpClientFactory httpClientFac) : base(httpClientFac)
        {
        }

        public async Task<ApiResponse<LoginResult>> LoginAsync(LoginRequest loginModel)
        {
            var response = await base.PostAsync<LoginRequest, LoginResult>(Endpoint.Token, loginModel);
            return response;
        }

        public async Task<ApiResponse<bool?>> LogoutAsync()
        {
            var response = await base.PostAsync<bool?>(Endpoint.Logout);
            return response;
        }

        public async Task<ApiResponse<UserContext>> GetUserContextAsync()
        {
            var result = await base.GetAsync<UserContext>(Endpoint.UserInfo);
            return result;
        }
    }
}
