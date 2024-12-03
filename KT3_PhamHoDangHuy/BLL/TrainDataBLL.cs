using DTO;
using DAL;
using System.Collections.Generic;



namespace BLL
{
    public class TrainDataBLL
    {
        private TrainDataDAL dal = new TrainDataDAL();

        public TrainDataBLL()
        {
            
        }

        // Lấy tất cả dữ liệu
        public List<Train_Data_> GetAllData()
        {
            return dal.GetAll();
        }

        // Thêm dữ liệu
        public bool AddData(Train_Data_ data)
        {
            return dal.Insert(data);
        }

        // Sửa dữ liệu
        public bool UpdateData(Train_Data_ data)
        {
            return dal.Update(data);
        }

        // Xóa dữ liệu
        public bool DeleteData(double id)
        {
            return dal.Delete(id);
        }
    }
}
