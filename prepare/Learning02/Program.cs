using System;

class Program
{
    static void Main(string[] args)
    {
        
        //Console.WriteLine("Hello Learning02 World!");
        Job job1 = new Job();
        Job job2 = new Job();
        Resume resume = new Resume();
        job1._company = "Google";
        job1._jobTitle = "Software Developer";
        job1._startYear = 2016;
        job1._endYear = 2020;

        job2._company = "Facebook";
        job2._jobTitle = "Software Engineer";
        job2._startYear = 2020;
        job2._endYear = 2023;

        resume._jobs.Add(job1);
        resume._jobs.Add(job2);
        resume._name = "Victor Asuquo";

        //job1.DisplayJob();
        //job2.DisplayJob();
        resume.DisplayResume();
    }
}