using Bai3_SinhVien.Model;


namespace Bai3_SinhVien.Repository
{
    public class PersonalInfoRepository
    {
        private const string ProvinceFilePath = "DM_TinhThanh.txt";
        private const string PersonalInfoFilePath = "ThongTinSV.txt";
        private readonly string _ethnicityFilePath = "DanToc.txt";

        public List<string> LoadProvinces()
        {
            var provinces = new List<string>();
            try
            {
                // Nên để file ở Debug nó sẽ đọc đúng
                using (StreamReader reader = new StreamReader(ProvinceFilePath))
                {
                    while (!reader.EndOfStream)
                    {
                        provinces.Add(reader.ReadLine());
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error loading provinces: " + ex.Message);
            }

            return provinces;
        }
        public List<string> LoadEthnicities()
        {
            var ethnicities = new List<string>();
            try
            {
                using (StreamReader reader = new StreamReader(_ethnicityFilePath))
                {
                    while (!reader.EndOfStream)
                    {
                        ethnicities.Add(reader.ReadLine());
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error loading ethnicities: " + ex.Message);
            }

            return ethnicities;
        }
        public void SavePersonalInfo(PersonalInfo info)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(PersonalInfoFilePath))
                {
                    writer.WriteLine(info.Name);
                    writer.WriteLine(info.BirthDate);
                    writer.WriteLine(info.Email);
                    writer.WriteLine(info.Phone);
                    writer.WriteLine(info.Ethnicity);
                    writer.WriteLine(info.Province);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error saving personal information: " + ex.Message);
            }
        }
    }
}
