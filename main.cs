using System;

class Program {
  public static void Main (string[] args) {

    int counter=0;
    int total=0;

    while (counter<7)
    {

    Console.WriteLine("Enter the distance of Car");
    int distance = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the time of Car");
    int time = Convert.ToInt32(Console.ReadLine());
    int speed = (distance/time);
    Console.WriteLine("The speed of this car is " + speed + " miles per hour");
    
    total = total + speed;
    counter++;
    

    double average=0;
    average=total/7;

    Console.WriteLine ("The average speed of the cars is " + average + " miles per hour");
    }
  }
}