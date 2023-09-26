using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
	public partial interface ITaiKhoan_repo
	{
		TaiKhoan_repo Login(string taiKhoan, string matKhau);
	}
}
