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
         * 线程的优先级：
         *      可以通过 Thread 类中的 Priority 属性设置
         *      Priority 属性是一个 ThreadPriority 枚举类型
         *      其包含 5 个值：
         *          Highest         可以将 Thread 安排在具有任何其他优先级的线程之前。
         *          
         *          AboveNormal     可以将 Thread 安排在具有 Highest 优先级的线程之后，
         *                          在具有 Normal 优先级的线程之前。
         *                          
         *          Normal          可以将 Thread 安排在具有 AboveNormal 优先级的线程之后，
         *                          在具有 BelowNormal 优先级的线程之前。
         *                          
         *          BelowNormal     可以将 Thread 安排在具有 Normal 优先级的线程之后，
         *                          在具有 Lowest 优先级的线程之前。
         *                          
         *          Lowest          可以将 Thread 安排在具有任何其他优先级的线程之后。
         * 
         * 线程和人的生老病死一样，线程是一个动态执行的过程，它也有一个从产生到消亡的过程，
         * 在整个过程中，线程可能处在不同的状态，线程的状态由 Thread 类中的 ThreadState 属性表示。
         * 
         * C# 中的线程状态：
         *      Unstarted           线程尚未开始运行
         *      Running             线程正在运行
         *      Suspended           线程已经被挂起
         *      
         *      SuspendRequested    正在请求挂起线程，但还未来得及相应
         *      WaitSleepJoin       由于调用方法 Wait()、Sleep() 或 Join() 而使线程处于阻塞状态
         *      
         *      Stopped             线程已经停止
         *      StoppedRequested    请求停止线程
         *      
         *      AbortRequested      已调用了方法 Abort()，但还未收到 ThreadAbortException 异常
         *      Aborted             线程处于停止状态
         *      
         *      Background          线程在后台运行
         * 
         * 线程在创建之后就处于上面某一状态中。
         * 
         */
        static void show_MainThread() {
            // 没有做任何的线程操作，系统会默认生成一个线程，它就是主线程。
            Thread.CurrentThread.Name = "主线程";
            Console.WriteLine("正在运行的线程是：" + Thread.CurrentThread.Name + ", 状态为：" + Thread.CurrentThread.ThreadState);
            Console.ReadLine();
            
        }
        static void show_ThreadPriority() {
            // 线程 1
            Thread ThreadOne = new Thread(delegate () {
                for (int i = 0; i <= 200000; i++) {
                    if (i % 200 == 0) {
                        Console.Write("One");
                    }
                }
            });
            // 线程 1
            Thread ThreadTwo = new Thread(delegate () {
                for (int i = 0; i <= 200000; i++) {
                    if (i % 200 == 0) {
                        Console.Write("Two");
                    }
                }
            });

            ThreadOne.Start();
            ThreadTwo.Start();

            // 主线程
            for (int i = 0; i <= 200000; i++) {
                if (i % 200 == 0) {
                    Console.Write("Three");
                }
            }
        }

        // 修改 show_ThreadPriority 方法，
        // 分别设置两个子线程的优先级为 AboveNormal 和 BelowNormal
        // 主线程默认优先级不变
        static void show_ThreadPriority2() {
            // 线程 1
            Thread ThreadOne = new Thread(delegate () {
                for (int i = 0; i <= 200000; i++) {
                    if (i % 200 == 0) {
                        Console.Write("One");
                    }
                }
            });
            // 线程 1
            Thread ThreadTwo = new Thread(delegate () {
                for (int i = 0; i <= 200000; i++) {
                    if (i % 200 == 0) {
                        Console.Write("Two");
                    }
                }
            });

            ThreadOne.Priority = ThreadPriority.AboveNormal;    // 线程1 优先级设为 AboveNormal
            ThreadTwo.Priority = ThreadPriority.BelowNormal;    // 线程 2 优先级设为 BelowNormla

            ThreadOne.Start();
            ThreadTwo.Start();

            // 主线程，默认优先级为 Normal
            for (int i = 0; i <= 200000; i++) {
                if (i % 200 == 0) {
                    Console.Write("Three");
                }
            }
        }

        public static void ThreadMain() {
            //show_MainThread();
            //show_ThreadPriority();
            show_ThreadPriority2();
        }
    }
}
