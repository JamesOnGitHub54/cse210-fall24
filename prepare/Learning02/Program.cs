class Program
{
    static void Main(string[] args)
    {
        //Add new Jobs
        Job job1 = new Job();
        job1._title = "Quality Assurance";
        job1._company = "Advanced Micro Devices";
        job1._startYear = 2022;
        job1._endYear = 2024;

        Job job2 = new Job();
        job2._title = "Customer Service";
        job2._company = "Corsair Gaming";
        job2._startYear = 2020;
        job2._endYear = 2022;


        //Add Resume
        Resume resume1 = new Resume();
        resume1._name = "Peter Hill";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);


        resume1.Display();
    }
}