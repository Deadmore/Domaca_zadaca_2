using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zadatak_1;
using Zadatak_4;

namespace Tester_1
{ // classa za testanje linq metoda
    class Program
    {
       /* static void Main(string[] args)
        {
            University FER = new University();
            FER.Name = "FER";

            Student Ante = new Student("Ante", "0036");
            Ante.Gender = Gender.Male;
            Student Bernard = new Student("Bernard", "0035");
            Bernard.Gender = Gender.Male;
            Student Ante1 = new Student("Ante", "0036");
            Ante1.Gender = Gender.Male;
            Student Stjepan = new Student("Stjepan", "0031");
            Stjepan.Gender = Gender.Male;

            Student[] students = new Student[4];

            students[0] = Ante;
            students[1] = Ante1;
            students[2] = Bernard;
            students[3] = Stjepan;

            FER.Students = students;

            University FIL = new University();
            FIL.Name = "FIL";

            Student Ana = new Student("Ana", "3036");
            Ana.Gender = Gender.Female;
            Student Bernarda = new Student("Bernarda", "3035");
            Bernarda.Gender = Gender.Female;
            Student Stjepana = new Student("Stjepan", "3031");
            Stjepana.Gender = Gender.Male;
            Student Ante2 = new Student("Ante", "0036");
            Ante.Gender = Gender.Male;

            Student[] studentsf = new Student[4];

            studentsf[0] = Ana;
            studentsf[3] = Ante2;
            studentsf[2] = Bernarda;
            studentsf[1] = Stjepan;

            FIL.Students = studentsf;

            University[] Faksovi = {FER, FIL};
            Faksovi[0] = FER;
            Faksovi[1] = FIL;

            Student[] s = HomeworkLinqQueries.Linq2_5(Faksovi);

            foreach (Student stu in s)
            {
                Console.WriteLine(stu.Name + stu.Jmbag);
            }
        } */

        public static void Main(String[] args)
        {
            University[] lista = GetAllCroatianUniversities();

            Student[] stu = HomeworkLinqQueries.Linq2_5(lista);

            foreach (Student s in stu)
            {
                Console.WriteLine(s.Name + " " + s.Jmbag);
            }

        }

        private static University[] GetAllCroatianUniversities()
        {
            return new University[]
            {
                new University()
                {
                    Name = "Uni1",
                    Students = new Student[]
                    {
                        new Student("1", "1"){Gender = Gender.Male},
                        new Student("2", "2"){Gender = Gender.Male},
                    }
                },
                new University()
                {
                    Name = "Uni2",
                    Students = new Student[]
                    {
                        new Student("3", "3"){Gender = Gender.Female},
                        new Student("4", "4"){Gender = Gender.Female},
                    }
                },
                new University()
                {
                    Name = "Uni3",
                    Students = new Student[]
                    {
                        new Student("2", "2"){Gender = Gender.Male},
                        new Student("5", "5"){Gender = Gender.Female},
                        new Student("6", "6"){Gender = Gender.Female},
                        new Student("7", "7"){Gender = Gender.Female},
                        new Student("8", "8"){Gender = Gender.Female},
                        new Student("9", "9"){Gender = Gender.Male},
                        new Student("10", "10"){Gender = Gender.Male},
                        new Student("11", "11"){Gender = Gender.Male},
                    }
                },
                new University()
                {
                    Name = "Uni4",
                    Students = new Student[]
                    {
                        new Student("12", "12"){Gender = Gender.Male},
                        new Student("13", "13"){Gender = Gender.Male},
                        new Student("14", "14"){Gender = Gender.Female},
                    }
                },
                new University()
                {
                    Name = "Uni5",
                    Students = new Student[]
                    {
                        new Student("1", "1"){Gender = Gender.Male},
                        new Student("4", "4"){Gender = Gender.Female},
                        new Student("16", "16"){Gender = Gender.Female},
                        new Student("17", "17"){Gender = Gender.Female},
                        new Student("18", "18"){Gender = Gender.Female},
                        new Student("19", "19"){Gender = Gender.Female},
                        new Student("20", "20"){Gender = Gender.Female},
                        new Student("21", "21"){Gender = Gender.Female},
                        new Student("22", "22"){Gender = Gender.Female},
                        new Student("23", "23"){Gender = Gender.Female},
                        new Student("24", "24"){Gender = Gender.Female},
                        new Student("25", "25"){Gender = Gender.Male},
                        new Student("26", "26"){Gender = Gender.Male},
                        new Student("27", "27"){Gender = Gender.Male},
                        new Student("28", "28"){Gender = Gender.Male},
                        new Student("29", "29"){Gender = Gender.Male},

                    }
                },
                new University()
                {
                    Name = "Uni6",
                    Students = new Student[]
                    {
                        new Student("1", "1"){Gender = Gender.Male},
                        new Student("30", "30"){Gender = Gender.Male},
                        new Student("31", "31"){Gender = Gender.Male},
                        new Student("32", "32"){Gender = Gender.Male},
                    }
                }

            };
        }
    }
}
