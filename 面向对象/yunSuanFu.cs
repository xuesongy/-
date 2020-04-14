using System;
using System.Collections.Generic;
using System.Text;

/*
 * 了解 C# 中所有可用的运算符
 */

namespace 面向对象 {
    class yunSuanFu {
        // 算数运算符
        public static void yunSuan() {
            int a = 21;
            int b = 10;
            int c;

            c = a + b;
            Console.WriteLine("Line 1 - c 的值是 {0}", c);
            c = a - b;
            Console.WriteLine("Line 2 - c 的值是 {0}", c);
            c = a * b;
            Console.WriteLine("Line 3 - c 的值是 {0}", c);
            c = a / b;
            Console.WriteLine("Line 4 - c 的值是 {0}", c);
            c = a % b;
            Console.WriteLine("Line 5 - c 的值是 {0}", c);

            // ++a 先进行自增运算在赋值
            c = ++a;
            Console.WriteLine("Line 6 - c 的值是 {0}", c);

            // 此时 a 的值为 22
            // --a 先进行自减运算再赋值
            c = --a;
            Console.WriteLine("Line 7 - c 的值是 {0}", c);
            Console.ReadKey();
        }
        public static void yunSuan2() {
            /*
             * c = a++: 先将 a 赋值给 c，再对 a 进行自增运算
             * c = ++a: 先将 a 进行自增运算，再对 a 赋值给 c
             * c = a--: 先将 a 赋值给 c，再对 a 进行自减运算
             * c = --a: 先将 a 进行自减运算，再将 a 赋值给 c
             */
            int a = 1;
            int b;

            // a++ 先赋值再进行自增运算
            b = a++;
            Console.WriteLine("a = {0}\nb = {1}", a, b);
            Console.WriteLine("--------------------------------");

            // ++a 先进行自增运算再赋值
            a = 1; // 重新初始化 a
            b = ++a;
            Console.WriteLine("a = {0}\nb = {1}", a, b);
            Console.WriteLine("--------------------------------");

            // a-- 先赋值再进行自减运算
            a = 1; // 重新初始化 a
            b = a--;
            Console.WriteLine("a = {0}\nb = {1}", a, b);
            Console.WriteLine("--------------------------------");

            // --a 先进行自减运算再赋值
            a = 1; // 重新初始化 a
            b = --a;
            Console.WriteLine("a = {0}\nb = {1}", a, b);
            Console.WriteLine("--------------------------------");
        }

        // 关系运算符
        public static void guanxi() {
            int a = 21;
            int b = 10;

            // 判断 a 是否等于 b
            if (a == b) {
                Console.WriteLine("Line 1 - a 等于 b");
            } else {
                Console.WriteLine("Line 1 - a 不等于 b");
            }

            // 判断 a 是否小于 b
            if (a < b) {
                Console.WriteLine("Line 2 - a 小于 b");
            } else {
                Console.WriteLine("Line 2 - a 不小于 b");
            }

            // 判断 a 是否大于 b
            if (a > b) {
                Console.WriteLine("Line 3 - a 大于 b");
            } else {
                Console.WriteLine("Line 3 - a 不大于 b");
            }

            /* 改变 a 和 b 的值 */
            a = 5;
            b = 20;

            // 判断 a 是否小于或等于 b
            if (a <= b) {
                Console.WriteLine("Line 4 - a 小于或等于 b");
            }

            // 判断 a 是否大于或等于 b
            if (a >= b) {
                Console.WriteLine("Line 5 - a 大于或等于 b");
            }
        }

        // 逻辑运算符
        public static void luoji() {
            bool a = true;
            bool b = true;

            if (a && b) {
                Console.WriteLine("Line 1 - 条件为真");
            }
            if (a || b) {
                Console.WriteLine("Line 2 - 条件为真");
            }

            /* 改变 a 和 b 的值 */
            a = false;
            b = true;

            if (a && b) {
                Console.WriteLine("Line 3 - 条件为真");
            } else {
                Console.WriteLine("Line 3 - 条件不为真");
            }
            if (!(a && b)) {
                Console.WriteLine("Line 4 - 条件为真");
            }

        }

        // 位运算
        public static void wei() {
            /*
             * &  与          全1出1，有0出0          二元运算符
             * |  或          全0出0，有1出1          二元运算符
             * ^  异或        相同出0，不同出1        二元运算符
             * ~  按位取反    0反转为1，1反转为0      一元运算符
             * << 左移        左操作数的值向左移动    二元运算符
             *                右操作数指定的位数
             * >> 右移        左操作数的值向右移动    二元运算符
             *                右操作数指定的位数
             */
            int a = 60;     /* 60 = 0011 1100 */
            int b = 13;     /* 13 = 0000 1101 */
            int c = 0;

            c = a & b;      /* 12 = 0000 1100 */
            Console.WriteLine("Line 1 - c 的值是 {0}", c);

            c = a | b;      /* 61 = 0011 1101*/
            Console.WriteLine("Line 2 - c 的值是 {0}", c);

            c = a ^ b;      /* 49 = 0011 0001 */
            Console.WriteLine("Line 3 - c 的值是 {0}", c);

            c = ~a;         /* -61 = 1100 0011*/
            Console.WriteLine("Line 4 - c 的值是 {0}", c);

            c = a << 2;     /* 240 = 1111 0000*/
            Console.WriteLine("Line 5 - c 的值是 {0}", c);

            c = a >> 2;     /* 15 = 0000 1111 */
            Console.WriteLine("Line 6 - c 的值是 {0}", c);

        }

        // 赋值运算符
        public static void fuzhi() {
            /*
             * =    简单的赋值运算符，把右边操作数的值赋给左边操作数
             * +=   加且赋值运算符，把右边操作数加上左边操作数的结果赋值给左边操作数
             * -=   减且赋值运算符，把左边操作数减去右边操作数的结果赋值给左边操作数
             * *=   乘且赋值运算符，把右边操作数乘以左边操作数的结果赋值给左边操作数
             * /=   除且赋值运算符，把左边操作数除以右边操作数的结果赋值给左边操作数
             * %=   求模且赋值运算符，求两个操作数的模赋值给左边操作数
             * <<=  左移且赋值运算符
             * >>=  右移且赋值运算符
             * &=   按位与且赋值运算符
             * ^=   按位异或且赋值运算符
             * |=   按位或且赋值运算
             */

            int a = 21;
            int c;

            c = a;
            Console.WriteLine("Line 1 - = c 的值 = {0}", c);

            c += a;
            Console.WriteLine("Line 2 - += c 的值 = {0}", c);

            c -= a;
            Console.WriteLine("Line 3 - -= c 的值 = {0}", c);

            c *= a;
            Console.WriteLine("Line 4 - *=  c 的值 = {0}", c);

            c /= a;
            Console.WriteLine("Line 5 - /=  c 的值 = {0}", c);

            c = 200;
            c %= a;
            Console.WriteLine("Line 6 - %=  c 的值 = {0}", c);

            c <<= 2;
            Console.WriteLine("Line 7 - <<=  c 的值 = {0}", c);

            c >>= 2;
            Console.WriteLine("Line 8 - >>=  c 的值 = {0}", c);

            c &= 2;
            Console.WriteLine("Line 9 - &=  c 的值 = {0}", c);

            c ^= 2;
            Console.WriteLine("Line 10 - ^=  c 的值 = {0}", c);

            c |= 2;
            Console.WriteLine("Line 11 - |=  c 的值 = {0}", c);
        }

        // 其他运算符
        public static void qita() {
            /*
             * sizeof()     返回数据类型的大小
             * typeof()     返回 class 的类型
             * &            返回变量的地址
             * *            变量的地址
             * ？：         条件表达式
             * is           判断对象是否为某一类型
             * as           强制转换，即使转换失败也不会抛出异常
             */

            /* sizeof 运算符的实例 */
            Console.WriteLine("int 的大小是 {0}", sizeof(int));
            Console.WriteLine("short 的大小是 {0}", sizeof(short));
            Console.WriteLine("double 的大小是 {0}", sizeof(double));

            /* 三元运算符的实例 */
            int a, b;
            a = 10;
            b = (a == 1) ? 20 : 30;
            Console.WriteLine("b 的值是 {0}", b);

            b = (a == 10) ? 20 : 30;
            Console.WriteLine("b 的值是 {0}", b);
        }
    }
}
