using System;

namespace task5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Иван";
            string secondName = "Иванов";
            string tempReplaceSpace;

            Console.WriteLine(firstName + " " + secondName );

            tempReplaceSpace = firstName;
            firstName = secondName;
            secondName = tempReplaceSpace;            

            Console.WriteLine(firstName + " " +secondName);
        }
    }
}
