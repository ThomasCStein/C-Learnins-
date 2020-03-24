using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC440_19MAR
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle myRectangle = new Rectangle();
            myRectangle.Length = 10;
            myRectangle.Width = 20;
            Console.WriteLine( myRectangle.ComputeArea());

            Console.WriteLine();

            
            int x=2 , y = 5;
            Console.WriteLine("BEFORE SWAP: x= {0}, y = {1}", x, y);//pass by value
            Swap(x, y);
            Console.WriteLine("AFTER SWAP: x= {0}, y = {1}", x, y);

            int xx = 22, yy = 55;
            Console.WriteLine("BEFORE SWAP: xx= {0}, yy = {1}", xx, yy);
            Swap2(ref xx, ref yy);
            Console.WriteLine("AFTER SWAP: xx= {0}, yy = {1}", xx, yy);

            Console.WriteLine();
            Console.WriteLine();

            MyMethod(7, 3.0, "cat", 21);
            
            MyMethod(70, 6.0, "meow", 25 );
            
            int someOtherValue=5;
            string someOtherValue2;
            int someValue = MyMethod2(out someOtherValue, out someOtherValue2);
            //Console.WriteLine("{0} {1}", someValue + someOtherValue);

            //int.TryParse();

            MyUnlimitedMethod(1);
            MyUnlimitedMethod(1,2);
            MyUnlimitedMethod(12,3,4,5,6);

            try
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(Divide(7, 2));
                Console.WriteLine(Divide(7, 0 ));

                int[] myValues = { 2, 4, 5, 8, 9 };
                Console.WriteLine(ReadOutsideArray(myValues));
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine("You dividied by 0");
            }
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine("You reached outside the legal range");
                Console.WriteLine(e.Message);
                Console.WriteLine("You reached outside the legal range");
            }
            catch (Exception e)//catch all
            {
                Console.WriteLine("Something Else...bro");
            }
            Console.WriteLine("The code continues");
            CallCallMethod();

            try
            {
                throw new NotImplementedException();
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e);
            }
            finally//gets executed regardless of whether exception was handled or not
            {
                Console.WriteLine("MSSA");
            }
            Console.WriteLine("MSSA2" ); //will only be executed if the block above gets handled
        }
      public static void  Swap (int x, int y)
        {
            int temp = x;
            x = y;
            y = temp;
            Console.WriteLine("AFTER SWAP: x= {0}, y = {1}", x, y);
        }

        public static void Swap2(ref int xx, ref int yy)
        {
            int temp = xx;
            xx = yy;
            yy = temp;
            Console.WriteLine("AFTER SWAP: xx= {0}, yy = {1}", xx, yy);
        }
        public static void MyMethod(int a, double b, string c = "MSSA", int d = 50)
        {
            Console.WriteLine("a={0}, b={1}, c={2}, d={3}", a, b, c, d);
        }
        public static int MyMethod2(out int anotherValue, out string anotherValue2)
        {
            anotherValue= 8; anotherValue2 = "SMU";
            anotherValue = 9; anotherValue2 = "SMU2";
            return 7;
            return 8;//never reached because of preceding return
        }
    
        public static void MyUnlimitedMethod(params int[] args)
        {
            Console.WriteLine("the arguments you passed are: ");
            foreach (var value in args)
            {
                Console.WriteLine(value + " ");
            }
            Console.WriteLine();
        }

        public static double Divide(int a, int b)
        {
            if (b!=0)
            {
                double result = (double)a / b;
                return result;
            }
            else
            {
                throw new DivideByZeroException();
            }
            
        }
        public static int ReadOutsideArray(int[] arr)
        {
            return arr[arr.Length];
        }

        public static void Method()
        {
            throw new Exception("Method!");//exception without try/catch
            Console.WriteLine(1);
        }
        public static void CallMethod()
        {
            try
            {
                Method();
            }
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine(e);
                throw;
            }
            Console.WriteLine(2);
        }

        public static void CallCallMethod()
        {
            try
            {
                CallMethod();
            }
            catch (Exception e)
            {
                Console.WriteLine("CallCallMethod caught all exceptions");
                throw;
            }
            Console.WriteLine(3);
        }

    }
    class Rectangle
    {
        public int Length { get; set; }
        public int Width { get; set; }
        public double ComputeArea()
        {
            double area = Length * Width;
            return area;
        }
        public double ComputerPerimeter()
        {
            double perimeter = (Length * 2) + (Width * 2);
            return perimeter;
        }
    }
}
