using System;

namespace Structures01t03
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass=new MyClass();
            myClass.shange = "not changed";

            MyStruct muStruct;
            muStruct.shange = "not changed";

            ClassTaker(myClass);
            StructTaker(muStruct); // понятно, что значение при вызове метода изменено не будет. Нужно использовать ref 
            //StructTaker(ref muStruct);

            Console.WriteLine(myClass.shange);
            Console.WriteLine(muStruct.shange);


            static void ClassTaker(MyClass myClass)
            {
                myClass.shange = "changed";
            }

            static void StructTaker(MyStruct myStruct)
            {
                myStruct.shange = "changed";
            }

            //static void StructTaker(ref MyStruct myStruct)
            //{
            //    myStruct.shange = "changed";
            //}

            
        }

    }
}
