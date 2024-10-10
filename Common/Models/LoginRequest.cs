using System.ComponentModel.DataAnnotations;

namespace Blazor.WASM.Common.Models
{
    public class LoginRequest
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
