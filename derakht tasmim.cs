using System;
using Accord.MachineLearning;
using Accord.MachineLearning.VectorMachines;
using Accord.MachineLearning.VectorMachines.Learning;
using Accord.Statistics.Kernels.Spaces;

namespace DecisionTreeExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // ویژگی‌ها: [سن، درآمد، وضعیت تأهل]
            double[][] inputs = 
            {
                new double[] { 25, 50000, 0 },
                new double[] { 30, 60000, 1 },
                new double[] { 22, 45000, 0 },
                new double[] { 35, 70000, 1 },
                new double[] { 40, 80000, 1 },
                new double[] { 29, 52000, 0 },
                new double[] { 50, 120000, 1 },
                new double[] { 23, 40000, 0 },
                new double[] { 33, 58000, 1 },
                new double[] { 27, 65000, 0 }
            };

            // برچسب‌ها: 0 = خرید نکرد، 1 = خرید کرد
            int[] outputs = { 0, 1, 0, 1, 1, 0, 1, 0, 1, 0 };

            // ایجاد و آموزش مدل درخت تصمیم
            var teacher = new C45Learning();
            var tree = new DecisionTree(3); // 3 ویژگی

            teacher.Run(tree, inputs, outputs);

            // پیش‌بینی برای داده‌های جدید
            double[] newData = { 28, 55000, 1 };
            int prediction = tree.Decide(newData);

            // چاپ نتیجه پیش‌بینی
            Console.WriteLine($"پیش‌بینی برای سن 28، درآمد 55000 و وضعیت تأهل متاهل: {prediction} (0 = خرید نکرد، 1 = خرید کرد)");
        }
    }
}