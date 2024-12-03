using System;
using System.Linq;
using Accord.MachineLearning.DecisionTrees;
using Accord.MachineLearning.DecisionTrees.Learning;

namespace MLLibrary
{
    public class C45Classifier
    {
        /// <summary>
        /// Chạy thuật toán C4.5
        /// </summary>
        /// <param name="features">Dữ liệu đầu vào</param>
        /// <param name="labels">Nhãn thực tế</param>
        /// <returns>Độ chính xác của dự đoán</returns>
        public double RunC45(double[][] features, int[] labels)
        {
            // Định nghĩa các thuộc tính
            DecisionVariable[] attributes =
            {
                new DecisionVariable("credit_score", DecisionVariableKind.Continuous),
                new DecisionVariable("age", DecisionVariableKind.Continuous),
                new DecisionVariable("balance", DecisionVariableKind.Continuous),
                new DecisionVariable("products_number", DecisionVariableKind.Continuous),
                new DecisionVariable("estimated_salary", DecisionVariableKind.Continuous),
                new DecisionVariable("tenure", DecisionVariableKind.Continuous),
                new DecisionVariable("credit_card", 2),
                new DecisionVariable("active_member", 2)
            };

            // Khởi tạo cây quyết định với C4.5 (tương tự ID3)
            DecisionTree tree = new DecisionTree(attributes, 2);
            var teacher = new C45Learning(tree);
            teacher.Learn(features, labels);

            // Dự đoán dữ liệu
            int[] predictions = tree.Decide(features);

            // Tính độ chính xác
            return labels.Zip(predictions, (actual, predicted) => actual == predicted ? 1 : 0).Average() * 100;
        }
    }
}
