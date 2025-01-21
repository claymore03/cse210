using System;
class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        Job job2 = new Job();
        Resume myResume = new Resume();
        
        job1.GetJobTitle();
        job1.GetCompanyName();
        job1.GetStartYear();
        job1.GetEndYear();

        job2.GetJobTitle();
        job2.GetCompanyName();
        job2.GetStartYear();
        job2.GetEndYear();

        
        myResume._name = "Clayton Redding";
        
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.DisplayResume();
    }
}