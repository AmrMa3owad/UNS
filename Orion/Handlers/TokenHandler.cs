//using Microsoft.IdentityModel.Tokens;
//using Orion.Shared.Authorization;
//using System.IdentityModel.Tokens.Jwt;
//using System.Security.Claims;
//using System.Text;

//namespace Orion.Handlers
//{
//    public class TokenHandler : ITokenHandler
//    {
//        private readonly IConfiguration Configuration;
//        public TokenHandler(IConfiguration configuration)
//        {
//            Configuration = configuration;
//        }

//        public string GenerateJSONWebToken
//            (UserDTO userInfo, Guid? orgId, List<string>? roleNames, List<string>? permissions)
//        {
//            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["Jwt:Key"]));
//            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

//            List<Claim> claims = new List<Claim>
//            {
//                new Claim(ClaimTypes.Name, userInfo.UserName),
//                new Claim(ClaimTypes.Email, userInfo.Email),
//                new Claim(CustomClaimTypes.FirstName, userInfo.FirstName),
//                new Claim(CustomClaimTypes.LastName, userInfo.LastName),
//                new Claim(ClaimTypes.NameIdentifier, userInfo.Id.ToString()),
//            };

//            if (roleNames != null)
//            {
//                foreach (var item in roleNames)
//                {
//                    claims.Add(new Claim(ClaimTypes.Role, item));
//                }
//            }

//            var token = new JwtSecurityToken(
//                Configuration["Jwt:Issuer"],
//                Configuration["Jwt:Audience"],
//                claims,
//                expires: DateTime.Now.AddMinutes(60),
//                signingCredentials: credentials);

//            return new JwtSecurityTokenHandler().WriteToken(token);
//        }
//    }
//}