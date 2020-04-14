using System;
using System.Collections.Generic;
using System.Text;

namespace 面向对象 {
    class doubleArray {
        // 遍历三维数组
        public static void dArray() {
            int[,,] muarr = new int[2, 2, 3] {
                { {1,2,3},{4,5,6} },
                { {7,8,9},{2,3,4} }
            };

            int rank = muarr.Rank;
            Console.WriteLine("该多维数组的维数为：{0}", rank);
            int rlength = muarr.GetLength(1);
            Console.WriteLine("该多维数组的第二维有 {0} 个元素", rlength);
            Console.WriteLine("开始遍历多维数组");
            Console.WriteLine("------------------------------------");

            int wei = 0;
            for (int i = 0; i < muarr.GetLength(0); i++) {
                for (int js1 = 0; js1 < muarr.GetLength(1); js1++) {
                    for (int js2 = 0; js2 < muarr.GetLength(2); js2++) {
                        Console.WriteLine("最低维度{0}的值维 {1}", wei, muarr[i, js1, js2]);
                    }
                    ++wei;
                }
            }
        }
    }
}
