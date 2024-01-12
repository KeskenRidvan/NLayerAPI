using Microsoft.IdentityModel.Tokens;

namespace Core.Utilities.Security.Encyption;

public class SigningCredentialsHelper
{
	public static SigningCredentials CreateSigningCredentials(SecurityKey securityKey) => new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha512Signature);
}
