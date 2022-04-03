using System;
using ClassLibrary;
namespace CSharp_Static
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //task-1
            string str = "salam4";
            int i = 23;
            Console.WriteLine($"tekdirmi? -> {i.IsOdd()}");
            Console.WriteLine($"cudurmu? -> {i.IsEven()}");
            Console.WriteLine($"icerisinde reqem varmi? -> {str.IsContainsDigit()}");
            Console.WriteLine($"herfleri boyut -> {str.ToCapitalize()}");
            foreach (var item in str.GetValueIndexes('a'))
            {
                Console.WriteLine($"char index -> {item}");
            }



            //task-2
            string fullName = "";
            do
            {
                Console.WriteLine("Telebenin adini ve soyadini daxil edin: ");
                fullName = Console.ReadLine();
            } while (!Student.CheckFullname(fullName));

            string groupNo = "";
            do
            {
                Console.WriteLine("Telebenin qrupunu daxil edin: ");
                groupNo = Console.ReadLine();
            } while (!Student.CheckGroupNo(groupNo));

            Console.WriteLine("Telebenin yasini daxil edin: ");
            byte age = Convert.ToByte(Console.ReadLine());
            Student student = new Student(fullName, groupNo, age);
            Console.WriteLine($"fullname: {student.FullName} | groupNo: {student.GroupNo} | age: {student.Age}");

        }
    }
}
