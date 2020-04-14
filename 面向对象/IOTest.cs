using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace 面向对象 {
    class IOTest {

        // Path 类的使用
        void PathClass() {
            string str = @"C:\Users\y1424\Music\虾米音乐\system\xm_data.db";

            Console.WriteLine(Path.GetFileName(str));   // 获取文件名及扩展名
            Console.WriteLine(Path.GetFileNameWithoutExtension(str));   // 只获取文件名
            Console.WriteLine(Path.GetExtension(str));  // 只获取文件扩展名
            Console.WriteLine(Path.GetDirectoryName(str));  // 获取路径
            Console.WriteLine(Path.GetFullPath(str));   // 取完整路径

            Console.WriteLine(Path.Combine(@"C:\logpath", @"Movie\复仇者联盟4.avi"));    // 连接路径
            //string[] strs = str.Split(new char[] { '\\' });
            //string b = strs[strs.Length-1].Remove(strs[strs.Length - 1] .IndexOf('.'));
        }

        // File 类的使用
        // File：字符。对文件一次性读取和写入，对于几百字节的小文本文件适合使用 File。
        void FileClass() {

            //File.Create(@"C:\Users\y1424\Desktop\my1Text.txt");      // 创建文件
            //Console.WriteLine("文件创建成功！");

            //File.Delete(@"C:\Users\y1424\Desktop\my*.txt");        // 删除文件
            //Console.WriteLine("文件删除成功！");

            // 复制文件
            //File.Copy(@"C:\Users\y1424\Desktop\my2Text.txt", @"C:\Users\y1424\Desktop\myNewText.txt");
            //Console.WriteLine("文件复制成功");

            // 以行的形式读文件
            //string[] allText = File.ReadAllLines(@"C:\Users\y1424\Desktop\my1Text.txt");
            //foreach (string item in allText) {
            //    Console.WriteLine(item);
            //}

            // 读取全部 text 的形式
            //string allText = File.ReadAllText(@"C:\Users\y1424\Desktop\my1Text.txt");
            //Console.WriteLine(allText);

            // 以字节的形式读取
            //byte[] buffer = File.ReadAllBytes(@"C:\Users\y1424\Desktop\my1Text.txt");
            //string str = Encoding.GetEncoding("UTF-8").GetString(buffer);
            //Console.WriteLine(str);

            // 以数组的形式写入文件，它会先创建文件，在向文件中写入
            //File.WriteAllLines(@"C:\Users\y1424\Desktop\my1Text.txt", new string[] { "hi", "heado", "ahdod" });

            // 以字符串的形式写入文件,它会先创建文件，在向文件中写入
            File.WriteAllText(@"C:\Users\y1424\Desktop\my1Text.txt", "nihaoabab");

            string read_myText = File.ReadAllText(@"C:\Users\y1424\Desktop\my1Text.txt");
            Console.WriteLine(read_myText);

        }

        // FileStream 文件流类
        // FileStream：字节，所有文件都以字节存储，因此什么都能操作。
        void FileStreamClass() {
            // 读文件
            //FileStream fsRead = new FileStream(@"C:\Users\y1424\Desktop\my1Text.txt", FileMode.OpenOrCreate, FileAccess.Read);
            //byte[] buffer = new byte[1024 * 1024 * 5];
            //int r = fsRead.Read(buffer, 0, buffer.Length);
            //string r1 = Encoding.Default.GetString(buffer, 0, r);
            //Console.WriteLine(r1);

            //fsRead.Close();
            //fsRead.Dispose();

            // 写文件
            using (FileStream fsWrite = new FileStream(@"C:\Users\y1424\Desktop\new.txt", FileMode.OpenOrCreate, FileAccess.Write)) {
                string word = "我是一个爱学习的孩子，学习是一件幸福事情，请让我一直幸福下去吧！";
                byte[] buffer = Encoding.Default.GetBytes(word);
                fsWrite.Write(buffer, 0, buffer.Length);
            }

            Console.WriteLine(File.ReadAllText(@"C:\Users\y1424\Desktop\new.txt"));
        }

        // MemoryStream
        // 派生自基类 Stream，用于向内存读写数据，更趋向于底层内存的操作，这样能够达到更快的速度和性能。
        // 
        // MemoryStream 封装
        //      以无符号字节数组形式存储的数据，该数组在创建对象时被初始化，或者该数组可创建为空数组；
        //      可在内存中直接访问这些封装的数据；
        //      内存流可降低应用程序中对临时缓冲区和临时文件的需要。
        // 
        // MemoryStream 类封装一个字节数组，在构造实例时可以使用一个字节数组作为参数，但是数组的长度无法调整。
        // 使用默认无参数构造函数创建实例，可以使用 Write 方法写入，随着字节数据的写入，数组的大小自动调整
        //
        // 读取 MemoryStream 类中数据流
        //      1. 使用 seek 方法定位读取器的当前的位置，可以通过指定长度的数组一次性读取指定长度的数据；
        //      2. ReadByte 方法每次读取一个字节，并将字节返回一个整数值。
        //
        // UnicodeEncoding 类
        //      定义了 Unicode 中 UTF-16 编码的相关功能
        //      通过其中的方法，将字符串转化为字节
        //      也可以将字节转换为字符串   
        //
        // MemoryStream 是一个特例，它没有任何非托管资源，所以它也可以不调用 Dispose 释放资源；
        // 托管资源 .Net 会自动回收；
        // 内存流的好处：指针可以随意访问，也就是支持 CanSeek, Position 属性，以及 Seek() 方法。这样可以任意读取其中一段。
        //
        // MemoryStream 类中的属性：
        // CanRead              已重写             获取一个值，该值指示当前流是否支持读取
        // CanSeek              已重写             获取一个值，该值指示当前流是否支持查找
        // CanTimeout                              获取一个值，该值确定当前流是否可以超时（从 Stream 继承）
        // CanWrite             已重写             获取一个值，该值指示当前流是否支持写入
        // Length               已重写             获取用字节表示的流长度
        // Position             已重写             获取或设置流中的当前位置
        // ReadTimeout                             获取或设置一个值，该值确定流在超时前尝试读取多长时间（从 Stream 继承）
        // WriteTimeout                            获取或设置一个值，该值确定流在超时前尝试写入多长时间（从 Stream 继承）
        //
        // MemoryStream 类中的方法：
        // BeginRead                               开始异步读操作（从 Stream 继承）
        // BeginWrite                              开始异步写操作（从 Stream 继承）
        // Close                                   关闭当前流并释放与之关联的所有资源（如套接字和文件句柄）（从 Stream 继承）
        // Dispose              已重载             释放资源
        // EndRead                                 等待挂起的异步读取完成（从 Stream 继承）
        // EndWrite                                结束异步写操作（从 Stream 继承）
        // Flush                已重写             重写 Stream.Flush 以便不执行任何操作
        // GetBuffer                               返回从其创建此流的无符号字节数组（是会返回所有分配的字节，不管用没用到）
        // GetLifetimeService                      检索控制此实例的生存期策略的当前生存期服务对象（从 MarshalByRefObject 继承）
        //
        // Read (参数1, 参数2, 参数3)     已重写     1. 从当前流中读取字节块并将数据写入 buffer 中
        //                                           2. 参数1：读取到的内容要输出到的字节数组
        //                                           3. 参数2：放在第一个参数即要输出的数组的位置的偏移量
        //                                           4. 参数3：要读取的字符数
        //                                           5. 注意：Read() 方法是从当前流的 Position 属性的位置开始读，
        //                                              如果我们刚刚向内存写入数据，Read() 方法无法直接读取到内容，
        //                                              因为刚刚写入内存之后，位置恰好是在末尾
        //                                           6. read 方法强大之处：可以从一个内存流中读取任何一个片段
        //
        // ReadByte             已重写             从当前流中读取一个字节
        // Seek                 已重写             将当前流中的位置设置为指定值
        // SetLength            已重写             将当前流的长度设置为指定值
        // ToArray                                 将整个流内容写入字节数组，而与 Position 属性无关
        // 
        // Write (参数1, 参数2, 参数3)    已重写     使用从缓冲区读取的数据将字节块写入当前流。
        //                                           注意：其第二个参数是第一个参数数组的偏移量
        //
        // WriteByte            已重写             将一个字节写入当前流中的当前位置
        // WriteTo                                 将此内存流的整个内容写入另一个流中

        // 内存数据流读写


        public static void IOT() {
            IOTest iot = new IOTest();
            iot.FileStreamClass();
        }
    }
}
