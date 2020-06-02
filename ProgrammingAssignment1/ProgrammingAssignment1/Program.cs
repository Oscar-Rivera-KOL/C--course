using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingAssignment1
{   
    class Program
    {
        /// <summary>
        /// Calculate the distance between two points
        /// </summary>
        static void Main(string[] args)
        {
            // Print Welcome Message
            Console.WriteLine("Hello User. This application will calculate the distance between two points" 
                +"and the angle between those points");
            
            Console.WriteLine("---------------------------------------------------------------------");
            //Indicate user to input the coordinates of the first point (x1,y1)
            Console.WriteLine("Please insert the coordinates of the first point");
            Console.Write("Enter first x value: ");
            float point1X = float.Parse(Console.ReadLine());

            Console.Write("Enter first y value: ");
            float point1Y = float.Parse(Console.ReadLine());

            Console.WriteLine("---------------------------------------------------------------------");

            //Indicate user to input the coordinates of the Second point (x2,y2)
            Console.WriteLine("Please insert the coordinates of the second point.");
            Console.Write("Enter second x value: ");
            float point2X = float.Parse(Console.ReadLine());

            Console.Write("Enter second y value: ");
            float point2Y = float.Parse(Console.ReadLine());

            Console.WriteLine("---------------------------------------------------------------------");
            // Carry out deltaX / deltaY / distance / angle calculation
            float deltaX = point2X - point1X;
            float deltaY = point2Y - point1Y;
            float distance = (float)Math.Sqrt(Math.Pow(deltaX,2) + Math.Pow(deltaY,2));
            float angle = (float)Math.Atan2(deltaY/distance);

            Console.WriteLine("The results are: "+ 
                "Distance between point 1" + point1X +","+point1Y +" and the point 2" + point2X + "," + point2Y +" is: "+distance+
                "The angle is:" + angle
                );



        }
    }

}
