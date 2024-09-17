using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThuVien
{
    public class CodeGenerator
    {
        public static string GenerateAutoCode(int userDefinedValue)
        {
            // Lấy 2 ký tự cuối của năm hiện tại
            string yearPart = DateTime.Now.ToString("yy");
            // Lấy 2 ký tự cuối của tháng hiện tại
            string monthPart = DateTime.Now.ToString("MM");
            // Chuyển đổi giá trị do người dùng quy định thành chuỗi và bổ sung vào cuối
            string userPart = userDefinedValue.ToString("D2");

            // Kết hợp thành mã tự động
            return $"{yearPart}{monthPart}{userPart}";
        }
    }
}
