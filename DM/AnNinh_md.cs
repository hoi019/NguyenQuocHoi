using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
	public class AnNinh_md
	{
		[Required]
		public string taiKhoan { get; set; }

		[Required]
		public string matKhau { get; set; }
	}

	public class CaiDat
	{
		public string tuKhoa { get; set; }
	}
}
