using System;

class Program
{
    static void Main(string[] args)
    {
        //Creating the first job object
        Job job1 = new Job();

        //adding the member variables for the first job object
        job1._jobTitle = "Snark Inspector";
        job1._company = "Corporation Corp";
        job1._startYear = 1923;
        job1._endYear = 2023;

        //Creating the second job object
        Job job2 = new Job();

        //adding the member variables for the second job object
        job2._jobTitle = "Director of Distress Distrobution";
        job2._company = "Daniel Inc";
        job2._startYear = 2023;
        job2._endYear = 2024;

        //creating the resume object. 
        Resume thisHereResume = new Resume();

        //setting the name member variable to my own name
        thisHereResume._name = "Camden Chadsey";

        //adding the jobs to the resume object's jobs variable. 
        thisHereResume._jobs.Add(job1);
        thisHereResume._jobs.Add(job2);

        //Calling for the program to display the resume object using its display method
        thisHereResume.Display();


    }
}