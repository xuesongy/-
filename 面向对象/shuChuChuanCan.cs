using System;
using System.Collections.Generic;
using System.Text;

namespace 面向对象 {
    class shuChuChuanCan {
        public void getValue(out int x) {
            int temp = 5;
            x = temp;
        }

        public void getValues(out int x, out int y) {
            
            Console.WriteLine("请输入第一个值：");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("请输入第二个值：");
            y = Convert.ToInt32(Console.ReadLine());
        }

        public static void sccc() {
            shuChuChuanCan sc = new shuChuChuanCan();

            /*// 局部变量定义
            int a = 100;

            Console.WriteLine("在方法调用之前，a 的值：{0}", a);

            // 调用函数来获取值
            sc.getValue(out a);

            Console.WriteLine("在方法调用之后，a 的值：{0}", a);*/

            // 提供给输出参数的变量不需要赋值。
            // 当需要从一个参数没有指定初始值的方法中返回值时，
            // 输出参数特别有用。
            int a, b;

            // 调用函数来获取值
            sc.getValues(out a, out b);

            Console.WriteLine("在方法调用之后，a 的值：{0}", a);
            Console.WriteLine("在方法调用之后，b 的值：{0}", b);

        }
    }
}
