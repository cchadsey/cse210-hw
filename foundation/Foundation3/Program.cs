using System;

class Program
{
    static void Main(string[] args)
    {
        string d = DateTime.Now.ToString("dd MMMM yy");
        Activity swimming = new Swimming(d, 40.00, 14);
        swimming.getSummary();

        Activity running = new Running(d, 25, 400);
        running.getSummary();

        Activity biking = new Biking(d, 80, 45);
        biking.getSummary();

    }
}