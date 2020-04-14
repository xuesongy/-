using System;
using System.Collections.Generic;
using System.Text;

/*
 * Array 类
 * Array 类是 C# 中所有数组的基类，它是在 System 命名空间中定义。
 * Array 类提供了各种用于数组的属性和方法。
 */
 
 /* Array 类中一些最常用的属性：
 * IsFixedSize      获取一个值，该值指示数组是否带有固定大小
 * IsReadOnly       获取一个值，该值指示数组是否只读
 * Length           获取一个 32 位整数，该值表示所有维度的数组中的元素总数。
 * LongLength       获取一个 64 位整数，该值表示所有维度的数组中的元素总数。
 * Rank             获取数组的秩（维度）。
 */

/*
 * Array 类中一些最常用的方法：
 * Clear
 *      根据元素的类型，设置数组中某个范围的元素为零、为 false 或者为 null。
 * Copy(Array, Array, Int32)
 *      从数组的第一个元素开始复制某个范围的元素到另一个数组的第一个元素位置。
 *      长度由一个 32 位整数指定。
 * CopyTo(Array, Int32)
 *      从当前的一维数组中复制所有的元素到一个指定的一维数组的指定索引位置。
 *      索引由一个 32 位整数指定。
 * GetLength
 *      获取一个 32 位整数，该值表示指定维度的数组中的元素总数。
 * GetLongLength
 *      获取一个 64 位整数，该值表示指定维度的数组中的元素总数。
 * GetLowerBound
 *      获取数组中指定维度的下界。
 * GetType
 *      获取当前实例的类型。从对象（Object）继承。
 * GetUpperBound
 *      获取数组中指定维度的上界。
 * GetValue(Int32)
 *      获取一维数组中指定位置的值。索引由一个 32 位整数指定。
 * IndexOf(Array, Object)
 *      搜索指定的对象，返回整个一维数组中第一次出现的索引。
 * Reverse(Array)
 *      逆转整个一维数组中元素的顺序。
 * SetValue(Object, Int32)
 *      给一维数组中指定位置的元素设置值。索引由一个 32 位整数指定。
 * Sort(Array)
 *      使用数组的每个元素的 IComparable 实现来排序整个一维数组中的元素。
 *      注意：仅支持一维数组
 * ToString
 *      返回一个表示当前对象的字符串。从对象（Object）继承。
 */


namespace 面向对象 {
    class arrayClass {
        void AClass(int[] arr) {
            int Rindex = arr.Length;
            int[] arrs = new int[Rindex];

            // Copy(Array, Array, Int32)
            Array.Copy(arr, arrs, 3);
            arrayClass.printArray(arrs, Rindex, "Copy");

            // CopyTo(Array, Int32)
            arr.CopyTo(arrs, 0);
            arrayClass.printArray(arrs, Rindex, "CopyTo");

            // GetLength
            Console.WriteLine("arrs 获取一个32位整数，数组第 0 维度的元素总数：{0}", arrs.GetLength(0));

            // GetLongLength
            Console.WriteLine("arrs 获取一个64位整数，数组第 0 维度的元素总数：{0}", arrs.GetLongLength(0));

            // GetLowerBound
            Console.WriteLine("arr 数组第 0 维度的下界：{0}", arr.GetLowerBound(0));

            // GetUpperBound
            Console.WriteLine("arr 数组第 0 维度的上界：{0}", arr.GetUpperBound(0));

            // GetType
            Console.WriteLine("当前实例的类型：{0}", GetType());

            // GetValue(Int32)
            Console.WriteLine("arr 数组位置 2 的值：{0}", arr.GetValue(2));

            // IndexOf(Array, Object)
            Console.WriteLine("数值 13 在数组 arr 中所在的位置：{0}", Array.IndexOf(arr, 13));

            // Reverse(Array)
            arr.CopyTo(arrs, 0);
            Array.Reverse(arrs);
            arrayClass.printArray(arrs, Rindex, "Reverse");

            // SetValue(Object, Int32)
            arr.CopyTo(arrs, 0);
            arrs.SetValue(55, 0);
            arrayClass.printArray(arrs, Rindex, "SetValue");

            // Sort(Array)
            arr.CopyTo(arrs, 0);
            Array.Sort(arrs);
            arrayClass.printArray(arrs, Rindex, "Sort");

            // ToString
            Console.WriteLine(arr.ToString());
        }

        static void printArray(int[] arr, int Rindex, String name) {
            Console.Write("使用 Array 类的 {0} 方法的数组：", name);
            foreach (int i in arr) {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Array.Clear(arr, 0, Rindex - 1);     // 将数组元素全设为0
        }
        
        public static void arrayC() {
            arrayClass ac = new arrayClass();

            int[] list = { 34, 72, 13, 44, 25, 30, 10 };

            Console.WriteLine("原始数组：");
            foreach (int i in list) {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            Console.WriteLine("=========================================");
            Console.WriteLine("方法：");

            ac.AClass(list);
        }
    }
}
