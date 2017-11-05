using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Zadatak_1;

namespace Zadatak_4
{
    public class HomeworkLinqQueries
    {
        public static string[] Linq1(int[] intArray)
        {
            return intArray.Distinct().OrderBy(x => x).Select(i => $"Broj {i} ponavlja se {intArray.Count(s => s == i)} puta").ToArray();
        }
        public static University[] Linq2_1(University[] universityArray)
        {
            return universityArray.Where(s => s.Students.Count() == s.Students.Count(i => i.Gender == Gender.Male)).ToArray();
        }
        public static University[] Linq2_2(University[] universityArray)
        {
            return universityArray.Where(s => s.Students.Count() < universityArray.Average(i => i.Students.Count())).ToArray();
        }
        public static Student[] Linq2_3(University[] universityArray)
        {
            return universityArray.SelectMany(s => s.Students).Distinct().ToArray();
        }
        public static Student[] Linq2_4(University[] universityArray)
        {
            return universityArray
                .Where(s =>s.Students.Count() == s.Students.Count(i => i.Gender == Gender.Male) || s.Students.Count() == s.Students.Count(i => i.Gender == Gender.Female)).
                SelectMany(stu => stu.Students).Distinct().ToArray();
        }
        public static Student[] Linq2_5(University[] universityArray)
        {
            return universityArray
                .SelectMany(stu => stu.Students).GroupBy(x => x).Where(group => group.Count() > 1)
                .Select(group => group.Key).ToArray();
        }
    }

    public class University
    {
        public string Name { get; set; }
        public Student[] Students { get; set; }
    }

}
