using System;
using System.Collections.Generic;
using System.Text;

/*
 * 参数数组
 * 有时，当声明一个方法时，您不能确定要传递给函数作为参数的参数数目。
 * C# 参数数组解决了这个问题，参数数组通常用于传递未知数量的参数给函数。
 * 
 * params 关键字
 * 在使用数组作为形参时，C# 提供了 params 关键字，
 * 使调用数组为形参的方法时，既可以传递数组实参，也可以传递一组数组元素。
 * 
 * params 的使用格式：
 * public 返回类型 方法名称( params 类型名称[] 数组名称 )
 */

namespace 面向对象 {
    class canShuArray {
        int AddElements(params int[] arr) {
            int sum = 0;
            foreach (int i in arr) {
                sum += i;
            }
            return sum;
        }

        public static void canShu() {
            canShuArray csa = new canShuArray();

            int sum = csa.AddElements(512, 720, 250, 567, 889);
            Console.WriteLine("总和是：{0}", sum);
        }
    }
}
