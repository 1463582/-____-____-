using System;

class Program
{
    public static void Main()
    {
        //create array for months of the year
        string[] months = new string[12] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };

        //initialise prng with a time-dependent default seed value
        Random rnd = new Random();

        //will create a number between 1 and 12
        int month = rnd.Next(1, 13);

        //output the random month name
        Console.WriteLine("Month is {0}", months[month - 1]);


        //create array for days of the week
        string[] days = new string[7]
        {"Mon","Tue","Wed","Thu","Fri","Sat","Sun"};

        //initialise prng with a time-dependent default seed value
        Random jnd = new Random();

        //will create number between 1 and 7

        //output random weekday name
    }
}
