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
        void MemoryStreamClass() {
            // 新建流
            MemoryStream ms = new MemoryStream();
            Console.WriteLine(ms.CanRead);  // True，表明内存流可读
            Console.WriteLine(ms.CanSeek);  // True，表明内存流可查找
            Console.WriteLine(ms.CanWrite); // True，表明内存流可写
            Console.WriteLine(ms.Capacity); // 0，表明分配给该流的字节数为零

            // 将字符串 "www.hbsi.edu.cn" 转换为 UTF8 编码的字节数组，赋值给 bytes
            byte[] bytes = Encoding.UTF8.GetBytes("www.hbsi.edu.cn");
            // 将 bytes 中所有的内容写入到内存流中，0 代表数组的开始，bytes.Length 代表偏移量
            ms.Write(bytes, 0, bytes.Length);
            Console.WriteLine(ms.Capacity); // 256，当前分配给该流的字节为 256
            Console.WriteLine(ms.Length);   // 15，实际占用 15 字节，对应长度为该字符串的长度
            Console.WriteLine(ms.Position); // 15，流当前的位置为 15，15 为该流末位的往后一位

            byte[] byte1 = ms.GetBuffer();  // 获取流中的内容
            string str1 = Encoding.UTF8.GetString(byte1);   // 将读取的内容转换成字符赋值给字符串
            Console.WriteLine(str1);        // www.hbsi.edu.cn

            // 改变当前流的位置，之前流的位置在末尾，-1 代表向前移动一位，Current 代表当前
            ms.Seek(-1, SeekOrigin.Current);
            int i = ms.ReadByte();          // 从流中读取当前字节
            Console.WriteLine(i);           // 110，110 正好对应 ASCII 中的 n


        }

        /// <summary>
        /// 文本文件读写
        /// 
        /// 文件：
        ///     一些具有永久存储及特定顺序的字节组成的一个有序的、具有名称的集合。
        ///     在各种介质上（如：可移动磁盘、硬盘、CD 等）存储的集合数据。
        ///     通常情况下，文件按照树状目录进行组织
        ///     每个文件都有文件名、文件所在路径、创建时间、访问权限等属性。
        ///     
        /// 文件分类：
        ///     文本文件：完全与字符和与字符的显示格式有关的控制符（如空格、回车符及换行符等）构成。
        ///               文本文件很容易在不同的操作系统、不同的软件中通用，只要这些系统和软件遵循相同的字符代码标准。
        ///               文本文件常用 .txt 作为扩展名
        ///               常见的文本文件扩展名还有：.BAT 和 .HTM
        ///     二进制文件：非文本文件，就是一些二进制数据。
        ///                 扩展名为：.COM、.EXE 等程序文件，.BMP(存放图像数据)、.WAV(存放声音数据) 等
        /// 
        /// 在处理文件时，会遇到流的问题。
        /// 什么是流：
        ///     定义：提供了连续的字节流存储空间，虽然数据实际存储的位置可能不连续，甚至可以分布在多个磁盘上，
        ///           但我们看到的是封装以后的数据结构，是连续的字节流抽象结构。
        ///     存储位置：网络中、内存中或者是磁带中。
        ///     
        /// 从硬盘中读取文件时，每读一个字节，就会自动流入下一个字节，这个字节只允许你读取一次。
        /// 在 .net 中，与文件操作有关系的类，在 System.IO 命名空间中
        /// System.IO 命名空间
        /// 定义：
        ///     C# 中对文件和流进行操作时必须要引用的一个命名空间，该命名空间中有很多的类，
        ///     用于进行数据文件和流的读写操作，这些操作可以同步进行也可以异步进行。
        ///     注意：要使用 System.IO 命名空间，窗体代码的顶部应加入语句：using System.IO
        /// 
        /// 文本文件的读写有 StreamWriter 对象和 StreamReader 对象
        /// 
        /// StreamWriter 对象：将数据写入文本文件
        /// 创建一个 StreamWriter对象 使用 new语句，如：
        ///     StreamWriter swFile = new StreamWriter("D:\\MyWork.txt");
        /// 
        /// StreamWriter 对象常用方法：
        ///     Write           写入字符串
        ///     WriteLine       写入一个字符串和一个换行符
        ///     Close           释放 StreamWriter 对象，并关闭打开的文件
        ///                     写完文件后，一定要用 Close 调用文件
        ///                     写文件时，操作系统只是把文件写到了缓冲区里，调用 Close 时，才会把缓冲区里的内容移到硬盘上
        ///                     
        /// StreamReader 对象：可以读取文本文件的信息
        /// 创建一个 StreamReader 对象：指定一个带有路径的文件名。如：
        ///     StreamReader srFile = new StreamReader("D:\\MyWork.txt");
        ///     
        /// StreamReader 对象常用方法：
        ///     Reade           从文件中读入下一个字符
        ///     ReadLine        从文件中读入下一行字符
        ///     Peek            返回文件中的下一个字符，但并不读入该字符
        /// </summary>

        /// 二进制文件的读写
        /// BinaryWriter 类和BinaryReader 类，它们可以将一个字符或数字按指定字节写入，也可以一次读取指定个数字节，转换为字符或数字。
        /// 只有构造了 FileStream 类以后，才能进一步构造 BinaryWriter 和 BinaryReader 对象，以获得更高级的功能。
        /// 
        /// BinaryReader 常用方法：
        ///     ReadBoolean         从当前流中读取 Boolean
        ///     ReadByte            从当前流中读取下一个字节
        ///     ReadBytes           从当前流中将 count 个字节读入字节数组
        ///     ReadChar            从当前流中读取下一个字符
        ///     ReadDouble          从当前流中读取 8 字节浮点值
        ///     ReadSingle          从当前流中读取 4 字节浮点值
        ///     ReadString          从当前流中读取一个字符串
        ///     
        /// BinaryWriter 常用方法：
        ///     Flush()             刷新二进制流
        ///     Seek()              设置当前流的位置
        ///     Write(Char)         将字符数组写入当前流
        ///     Write(Byte)         将一个无符号字节写入当前流
        ///     Write(Decimal)      将十进制数写入当前流
        ///     Write(Double)       将 8 字节浮点值写入当前流
        ///     Write(Short)        将 2 字节有符号整数写入当前流
        ///     Write(Integer)      将 4 字节有符号整数写入当前流
        ///     
        /// 不管是 BinaryReader 还是 BinaryWriter，这些方法都是从当前流读入数据或是写入数据，
        /// 均会根据读入或是写入数据所占的字节数，修改流的当前位置。
        /// 
        void BinaryROrW() {
            FileStream fileStream = new FileStream(@"C:\Users\y1424\Desktop\my1Text.txt", FileMode.Open, FileAccess.Write);
            BinaryWriter binaryWriter = new BinaryWriter(fileStream);
            binaryWriter.Write("C#基础教程");   // 向文件中写入图书C#基础教程的图书名称
            binaryWriter.Write(49.5);           // 向文件中写入图书的价格，价格为 49.5

            binaryWriter.Flush();               // 清除缓冲区的内容,将缓冲区的内容写入到文件中
            binaryWriter.Close();               // 关闭二进制流
            fileStream.Close();                 // 关闭文件流

            fileStream = new FileStream(@"C:\Users\y1424\Desktop\my1Text.txt", FileMode.Open, FileAccess.Read);
            BinaryReader binaryReader = new BinaryReader(fileStream);
            Console.WriteLine(binaryReader.ReadString());   // 输出图书名称
            Console.WriteLine(binaryReader.ReadDouble());   // 输出图书价格
            binaryReader.Close();               // 关闭二进制流
            fileStream.Close();                 // 关闭文件流
        }

        public static void IOT() {
            IOTest iot = new IOTest();
            iot.BinaryROrW();
        }
    }
}
