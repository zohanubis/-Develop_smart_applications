using Bai3_SinhVien.Model;
using Bai3_SinhVien.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3_SinhVien.Service
{
    public class PersonalInfoService
    {
        private readonly PersonalInfoRepository _repository;

        public PersonalInfoService()
        {
            _repository = new PersonalInfoRepository();
        }

        public List<string> GetProvinces()
        {
            return _repository.LoadProvinces();
        }
        public List<string> GetEthnicities()
        {
            return _repository.LoadEthnicities();
        }
        public (bool IsValid, string ErrorMessage) ValidateInfo(PersonalInfo info)
        {
            // Kiểm tra xem tất cả các trường có được nhập đủ không
            if (string.IsNullOrEmpty(info.Name) ||
                string.IsNullOrEmpty(info.Phone) ||
                string.IsNullOrEmpty(info.Email) ||
                string.IsNullOrEmpty(info.BirthDate) ||
                info.Ethnicity == null) // Giả sử Ethnicity là một kiểu dữ liệu có thể kiểm tra null
            {
                return (false, "All fields must be filled out.");
            }

            // Kiểm tra tên
            if (!info.Name.All(char.IsLetter))
            {
                return (false, "Name must contain only letters.");
            }

            // Kiểm tra số điện thoại
            if (!info.Phone.All(char.IsDigit))
            {
                return (false, "Phone number must contain only digits.");
            }

            // Kiểm tra email
            if (!info.Email.Contains("@"))
            {
                return (false, "Email must contain '@'.");
            }

            // Kiểm tra ngày sinh (giả sử định dạng là "dd/MM/yyyy")
            if (!DateTime.TryParseExact(info.BirthDate, "dd/MM/yyyy",
                                        System.Globalization.CultureInfo.InvariantCulture,
                                        System.Globalization.DateTimeStyles.None, out _))
            {
                return (false, "Birthdate must be in the format 'dd/MM/yyyy'.");
            }

            return (true, string.Empty);
        }

        public void SaveInfo(PersonalInfo info)
        {
            _repository.SavePersonalInfo(info);
        }
    }
}
