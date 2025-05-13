using System;
using System.Security.AccessControl;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2026;
        job1._endYear = 2030;

        //test class
        // Console.WriteLine(job1._company);

        //test display job details
        // job1.DisplayJobDetails();

        Job job2 = new Job();
        job2._company = "Apple";
        job2._jobTitle = "Web Designer";
        job2._startYear = 2030;
        job2._endYear = 2058;

        //test class
        // Console.WriteLine(job2._company);

        //test display job details
        // job2.DisplayJobDetails();


        Resume resume1 = new Resume();
        resume1._name = "Donovan Poland";
        resume1._jobs = [job1, job2];

        //test display index 0 of jobs list
        // Console.WriteLine(resume1._jobs[0]._jobTitle);

        //test display resume details
        resume1.DisplayResume();

    }
}