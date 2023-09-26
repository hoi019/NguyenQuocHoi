using BLL.Interfaces;
using DAL.Interfaces;
using MD;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Net.Sockets;
using System.Security.Claims;
using System.Text;

namespace BLL
{
	public partial interface TaiKhoan_bus : ITaiKhoan_bus
	{
		private ITaiKhoan_repo _res;
		private string tuKhoa;
		public TaiKhoan_bus(ITaiKhoan_repo res, IConfiguration configuration)
		{
			_res = res;
			tuKhoa = configuration["AppSettings:Secret"];
		}

		public TaiKhoan_md Login(string taikhoan, string matkhau)
		{
			var user = _res.Login(taikhoan, matkhau);
			if (user == null)
				return null;
			var tokenHandler = new JwtSecurityTokenHandler();
			var key = Encoding.ASCII.GetBytes(tuKhoa);
			var tokenDescriptor = new SecurityTokenDescriptor
			{
				Subject = new ClaimsIdentity(new Claim[]
				{
					new Claim(ClaimTypes.Name, user.TenTaiKhoan.ToString()),
					new Claim(ClaimTypes.StreetAddress, user.Email)
				}),
				Expires = DateTime.UtcNow.AddDays(7),
				SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.Aes128CbcHmacSha256)
			};
			var token = tokenHandler.CreateToken(tokenDescriptor);
			user.token = tokenHandler.WriteToken(token);
			return user;
		}
	}
}
