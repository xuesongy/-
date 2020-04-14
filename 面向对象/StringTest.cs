using System;
using System.Collections.Generic;
using System.Text;

/*
 * string
 * 在 C# 中，您可以使用字符数组来表示字符串，
 * 但是，更常见的做法是使用 string 关键字来声明字符串变量。
 * string 关键字是 System.String 类的别名。
 * 
 * 您可以使用以下方法之一来创建 string 对象：
 *      1. 通过给 String 变量指定一个字符串
 *      2. 通过使用 String 类构造函数
 *      3. 通过使用字符串串联运算符（+）
 *      4. 通过检索属性或调用一个返回字符串的方法
 *      5. 通过格式化方法来转换一个值或对象为它的字符串表示形式
 */

namespace 面向对象 {
    class StringTest {
        void strTest() {
            // 字符串，字符串连接
            string fname, lname;
            fname = "Rowan";
            lname = "Atkinson";

            string fullname = fname + lname;
            Console.WriteLine("Full Name: {0}", fullname);

            // 通过使用 string 构造函数
            char[] letters = { 'H', 'e', 'l', 'l', 'o' };
            string greetings = new string(letters);
            Console.WriteLine("Greetings: {0}", greetings);

            // 方法返回字符串
            string[] sarray = { "Hello", "From", "Tutorials", "Point" };
            string message = String.Join(" ", sarray);
            Console.WriteLine("Message: {0}", message);

            // 用于转化值的格式化方法
            DateTime waiting = new DateTime(2012, 10, 10, 17, 58, 1);
            string chat = String.Format("Message sent at {0:t} on {0:D}", waiting);
            Console.WriteLine("Message: {0}", chat);
        }

        public static void strt() {
            StringTest st = new StringTest();
            st.strTest();
        }
    }
}
