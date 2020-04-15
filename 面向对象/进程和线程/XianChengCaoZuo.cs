using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace 面向对象.进程和线程 {
    class XianChengCaoZuo {
        /*
         * 线程操作
         * 
         * 默认情况下，进程会创建一个主线程（main thread）
         * 
         * C# 中使用 System.Threading 命名空间中的 Thread 类，来实现线程操作。
         * Thread 类提供了属性和方法，可以方便我们控制线程
         * 
         * Thread 常用属性：
         *      Name                        线程的名称
         *      CurrentThread               获取当前正在运行的线程
         *      Priority                    线程优先级
         *      ThreadState                 当前线程状态
         *      
         * Thread 常用方法：
         *      Start()                     开始执行线程
         *      Suspend()                   挂起线程
         *      Resume()                    恢复被挂起线程
         *      Sleep()                     将当前线程暂停一段时间
         *      Join()                      待旧线程结束后执行新线程
         *      Abort()                     终止线程
         *      
         * 一般创建一个子线程需要 3 个步骤：
         *      1. 编写入口函数，也就是子线程所要执行的代码
         *         private void EntryPointMethod(){}   // 入口函数
         *      
         *      2. 创建入口委托
         *         ThreadStart entryPoint = new ThreadStart(EntryPointMethod);   // 委托
         *         
         *      3. 创建线程
         *         Thread workThread = new Thread(entryPoint);  // 创建线程
         *         
         *      一般将 2、3 步骤合为一句：
         *         Thread workThread = new Thread(new ThreadStart(EntryPointMethod));
         * 
         */
        static void show_MainThread() {
            // 没有做任何的线程操作，系统会默认生成一个线程，它就是主线程。
            Thread.CurrentThread.Name = "主线程";
            Console.WriteLine("正在运行的线程是：" + Thread.CurrentThread.Name + ", 状态为：" + Thread.CurrentThread.ThreadState);
            Console.ReadLine();
        }

        public static void ThreadMain() {
            show_MainThread();
        }
    }
}
