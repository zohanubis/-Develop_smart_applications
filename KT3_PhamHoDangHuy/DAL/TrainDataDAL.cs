
using System.Collections.Generic;
using System.Linq;

using DTO;

namespace DAL
{
    public class TrainDataDAL
    {
        private QL_KHACHHANGDataContext db = new QL_KHACHHANGDataContext();

        public TrainDataDAL()
        {
            
        }

        public List<Train_Data_> GetAll()
        {
            return db.Train_Data_s.ToList();
        }

        // Thêm dữ liệu
        public bool Insert(Train_Data_ data)
        {
            try
            {
                db.Train_Data_s.InsertOnSubmit(data);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        // Sửa dữ liệu
        public bool Update(Train_Data_ data)
        {
            try
            {
                var existingData = db.Train_Data_s.FirstOrDefault(t => t.ID == data.ID);
                if (existingData != null)
                {
                    existingData.Gender = data.Gender;
                    existingData.Ever_Married = data.Ever_Married;
                    existingData.Age = data.Age;
                    existingData.Graduated = data.Graduated;
                    existingData.Profession = data.Profession;
                    existingData.Work_Experience = data.Work_Experience;
                    existingData.Spending_Score = data.Spending_Score;
                    existingData.Family_Size = data.Family_Size;
                    existingData.Var_1 = data.Var_1;
                    existingData.Segmentation = data.Segmentation;

                    db.SubmitChanges();
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        // Xóa dữ liệu
        public bool Delete(double id)
        {
            try
            {
                var data = db.Train_Data_s.FirstOrDefault(t => t.ID == id);
                if (data != null)
                {
                    db.Train_Data_s.DeleteOnSubmit(data);
                    db.SubmitChanges();
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }
    }
}
