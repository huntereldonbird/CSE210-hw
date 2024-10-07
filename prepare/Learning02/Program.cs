using System;

class Program
{
    static void Main()
    {

        Job Job1 = new Job();

        Job1._company = "microsoft";
        Job1._jobtitle = "software engineer";
        Job1._startyear = 2004;
        Job1._endyear = 2008;

        Job Job2 = new Job();

        Job2._company = "apple";
        Job2._jobtitle = "software engineer";
        Job2._startyear = 2008;
        Job2._endyear = 2012;


        Resume resume = new Resume();

        resume._name = "THIS GUY";

        resume._jobs.Add(Job1);
        resume._jobs.Add(Job2);

        resume.Display();
    }
}
