using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Randomness
{
    class Program
    {

        public static IEnumerable Method2()
        {
            yield return 3;
            yield return 5;
            yield return 7;
            yield return 19;
            yield return 93;
        }


        int[] arr = { 1, 4, 567, 678, 3, 435, 5, 3, 423 };
        static IEnumerable Method(int low, int hi)
        {

            for (int i = low; i < hi; i++)
            {
                if (i % 3 == 0)
                {
                    yield return i;
                }
            }
        }

        static void Main(string[] args)
        {
            //Console.WriteLine(Method());
            foreach (var n in Method(100,130))
            {
                Console.WriteLine(n);
            }
            foreach(var x in Method2())
            {
                Console.WriteLine(x);
            }


            int[] nums = { 2, 4, 6, 8, 10 };
            foreach (var num in nums)
            {
                Console.WriteLine(num);
            }

            Course CSC440 = new Course();
            CSC440.CourseName = "Intermediate C#";
            CSC440.AddStudent(new Student() { Name = "Alice", Major = "MSSA", GPA = 3.9 });
            CSC440.AddStudent(new Student() { Name = "Greg", Major = "Bussiness", GPA = 3.7 });
            CSC440.AddStudent(new Student() { Name = "Tom", Major = "Oceanography", GPA = 4.0 });
            CSC440.AddStudent(new Student() { Name = "Joe", Major = "Kickin' Butt", GPA = 3.0 });
            CSC440.AddStudent(new Student() { Name = "Walt", Major = "Undecided", GPA = 4.0 });

            foreach (Student st in CSC440)
            {
                Console.WriteLine(st.Name, st.Major, st.GPA);
            }
            //foreach (Student st in CSC440.GetBackEnumerator())
            //{

            //}

            MyList<string> myList = new MyList<string>();
        }
            public class Student
            {
                public string Name { get; set; }
                public string Major { get; set; }
                public double GPA { get; set; }
            }
        public class Course : IEnumerable
        {
            public string CourseName { get; set; }
            List<Student> roster;
            public void AddStudent(Student st)
            {
                roster.Add(st);
            }
            public Course()
            {
                roster = new List<Student>();
            }
            public IEnumerator GetEnumerator()
            {
                foreach (var st in roster)
                {
                    yield return st;
                }
                //throw new NotImplementedException();
            }
            public IEnumerator GetBackEnumerator()
            {
                for (int i = roster.Count - 1; i >= 0; i--)
                {
                    yield return roster[i];
                }
                throw new NotImplementedException();
            }
            
        }
        
        public class MyList<T>: List<T>
        {

        }
    }
}
