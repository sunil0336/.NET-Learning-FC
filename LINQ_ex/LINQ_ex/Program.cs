using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LINQ_ex
{
    internal class Program
    {
        static void Main(string[] args)

        {

            string[] names = { "Bill", "Sunil", "Sakshi", "jadu", "Ajit" };


            var myLinqQuery = from name in names
                              where name.Contains('j')
                              select name;

            Console.WriteLine("linqu printing ");

            foreach (var name in myLinqQuery)
            {
                Console.WriteLine(name);
            }

            Student[] studentArray ={
            new Student() { StudentId =1,StudentName="vaibhav",Age=24 },
            new Student() { StudentId =2,StudentName="jhon",Age=11 },

            new Student() { StudentId =3,StudentName="sujeet",Age=4 },

            new Student() { StudentId =4,StudentName="arjun",Age=40 },
            new Student() { StudentId =5,StudentName="ghansham",Age=10 },
            new Student() { StudentId =6,StudentName="Sham",Age=17 },
            new Student() { StudentId =7,StudentName="Ram",Age=19 },



            };
            Student[] students = new Student[10];

            int i = 0;
            Console.WriteLine("Linq unsig collections");
            foreach (var std in studentArray)
            {
                if (std.Age > 12 && std.Age < 20)
                {

                    students[i] = std;
                    Console.WriteLine(students[i].StudentId+" " + students[i].StudentName);
                    i++;
                }

            }
            Console.ReadLine();
        }





        class Student {

            public int StudentId { get; set; }

            public string StudentName { get; set; }

            public int Age { get; set; }



        }

        }
    }



