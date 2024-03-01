using Microsoft.AspNetCore.Identity;

namespace NZWalks.API.Models.DTO.Auth
{
    public interface ITokenRepository
    {
       string CreateJWTToken(IdentityUser user, List<string> roles);

    }
}
