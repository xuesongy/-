using System;
using System.Collections.Generic;
using System.Text;

namespace 面向对象 {
    class jiecheng {
        public int jc(int num) {
            return (num > 0) ? num * jc(num - 1) : 1;
        }
    }
}
