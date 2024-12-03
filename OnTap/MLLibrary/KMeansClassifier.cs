using System;
using System.Linq;
using Accord.MachineLearning;

namespace MLLibrary
{
    public class KMeansClassifier
    {
        /// <summary>
        /// Chạy thuật toán K-means
        /// </summary>
        /// <param name="features">Dữ liệu đầu vào</param>
        /// <param name="labels">Nhãn thực tế</param>
        /// <param name="clusters">Số cụm</param>
        /// <returns>Độ chính xác của phân cụm</returns>
        public double RunKMeans(double[][] features, int[] labels, int clusters = 2)
        {
            // Khởi tạo K-means
            KMeans kmeans = new KMeans(clusters);
            var clusterResult = kmeans.Learn(features);

            // Phân cụm dữ liệu
            int[] predictions = clusterResult.Decide(features);

            // Tính độ chính xác
            return labels.Zip(predictions, (actual, predicted) => actual == predicted ? 1 : 0).Average() * 100;
        }
    }
}
