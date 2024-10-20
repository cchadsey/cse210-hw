using System;

class Program
{
    static void Main(string[] args){

        static void animation(int Ardvarks){

            DateTime t = DateTime.Now;
            DateTime f = t.AddSeconds(Ardvarks);

            
            while (DateTime.Now < f){

                for (int i = 5; i > 0; i--){
                    Console.Write("+");
                    Thread.Sleep(100);
                }
                for (int i = 5; i > 0; i--){ 
                    Console.Write("\b \b");
                    Thread.Sleep(100);
                }
            }
        }
        
        animation(6);
        Console.WriteLine("loop1");
        animation(2);
        Console.WriteLine("done");
    }
}


