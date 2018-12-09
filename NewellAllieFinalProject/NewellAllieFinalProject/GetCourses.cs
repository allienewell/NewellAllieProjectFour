using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewellAllieFinalProject
{
    class GetCourses
    {
        // Defines fields for GetCourses Custom Class
        private static int numberOfCourses2;
        private static string Name2;
        private static string Date2;
        private static string courseNo2;
        private static string courseType2;

        // Retrieves stored values from SetCourses Class
        public static int getNumberOfCourses2()
        {
            return SetCourses.getNumberOfCourses ();
        }

        public static string getName2()
        {
            return SetCourses.getName();
        }

        public static string getDate2()
        {
            return SetCourses.getDate();
        }

        public static string getCourseNo2()
        {
            return SetCourses.getCourseNo();
        }

        public static string getCourseType2()
        {
            return SetCourses.getCourseType();
        }
    }
}
