using System;
using System.Collections.Generic;
using System.Linq;
using DTO; 
using Accord.MachineLearning;
using Accord.Math;

namespace MLAI
{
    public class KmeansClass
    {
        private KMeans kmeans;
        private int k;

        public KmeansClass(int clusters)
        {
            k = clusters;
        }

        public double[][] LoadDataForTraining(QL_KHACHHANGDataContext db)
        {
            var data = db.Train_Data_s
                .Where(d => d.Gender != null && d.Ever_Married != null && d.Age.HasValue &&
                            d.Graduated != null && d.Profession != null && d.Work_Experience.HasValue &&
                            d.Spending_Score != null && d.Family_Size.HasValue)
                .Select(d => new Train_Data_
                {
                    Gender = d.Gender,
                    Ever_Married = d.Ever_Married,
                    Age = d.Age.Value,
                    Graduated = d.Graduated,
                    Profession = d.Profession,
                    Work_Experience = d.Work_Experience.Value,
                    Spending_Score = d.Spending_Score,
                    Family_Size = d.Family_Size.Value
                })
                .ToList();
           return PreprocessData(data);
        }

        public int[] TrainFromDatabase(QL_KHACHHANGDataContext db)
        {
            var trainData = LoadDataForTraining(db);

            kmeans = new KMeans(k);

            var clusters = kmeans.Learn(trainData);

            return clusters.Decide(trainData);
        }

        public Dictionary<int, List<double[]>> RunKmeans(List<Train_Data_> data)
        {
            var trainData = PreprocessData(data);

            kmeans = new KMeans(k);

            var clusters = kmeans.Learn(trainData);

            int[] labels = clusters.Decide(trainData);

            var clusteredData = new Dictionary<int, List<double[]>>();

            for (int i = 0; i < labels.Length; i++)
            {
                if (!clusteredData.ContainsKey(labels[i]))
                {
                    clusteredData[labels[i]] = new List<double[]>();
                }

                clusteredData[labels[i]].Add(trainData[i]);
            }

            return clusteredData;
        }

        private double[][] PreprocessData(IEnumerable<Train_Data_> data)
        {
            var processedData = new List<double[]>();

            foreach (var row in data)
            {
                processedData.Add(new double[]
                {
            (row.Gender == "Male") ? 1 : 0,
            (row.Ever_Married == "Yes") ? 1 : 0,
            row.Age ?? 0,
            (row.Graduated == "Yes") ? 1 : 0,
            ProfessionToNumeric(row.Profession),
            row.Work_Experience ?? 0,
            SpendingScoreToNumeric(row.Spending_Score),
            row.Family_Size ?? 0
                });
            }

            return processedData.ToArray();
        }


        private int ProfessionToNumeric(string profession)
        {
            var professions = new Dictionary<string, int>
            {
                { "Healthcare", 1 },
                { "Engineer", 2 },
                { "Artist", 3 },
                { "Doctor", 4 },
                { "Lawyer", 5 },
                { "Entertainment", 6 },
                { "Homemaker", 7 },
                { "Other", 8 }
            };

            return professions.ContainsKey(profession) ? professions[profession] : 0;
        }

        private int SpendingScoreToNumeric(string score)
        {
            switch (score)
            {
                case "Low":
                    return 1;
                case "Average":
                    return 2;
                case "High":
                    return 3;
                default:
                    return 0;
            }
        }
    }
}
