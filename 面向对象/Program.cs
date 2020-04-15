using System;

namespace 面向对象
{
    class Program
    {
        class SampleClass {
            public int x;
            public int y;
            public const int c1 = 5;
            public const int c2 = c1 + 5;

            public SampleClass(int p1, int p2)
            {
                x = p1;
                y = p2;
            }
        }

        static void Main(string[] args)
        {
            // 运算符
            //yunSuanFu.yunSuan();
            //yunSuanFu.yunSuan2();
            //yunSuanFu.guanxi();
            //yunsuanfu.luoji();
            //yunSuanFu.wei();
            //yunSuanFu.fuzhi();
            //yunSuanFu.qita();

            // 阶乘
            //jiecheng jieC = new jiecheng();
            //int num = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("{0} 的阶乘 = {1}", num, jieC.jc(num));

            // 按引用传参
            //yinYongChuanCan.yycc();

            // 按输出传参
            //shuChuChuanCan.sccc();

            // 可空类型
            //keKongLeiXing.kklx();

            // 遍历三维数组
            //doubleArray.dArray();

            // 遍历交错数组
            //jiaoCuoArray.jArray();

            // 传递数组给函数
            //arrayForFunc.forFunc();

            // 参数数组
            //canShuArray.canShu();

            // Array 类
            //arrayClass.arrayC();

            // string
            //StringTest.strt();

            // string 类
            //StringClass.SCla();

            // IO
            //IOTest.IOT();

            // 线程
            进程和线程.XianChengCaoZuo.ThreadMain();

            //SampleClass mC = new SampleClass(11,22);
            //Console.WriteLine("x = {0}, y = {1}", mC.x, mC.y);
            //Console.WriteLine("c1 = {0}, c2 = {1}", SampleClass.c1, SampleClass.c2);
        }
    }
}
