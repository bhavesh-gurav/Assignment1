using System;

namespace oops
{

    class ClassObjectDemo
    {
        public int a;
    }

    struct StructureReferenceDemo
    {
        public int a;
    }

    //======================================================================================================


    public class Encapsulation
    {
        public int pu;
        protected int prot;
        private int priv;

        public Encapsulation()
        {
            priv = 10;
        }

        public void AccessibleDemoFun()
        {
            priv = 10;
            prot = 20;
        }
    }

    //======================================================================================================

    class EncapsulationInheritanceChildDemo:Encapsulation
    {
        public void AccessibleDemoDirectChildClass()
        {
            prot = 20;
        }
    }

    class EncapsulationInheritanceSubChildDemo : EncapsulationInheritanceChildDemo
    {
        public void AccessibleDemoFunOfSubChildClass()
        {
            prot = 20;
        }
    }



    //=====================================================================================================

    class Polymorphism_FunctionOverloading
    {
        public void Demo()
        {
            Console.WriteLine("This is First Method......");
        }
        public void Demo(int a)
        {
            Console.WriteLine("This is Second Method......");
        }
        public void Demo(int a, char b)
        {
            Console.WriteLine("This is Third Method........");
        }
    }

    //====================================================================================================

    class BaseCls
    {
        public virtual void DemoFun()
        {
            Console.WriteLine("Base Class First Function");
        }
        public void DemoFun2()
        {
            Console.WriteLine("Base class second function");
        }
    }
    class Derived_Cls : BaseCls
    {
        public override void DemoFun()
        {
            base.DemoFun();
            Console.WriteLine("Derived class first function");
        }
        public void DemoFun2()
        {
            Console.WriteLine("Derived class second Function");
        }
    }
    class Derivedsub_Cls : Derived_Cls
    {
        public override void DemoFun()
        {
            base.DemoFun();
            Console.WriteLine("sub derived class first function");
        }
        public void DemoFun2()
        {
            Console.WriteLine("sub derived class second function");
        }
    }

//===================================================================================================================

    abstract class parentabstract
    {
        public void parentabsnormal_fun()
        {
            Console.WriteLine("Normal Method of abstract class");
        }
        public abstract void parentabs_fun();
    }

    abstract class Abstractclass2 : parentabstract
    {
        public abstract void abstract_fun2();
        public void AbstractNormal_Fun()
        {
            Console.WriteLine("Normal Method of abstract class");
        }

        public override void parentabs_fun()
        {
            Console.WriteLine("Abstract method of abstract class");
        }
    }

    class Childclass : Abstractclass2
    {
        public override void abstract_fun2()
        {
            Console.WriteLine("Abstract Method of Abstract Class");
        }
        public void child_Fun()
        {
            Console.WriteLine("Normal Method of Child Class");
        }

        public override void parentabs_fun()
        {
            Console.WriteLine("Abstract Method of Abstract Class");
        }
    }

    //=============================================================================================

    interface IParent
    {
        void IAbsDemo();
    }
    interface IParent2
    {
        void IAbsDemo();
    }
    class InterfaceDemo_CLS : IParent, IParent2
    {
        void IParent.IAbsDemo()
        {
            Console.WriteLine("Interface IParent Method Override.");
        }
        void IParent2.IAbsDemo()
        {
            Console.WriteLine("Interface IParent2 Method Override.");
        }
    }
    class InterfaceDemo_CLS2 : IParent, IParent2
    {

        void IParent.IAbsDemo()
        {
            Console.WriteLine("Interface IParent Method Override.");
        }
        void IParent2.IAbsDemo()
        {
            Console.WriteLine("Interface IParent2 Method Override.");
        }
    }
    class InterfaceDemo_CLS3 : IParent, IParent2
    {

        void IParent.IAbsDemo()
        {
            Console.WriteLine("Interface IParent Method Override.");
        }
        void IParent2.IAbsDemo()
        {
            Console.WriteLine("Interface IParent2 Method Override.");
        }
    }

    //============================================================================================

    static class DemoStaticCLS
    {
        public static int a;
    }

    class DemoStaticCLSWithNormal
    {
        public int a1;
        public static int b;
    }

    public class NormalSealedCLSDemo
    {
        public int a2 = 300;
    }

    sealed class DemoSealedCLS : NormalSealedCLSDemo
    {
        public int InheritDemo;
    }

    public partial class DemoParCLS
    {
        public int p1;
    }

    public partial class DemoParCLS
    {
        public int p2;
    }

    public class ChildCLS : DemoParCLS
    {
        public int child;
    }

    public static class program
    {
        public static void Main(string[] args)
        {

            ClassObjectDemo classObjectDemo1 = new ClassObjectDemo();

            ClassObjectDemo classObjectDemo2 = new ClassObjectDemo();

            ClassObjectDemo ClassObjectDemo3 = new ClassObjectDemo();

            ClassObjectDemo classObjectDemo4 = new ClassObjectDemo();

            ClassObjectDemo classObjectDemo5 = new ClassObjectDemo();

            ClassObjectDemo classObjectDemo6 = classObjectDemo1;

            ClassObjectDemo classObjectDemo7 = classObjectDemo2;

            ClassObjectDemo classObjectDemo8 = ClassObjectDemo3;

            ClassObjectDemo classObjectDemo9 = classObjectDemo4;

            ClassObjectDemo classObjectDemo10 = classObjectDemo5;

            ClassObjectDemo classObjectDemo11 = classObjectDemo6;

            ClassObjectDemo classObjectDemo12 = classObjectDemo7;

            classObjectDemo1.a = 10;

            classObjectDemo2.a = 20;

            ClassObjectDemo3.a = 30;

            classObjectDemo4.a = 40;

            classObjectDemo5.a = 50;

            classObjectDemo5.a = 60;

            classObjectDemo6.a = 70;

            classObjectDemo7.a = 80;

            classObjectDemo9.a = 90;

            classObjectDemo10.a = 100;

            classObjectDemo11.a = 110;

            classObjectDemo12.a = 120;

            Console.WriteLine("Value of Demo1 :" + classObjectDemo1.a);
            Console.WriteLine("Value of Demo2 :" + classObjectDemo2.a);
            Console.WriteLine("Value of Demo3 :" + ClassObjectDemo3.a);
            Console.WriteLine("Value of Demo4 :" + classObjectDemo4.a);
            Console.WriteLine("Value of Demo5 :" + classObjectDemo5.a);
            Console.WriteLine("Value of Demo6 :" + classObjectDemo6.a);
            Console.WriteLine("Value of Demo7 :" + classObjectDemo7.a);
            Console.WriteLine("Value of Demo8 :" + classObjectDemo8.a);
            Console.WriteLine("Value of Demo9 :" + classObjectDemo9.a);
            Console.WriteLine("Value of Demo10 :" + classObjectDemo10.a);
            Console.WriteLine("Value of Demo11 :" + classObjectDemo11.a);
            Console.WriteLine("Value of Demo12 :" + classObjectDemo12.a);

  //===========================================================================================================

            StructureReferenceDemo structureReferenceDemo1 = new StructureReferenceDemo();

            StructureReferenceDemo structureReferenceDemo2 = new StructureReferenceDemo();

            StructureReferenceDemo structureReferenceDemo3 = new StructureReferenceDemo();

            StructureReferenceDemo structureReferenceDemo4 = new StructureReferenceDemo();
            
            StructureReferenceDemo structureReferenceDemo5 = new StructureReferenceDemo();

            StructureReferenceDemo structureReferenceDemo6 = structureReferenceDemo1;

            StructureReferenceDemo structureReferenceDemo7 = structureReferenceDemo2;

            StructureReferenceDemo structureReferenceDemo8 = structureReferenceDemo3;

            StructureReferenceDemo structureReferenceDemo9 = structureReferenceDemo4;

            StructureReferenceDemo structureReferenceDemo10 = structureReferenceDemo5;

            StructureReferenceDemo structureReferenceDemo11 = structureReferenceDemo6;

            StructureReferenceDemo structureReferenceDemo12 = structureReferenceDemo7;

            structureReferenceDemo1.a = 100;
            structureReferenceDemo2.a = 200;
            structureReferenceDemo3.a = 300;
            structureReferenceDemo4.a = 400;
            structureReferenceDemo5.a = 500;
            structureReferenceDemo6.a = 600;
            structureReferenceDemo7.a = 700;
            structureReferenceDemo8.a = 800;
            structureReferenceDemo9.a = 900;
            structureReferenceDemo10.a = 1000;
            structureReferenceDemo11.a = 2000;
            structureReferenceDemo12.a = 3000;

            Console.WriteLine("Value of structure1 :" +structureReferenceDemo1.a);
            Console.WriteLine("Value of structure2 :" +structureReferenceDemo2.a);
            Console.WriteLine("Value of structure3 :" + structureReferenceDemo3.a);
            Console.WriteLine("Value of structure4 :" + structureReferenceDemo4.a);
            Console.WriteLine("Value of structure5 :" + structureReferenceDemo5.a);
            Console.WriteLine("Value of structure6 :" + structureReferenceDemo6.a);
            Console.WriteLine("Value of structure7 :" + structureReferenceDemo7.a);
            Console.WriteLine("Value of structure8 :" + structureReferenceDemo8.a);
            Console.WriteLine("Value of structure9 :" + structureReferenceDemo9.a);
            Console.WriteLine("Value of structure10 :" + structureReferenceDemo10.a);
            Console.WriteLine("Value of structure11 :" + structureReferenceDemo11.a);
            Console.WriteLine("Value of structure12 :" + structureReferenceDemo12.a);

 //==============================================================================================================

            Encapsulation En = new Encapsulation();
            En.pu = 100;

            EncapsulationInheritanceChildDemo EnCL = new EncapsulationInheritanceChildDemo();
            EnCL.pu = 101;

            Console.WriteLine("Public Variable Value:" + En.pu + "-" + EnCL.pu);

            EncapsulationInheritanceSubChildDemo EnSCL = new EncapsulationInheritanceSubChildDemo();
            EnSCL.pu = 102;

            Console.WriteLine("Public Variable Value:" + En.pu + "-" + EnCL.pu + "-" + EnSCL.pu);

            OOPS_Inheritance.inheritanceinothernamespace oops_EnI = new OOPS_Inheritance.inheritanceinothernamespace();
            oops_EnI.pu = 100;
            Console.WriteLine("Public Variable Value:" + En.pu + "-" + EnCL.pu + "-" + oops_EnI.pu);

            //==================================================================================================================

            Polymorphism_FunctionOverloading PL = new Polymorphism_FunctionOverloading();
            PL.Demo();
            PL.Demo(1);
            PL.Demo(2, 'A');

 //=================================================================================================================

            BaseCls B_Cls = new BaseCls();
            B_Cls.DemoFun();
            B_Cls.DemoFun2();

            Derived_Cls D_Cls = new Derived_Cls();
            D_Cls.DemoFun();
            D_Cls.DemoFun2();

            Derivedsub_Cls SD_Cls = new Derivedsub_Cls();
            SD_Cls.DemoFun();
            SD_Cls.DemoFun();

//=================================================================================================================

            Childclass c_class = new Childclass();
            c_class.AbstractNormal_Fun();
            c_class.abstract_fun2();
            c_class.child_Fun();
            c_class.parentabs_fun();
            c_class.parentabsnormal_fun();

            Abstractclass2 Abs_class2 = new Childclass();
            Abs_class2.abstract_fun2();
            Abs_class2.AbstractNormal_Fun();
            Abs_class2.AbstractNormal_Fun();
            Abs_class2.parentabsnormal_fun();

//=============================================================================================

            IParent ICls = new InterfaceDemo_CLS();
            ICls.IAbsDemo();

            ICls = new InterfaceDemo_CLS2();
            ICls.IAbsDemo();

            ICls = new InterfaceDemo_CLS3();
            ICls.IAbsDemo();

//============================================================================================

            DemoStaticCLS.a = 10;


            DemoStaticCLSWithNormal DSWN = new DemoStaticCLSWithNormal();
            DSWN.a1 = 100;

            DemoStaticCLSWithNormal.b = 200;

            DemoParCLS DPC = new DemoParCLS();
            DPC.p1 = 300;
            DPC.p2 = 400;

            ChildCLS CCLS = new ChildCLS();
            CCLS.p1 = 1000;
            CCLS.p2 = 1000;

            Console.WriteLine("This is new programe");

            Console.ReadKey();
        }
    }
}

namespace OOPS_Inheritance
{
    class inheritanceinothernamespace : oops.Encapsulation
    {
        public void Directchildindifferentnamespace()
        {
            prot = 20;
        }
    }
}