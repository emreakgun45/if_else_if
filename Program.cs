using System;

namespace if_else_if
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = DateTime.Now.Hour;
            System.Console.WriteLine("Saat: " + time);
            if(time>=6 && time <=11)
                System.Console.WriteLine("Gunaydin!");
            else if(time <= 18)
                System.Console.WriteLine("Iyi gunler!");
            else
                System.Console.WriteLine("Iyi geceler!");


            string sonuc = time<=18 ? "Iyi gunler!" : "Iyi geceler!";
            
            sonuc = time>=6 && time <= 11 ? "Gunaydin!" : time<= 18 ? "Iyi gunler!" : "Iyi aksamlar";

            System.Console.WriteLine(sonuc);

        }
    }
}
