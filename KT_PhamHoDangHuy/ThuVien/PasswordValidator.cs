using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ThuVien
{
    public class PasswordValidator
    {
        public static bool IsStrongPassword(string password)
        {
            // Kiểm tra mật khẩu có ít nhất 1 chữ thường
            bool hasLowerChar = Regex.IsMatch(password, @"[a-z]");
            // Kiểm tra mật khẩu có ít nhất 1 chữ hoa
            bool hasUpperChar = Regex.IsMatch(password, @"[A-Z]");
            // Kiểm tra mật khẩu có ít nhất 1 chữ số
            bool hasNumber = Regex.IsMatch(password, @"\d");
            // Kiểm tra mật khẩu có ít nhất 1 ký tự đặc biệt
            bool hasSpecialChar = Regex.IsMatch(password, @"[\W_]");

            // Mật khẩu mạnh khi thoả tất cả các điều kiện trên
            return hasLowerChar && hasUpperChar && hasNumber && hasSpecialChar;
        }
    }
}
