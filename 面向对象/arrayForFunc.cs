using System;
using System.Collections.Generic;
using System.Text;

/*
 * 传递数组给函数
 * 在 C# 中，您可以传递数组作为函数的参数。
 * 您可以通过指定不带索引的数组名称来给函数传递一个指向数组的指针
 */

namespace 面向对象 {
    class arrayForFunc {
        double getAverage(int[] arr, int size) {
            int i;
            double avg;
            int sum = 0;

            for (i = 0; i < size; ++i) {
                sum += arr[i];
            }
            avg = (double)sum / size;
            return avg;
        }
        // 也可以只传数组参数，数组大小不是必须
        double getAverage2(int[] arr) {
            int i;
            double avg;
            int sum = 0;
            for (i = 0; i < arr.Length; ++i) {
                sum += arr[i];
            }
            avg = (double)sum / arr.Length;
            return avg;
        }
        // 数组的遍历也可以用 foreach 来进一步简化
        double getAverage3(int[] arr) {
            double avg;
            int sum = 0;

            foreach (int i in arr) {
                sum += i;
            }
            avg = (double)sum / arr.Length;
            return avg;
        }
        // 传递交错数组作为参数
        int getArea(int[][] array) {
            int sum = 0;
            for (int j = 0; j < array.Length; j++) {
                foreach (int i in array[j]) {
                    sum += i;
                }
               
            }
            return sum;
        }
        public static void forFunc() {
            arrayForFunc aff = new arrayForFunc();

            int[][] array = new int[3][];
            array[0] = new int[] { 0, 1 };
            array[1] = new int[] { 2, 3, 4 };
            array[2] = new int[] { 5, 6, 7, 8 };
            int sum = aff.getArea(array);   // 函数名作为参数
            Console.WriteLine("{0}", sum);

            /*// 一个带有 5 个元素的 int 数组
            int[] balance = new int[] { 1000, 2, 3, 17, 50 };
            double avg;

            // 传递数组的指针作为参数
            //avg = aff.getAverage(balance, 5);
            //avg = aff.getAverage2(balance);
            avg = aff.getAverage3(balance);

            // 输出返回值
            Console.WriteLine("平均值是： {0}", avg);*/

        }
    }
}
