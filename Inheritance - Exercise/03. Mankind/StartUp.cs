using System;
using System.Linq;
using System.Collections.Generic;


   public class StartUp
    {
    static void Main(string[] args)
    {
        try
        {

            var chars = " ".ToCharArray();
            var studentInfo = Console.ReadLine().Split(chars,StringSplitOptions.RemoveEmptyEntries).ToArray();
            var workerInfo = Console.ReadLine().Split(chars,StringSplitOptions.RemoveEmptyEntries).ToArray();

            var studentFirstName = studentInfo[0];
            var studentLastName = studentInfo[1];
            var studentFacultyNumber = studentInfo[2];

            var workerFirstName = workerInfo[0];
            var workerLastName = workerInfo[1];
            var workerSalary = decimal.Parse(workerInfo[2]);
            var workerWorkingHours = decimal.Parse(workerInfo[3]);


            Student student = new Student(studentFirstName, studentLastName, studentFacultyNumber);

            Worker worker = new Worker(workerFirstName, workerLastName, workerSalary, workerWorkingHours);
   
            Console.WriteLine(student.ToString());
            Console.WriteLine();
            Console.WriteLine(worker.ToString());
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }




        }
    }
