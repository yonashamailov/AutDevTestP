using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutDevTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //Q1
            //Provide a method that gets this array as an input and the output should be the maximum revenue
            //array size:N
            //int[] arr2= {9,1 };
            int[] arr2= {5,4,9,2,8,7,7,9,6,8 };

            int maximumRevenue = Utilities.GetMaximumRevenue( arr2);
            Console.WriteLine("maximum Revenue is: {0}",maximumRevenue);


            //Q2
            //1.	Build a list of all courses that student has (StudentCourse)

            Faculty fac = new Faculty();

            var items = new List<StudentCourseGrade>()
            {                
                new StudentCourseGrade(1,1133,34),
                new StudentCourseGrade(1,1133,88),
                new StudentCourseGrade(1,1123,65),                
            };

            
            List<StudentCourse> studCourse ;
            foreach (var item in items)
            {
                StudentCourse sc new StudentCourse(item.);

                studCourse.Add(new StudentCourse())
            }

        }
    }

    static class Utilities
    {

        /// <summary>
        /// method that gets array of ints as an input and the output should be the maximum revenue
        /// </summary>
        /// <param name="arrRatesPrices"></param>
        /// <returns>the maximum revenue.</returns>
        internal static int GetMaximumRevenue(int[] arrRatesPrices)
        {
            //time complexity solution: O(N)
            int maxRevenue = 0;

            int size = arrRatesPrices.Length;
            if (size ==0 || size == 1)
            {
                return maxRevenue;
            }

            //in foolowing loop decide the min and the max in array
            int rateMin=0;
            int rateMax=0;

            for (int i = 0; i < size; i++)
            {
                if (i==0)
                {
                    rateMin = arrRatesPrices[i];
                    rateMax = arrRatesPrices[i];
                    continue;
                }

                if (arrRatesPrices[i] < rateMin)
                {
                    rateMin = arrRatesPrices[i];
                    
                }

                if (arrRatesPrices[i] > rateMax)
                {
                    rateMax = arrRatesPrices[i];
                }

            }


            maxRevenue = rateMax - rateMin;

            return maxRevenue;
            //throw new NotImplementedException();
        }
    }


    public class StudentCourseGrade
    {
        public int StudentId;
        public int CourseId;
        public int Grade;

        public StudentCourseGrade(int studentId, int courseId, int grade)
        {
            StudentId = studentId;
            CourseId = courseId;
            Grade = grade;
        }
    }

    public class StudentCourse
    {
        public int StudentId;
        public List<int> Courses;



        public StudentCourse(int studentId, List<int> courses) {
            StudentId = studentId;
            Courses = courses;
        }

        public void AddCourseToStudent(int courseId)
        {
            //StudentId = studentId;
            if (!Courses.Contains(courseId))
            {
                Courses.Add(courseId);
            }
            else
            {
                Console.WriteLine("the student already has this course");
            }
            
        }



    }



    public class Faculty
    {
        public List<StudentCourseGrade> data;

        public Faculty() { }

        public void AddItem(StudentCourseGrade item) {

            data.Add(item);


        }

            //public items = new List<StudentCourseGrade>();
    }
}
