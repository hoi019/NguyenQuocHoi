using DAL.Interfaces;
using DataAccessLayer;
using MD;
using System;

namespace DAL
{
	public class TaiKhoan_repo : ITaiKhoan_repo
	{
		private IDatabaseHelper _dbHelper;
		public TaiKhoan_repo(IDatabaseHelper dbHelper)
		{
			_dbHelper = dbHelper;
		}
		public TaiKhoan_md Login(string taiKhoan, string matKhau)
		{
			string msgError = "";
			try
			{
				var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "sp_login",
					 "@taikhoan", taiKhoan,
					 "@matkhau", matKhau
					 );
				if (!string.IsNullOrEmpty(msgError))
					throw new Exception(msgError);
				return dt.ConvertTo<TaiKhoan_md>().FirstOrDefault();
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
