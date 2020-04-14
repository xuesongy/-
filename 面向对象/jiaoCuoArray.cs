using System;
using System.Collections.Generic;
using System.Text;
/*
 * 交错数组
 * 交错数组是数组的数组
 * 交错数组是一维数组
 * 您可以声明一个带有 int 值的交错数组 scores,如：int [][] scores;
 * 声明一个数组不会再内存中创建数组
 */
namespace 面向对象 {
    class jiaoCuoArray {
        public void Array1() {
            // 您可以初始化一个交错数组
            int[][] scores = new int[2][] {
                new int[]{92,93,94},
                new int[]{85,66,87,88}
            };
            // 其中，scores 是一个由两个整形数组组成的数组
            // scores[0] 是一个带有 3 个整数的数组
            // scores[1] 是一个带有 4 个整数的数组
        }

        public void Array2() {
            // 初始化一个交错数组
            int[][] a = new int[][] {
                new int[]{0,0},
                new int[]{1,2},
                new int[]{2,4},
                new int[]{3,6},
                new int[]{4,8}
            };

            int i, j;

            // 输出数组中每个元素的值
            for (i = 0; i < 5; i++) {
                for (j = 0; j < 2; j++) {
                    Console.WriteLine("a[{0}][{1}] = {2}", i, j, a[i][j]);
                }
            }
        }

        public static void jArray() {
            jiaoCuoArray jca = new jiaoCuoArray();
            jca.Array2();
        }

    }
}
