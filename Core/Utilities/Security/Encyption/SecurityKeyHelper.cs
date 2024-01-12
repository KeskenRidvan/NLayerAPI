﻿using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace Core.Utilities.Security.Encyption;

public class SecurityKeyHelper
{
	public static SecurityKey CreateSecurityKey(string securityKey) => new SymmetricSecurityKey(Encoding.UTF8.GetBytes(securityKey));
}
