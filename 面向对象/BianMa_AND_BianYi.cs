using System;
using System.Collections.Generic;
using System.Text;

namespace 面向对象 {
    class BianMa_AND_BianYi {
        /// 编码和编译
        /// 
        /// 编码：将字符串以什么样的形式保存为计算机可以识别和处理的二进制。
        /// 二进制数据       a : 1000 1110
        /// 美国人设计了最早的 ASC 码 --> 128 位
        /// ASCII --> 256 位
        /// GB2312 国标编码 --> 只包含简体汉字
        /// Big5 --> 包含繁体字
        /// Unicode --> 囊括全球编码方式，但有一个问题：编码解析起来耗时
        /// UTF-8 --> web 的编码方式
        /// 
        /// 我们使用计算机对文件进行操作的时候，经常碰到乱码，
        /// 产生乱码的原因，就是保存这个文件时采用的编码方式，和打开这个文件时采用的编码方式不一致造成的。
        /// 
        /// 编译：
        ///     C 语言的 exe 文件（机器码），任何操作系统都能运行
        ///     C# 的 exe 文件，不是机器码（cpu不可理解），系统没有安装 dotnet framewor 不能运行，framework及时编译just in time
        /// 
    }
}
