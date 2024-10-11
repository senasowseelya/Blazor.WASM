using Blazor.WASM.Contracts;
using Blazor.WASM.Pages.Account;
using Blazor.WASM.StateFactory;
using Microsoft.AspNetCore.Components;

namespace Blazor.WASM.Components;

public class BaseComponent : ComponentBase
{
    [Inject] protected NavigationManager NavigationManager { get; set; }
    [Inject] protected ILocalStorageProvider LocalStorage { get; set; }
    [Inject] protected IAccountManagement AccountManagement { get; set; }
    
    protected override async Task OnInitializedAsync()
    {
        if (this.Equals(typeof(Login)))
            return;

        bool isAuthenticated = await AccountManagement.CheckAuthenticatedAsync();
        if (!isAuthenticated)
        {
            await AccountManagement.LogoutAsync();
            NavigationManager.NavigateTo("/login");
        }
    }
}