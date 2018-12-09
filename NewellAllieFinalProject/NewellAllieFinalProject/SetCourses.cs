using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewellAllieFinalProject
{
    public static class SetCourses
    {
        // Defines fields for SetCourses Custom Class
        private static int numberOfCourses;
        private static string Name;
        private static string Date;
        private static string courseNo;
        private static string courseType;

        // Defines methods for SetCourses Custom Class that retrieves and stores data from user inputs
        public static int getNumberOfCourses()
        {
            return numberOfCourses;
        }

        public static void setNumberOfCourses(string noCourses)
        {
            numberOfCourses = Convert.ToInt32(noCourses);
        }

        public static string getName()
        {
            return Name;
        }

        public static void setName(string studentName)
        {
            Name = studentName;
        }

        public static string getDate()
        {
            return Date;
        }

        public static void setDate(string startDate)
        {
            Date = startDate;
        }

        public static string getCourseNo()
        {
            return courseNo;
        }

        public static void setCourseNo(string courseNumber)
        {
            courseNo = courseNumber;
        }

        public static string getCourseType()
        {
            return courseType;
        }

        public static void setCourseType(string typeOfCourse)
        {
            courseType = typeOfCourse;
        }
    }
}