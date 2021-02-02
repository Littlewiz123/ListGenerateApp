using System;
using System.Collections.Generic;
using System.Text;

namespace ListGenerateApp
{
    abstract class BaseInformation 
    {
        // In kiểu và mã Hash (mã duy nhất) của đối tượng
        public void ShowInfo() => Console.WriteLine($"{this.GetType().Name}-{this.GetHashCode()}");
        // In thông báo - khi đối tượng được tạo
        public void NotifyCreate() => Console.WriteLine($"{this.GetType().Name} created");
    }

    class A : BaseInformation
    {
        public A() => NotifyCreate();
    }

    class B : BaseInformation
    {
        A dependency;
        // Inject bằng hàm tạo
        public B(A dependency)
        {
            this.dependency = dependency;
            NotifyCreate();
        }
    }

    class C : BaseInformation
    {
        public C() => NotifyCreate();
    }

    class D : BaseInformation
    {
        A dependency;
        int x;
        public D(A dependency, int x)
        {
            this.dependency = dependency;
            this.x = x;
            NotifyCreate();
        }
    }
}
