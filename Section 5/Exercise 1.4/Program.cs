using System;

namespace Section5Exercise14
{
    /// <summary>
    /// Your job is to write a program for a speed camera.
    /// For simplicity, ignore the details such as camera, sensors, etc and focus purely on the logic.
    /// Write a program that asks the user to enter the speed limit.
    /// Once set, the program asks for the speed of a car.
    /// If the user enters a value less than the speed limit, program should display Ok on the console.
    /// If the value is above the speed limit, the program should calculate the number of demerit points.
    /// For every 5km/hr above the speed limit, 1 demerit points should be incurred and displayed on the console.
    /// If the number of demerit points is above 12, the program should display License Suspended.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the speed limit:");
            var speedLimit = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the speed of a car:");
            var speedCar = int.Parse(Console.ReadLine());

            if (speedCar < speedLimit) {
                Console.Write("Ok");
            } else {
                const int kmPerDemeritPoint = 5;
                var demeritPoints = (speedCar - speedLimit) / kmPerDemeritPoint;

                if (demeritPoints > 12) {
                    Console.WriteLine("License Suspended.");
                } else {
                    Console.WriteLine("Demerit Points: {0}", demeritPoints);
                }
            }

        }
    }
}
