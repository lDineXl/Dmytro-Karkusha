using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>()
            {
                new Student("Dima","Karkusha","Andreevich","CIT","Computer games",50f,'a'),
                new Student("Dima","Menshakov","Olegovich","CIT","Computer games",100f,'a'),
            };

            var collection = new Collection();

            foreach (var stud in students)
            {
                collection.Add(stud);
            }

            Console.WriteLine(collection["Yampolskyi", "Dima"]?.ToString());
            Console.WriteLine(collection["Yampolskyiddd", "Dima"]?.ToString());

            foreach (var student in collection)
            {
                Console.WriteLine(student.ToString());
            }
            Console.ReadLine();
        }
    }
}
